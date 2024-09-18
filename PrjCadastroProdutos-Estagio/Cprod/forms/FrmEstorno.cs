using Cprod.code.bll;
using Cprod.code.dto.dto;

namespace Cprod.forms
{
    public partial class FrmEstorno : Form
    {
        public FrmEstorno()
        {
            InitializeComponent();
        }

        public void PreencheGridEstorno()
        {
            CprodBll bll = new CprodBll();
            string codvenda = txtCodigoVenda.Text;

            dgEstorno.DataSource = bll.PreencheGridEstorno(codvenda);
            btnEstorno.Enabled = dgEstorno.Rows.Count != 0;

        }



        public Boolean Estorno()
        {

            // Exibe uma caixa de confirmação para o usuário
            DialogResult confirmResult = MessageBox.Show("Você tem certeza que deseja estornar a venda?",
                                                         "Confirmar Estorno", MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);


            if (confirmResult == DialogResult.Yes)
            {

                List<ItemVendaDTO> lista = new List<ItemVendaDTO>();
                //  ItemVendaDTO dto = new ItemVendaDTO();

                string codvenda = txtCodigoVenda.Text;




                foreach (DataGridViewRow row in dgEstorno.Rows)
                {

                    if (row.Cells["QTDADE"].Value != null && row.Cells["CODPRODUTO"].Value != null)
                    {
                        ItemVendaDTO dto = new ItemVendaDTO();

                        dto.Quantidade = Convert.ToInt32(row.Cells["QTDADE"].Value);
                        dto.CodProduto = Convert.ToInt32(row.Cells["CODPRODUTO"].Value);
                        dto.CodVenda = Convert.ToInt32(txtCodigoVenda.Text);

                        if (dto.Quantidade == 0)
                        {
                            MessageBox.Show("Quantidade tem que ser maior que zero");
                            return false;
                        }

                        lista.Add(dto);

                    }
                }

                // Passa as listas de produtos e quantidades para o método de estorno
                CprodBll bll = new CprodBll();


                bool resultado = bll.Estorno(lista);

                if (resultado)
                {
                    MessageBox.Show($"Venda número {codvenda} excluída com sucesso!");
                    txtCodigoVenda.Text = string.Empty;
                    dgEstorno.DataSource = null;
                    txtCodigoVenda.Focus();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir a venda!");
                }

                return true;
            }
            return false;
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            PreencheGridEstorno();
        }

        private void txtCodigoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnEstorno_Click(object sender, EventArgs e)
        {
            Estorno();
        }

        private void FrmEstorno_Load(object sender, EventArgs e)
        {
            btnEstorno.Enabled = false;
        }
    }
}
