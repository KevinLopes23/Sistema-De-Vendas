using Cprod.code.Apoio;
using Cprod.code.bll;
using Cprod.code.dal;
using Cprod.code.dto.dto;
using System.Data;

namespace Cprod.forms
{
    public partial class FrmVendas : Form
    {

        public FrmVendas()
        {
            InitializeComponent();

        }


        public void Gravar()
        {

            CprodBll bll = new();
            try
            {
                VendaDTO venda = new VendaDTO();
                List<ItemVendaDTO> listaItens = new List<ItemVendaDTO>();


                foreach (DataGridViewRow item in dgProdutos.Rows)
                {
                    ItemVendaDTO itens = new ItemVendaDTO();


                    itens.CodProduto = Convert.ToInt32(item.Cells["CODIGOPRODUTO"].Value);
                    itens.Quantidade = Convert.ToInt32(item.Cells["QUANTIDADE"].Value);
                    itens.Valor = Convert.ToDecimal(item.Cells["PRECO"].Value);


                    bool estoqueDisponivel = bll.VerificaExtoqueDisponivel(itens.CodProduto, itens.Quantidade);


                    if (!estoqueDisponivel)
                    {
                        MessageBox.Show($"Estoque insuficiente para o produto de Codigo : {itens.CodProduto}");
                        lblEstoqueDisponivel.Text = string.Empty;
                        dgProdutos.Rows.Clear();
                        return;

                    }
                    else
                    {
                        listaItens.Add(itens);
                    }


                }
                bool retornoDaTransação = bll.GravarVendaComItens(venda, listaItens);
                MessageBox.Show("Venda Cadastrada com sucesso", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblEstoqueDisponivel.Text = string.Empty;
                dgProdutos.Rows.Clear();







            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao cadastrar a venda", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public Boolean VerificaCampos()
        {
            if (string.IsNullOrEmpty(cmbProdutos.Text))
            {

                MessageBox.Show("Selecione o produto desejado !");
                cmbProdutos.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Selecione a quantidade desejada !");
                txtQuantidade.Focus();
                return false;
            }

            int quantidade;

            if (int.TryParse(txtQuantidade.Text, out quantidade))
            {

                if (quantidade <= 0)
                {
                    MessageBox.Show("A quantidade deve ser maior que zero.");
                    txtQuantidade.Text = string.Empty;
                    txtQuantidade.Focus();
                    return false;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
            }


            return true;
        }

        public void TransfereDadosParaDataGrid()
        {
            try
            {

                if (!VerificaCampos())
                {
                    return;
                }




                string codproduto = cmbProdutos.SelectedValue.ToString(); ;
                string descricao = cmbProdutos.Text;
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                decimal preco = Convert.ToDecimal(txtPreco.Text);


                bool produtoExistente = false;



                foreach (DataGridViewRow row in dgProdutos.Rows)
                {
                    if (row.Cells["CODIGOPRODUTO"].Value.ToString() == codproduto)
                    {

                        int quantidadeExistente = int.Parse(row.Cells["QUANTIDADE"].Value.ToString());
                        row.Cells["QUANTIDADE"].Value = quantidadeExistente + quantidade;

                        produtoExistente = true;

                        break;

                    }
                }

                CprodBll bll = new CprodBll();

                int id = Convert.ToInt32(cmbProdutos.SelectedValue);
                int qtd = Convert.ToInt32(txtQuantidade.Text);

                bool estoqueDisponivel = bll.VerificaExtoqueDisponivel(id, qtd);

                if (!estoqueDisponivel)
                {
                    MessageBox.Show($"Quantidade insuficiente para o produto de codigo {id}");
                    txtQuantidade.Text = string.Empty;
                    txtQuantidade.Focus();
                    return;
                }


                if (!produtoExistente)
                {
                    dgProdutos.Rows.Add(codproduto, descricao, quantidade, preco);
                }




                if (dgProdutos.Rows.Count > 0)
                {
                    btnGravar.Enabled = true;
                }


                cmbProdutos.SelectedIndex = -1;
                txtQuantidade.Clear();
                txtPreco.Clear();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao passar os dados para o datagrid " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ColocaCombobox()
        {

            try
            {
                CProdDal dal = new CProdDal();
                DataTable dt = dal.ColocaProdutoComboBox();

                cmbProdutos.DataSource = dt;
                cmbProdutos.DisplayMember = "DESCRICAO";
                cmbProdutos.ValueMember = "CODPRODUTO";
                cmbProdutos.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o combobox " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            ColocaCombobox();
            btnGravar.Enabled = false;

        }

        private void cmbProdutos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)cmbProdutos.SelectedItem;

            if (drv != null)
            {
                txtPreco.Text = drv["PRECO"].ToString();
            }



            int codigoProduto = Convert.ToInt32(drv["CODPRODUTO"]);

            CprodBll bll = new CprodBll();
            int quantidadeDisponivel = bll.ColocaQuantidadeLabel(codigoProduto);

            lblEstoqueDisponivel.Text = $"Quantidade disponível: {quantidadeDisponivel}";
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            TransfereDadosParaDataGrid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();



        }


    }
}
