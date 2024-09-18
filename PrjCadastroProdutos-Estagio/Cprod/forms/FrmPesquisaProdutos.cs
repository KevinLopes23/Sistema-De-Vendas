using Cprod.code.Apoio;
using Cprod.code.bll;
using Cprod.code.dto.dto;
using Cprod.forms;
using System.Data;

namespace Cprod
{
    public partial class FrmPesquisaProdutos : Form
    {


        //private FrmCadastroProdutos formCadastro;

        public FrmPesquisaProdutos()
        {
            InitializeComponent();
            //  this.formCadastro = formCadastro;

        }



        private bool VerificaCampos()
        {

            try
            {
                if (cmbFiltro.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Insira um filtro válido",
                        Constantes.NOME_APLICACAO,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );

                    cmbFiltro.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar os campos: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }



        public void RecarregarGrid()
        {
            try
            {
                CprodBll bll = new CprodBll();
                dgProdutos.DataSource = bll.PesquisaProdutos("", ""); // Recarrega os dados no grid com base na pesquisa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao recarregar o grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void JogaDadosProGrid()
        {

            try
            {




                if (dgProdutos.CurrentRow != null)
                {
                    int codigoCliente = Convert.ToInt32(dgProdutos.CurrentRow.Cells["CODPRODUTO"].Value);

                    CprodBll bll = new();
                    ProdutosDto dto = new ProdutosDto();
                    dto = bll.DadosCliente(codigoCliente);

                    int codproduto = dto.CodigoProduto;
                    string descricao = dto.Descricao;
                    float qtdestoque = dto.QuantidadeEstoque;
                    double preco = dto.Preco;
                    DateTime datavencimento = dto.DataVencimento;
                    int codmarca = dto.CodigoMarca;
                    string tpregistro = dto.TipoRegistro;



                    FrmCadastroProdutos formCadastro = new FrmCadastroProdutos();
                    //formCadastro.Show();


                    // Preenche os campos com os dados da linha selecionada no DataGrid
                    formCadastro.txtCodigoProduto.Text = codproduto.ToString();
                    formCadastro.txtDescricao.Text = descricao.ToString();
                    formCadastro.txtEstoque.Text = qtdestoque.ToString();
                    formCadastro.txtPreco.Text = preco.ToString();
                    formCadastro.txtDataVencimento.Text = datavencimento.ToString();
                    formCadastro.cmbMarca.SelectedValue = dto.CodigoMarca.ToString();
                    formCadastro.txtTipoRegistro.Text = tpregistro.ToString() == "M" ? "MANUAL" : "IMPORTADO";

                    formCadastro.ShowDialog();

                    RecarregarGrid();

                    //txtSexo.Text = dgCliente.CurrentRow.Cells["SEXO"].Value.ToString() == "F" ? "Feminino" : "Masculino";


                }
                else
                {



                    MessageBox.Show("Por favor, selecione um cliente no grid para alterar.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao jogar os dados pro textbox: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }




        private void DisparaBuscaPorFiltro()
        {
            try
            {

                if (!VerificaCampos())
                {
                    return;

                }
                else
                {
                    CprodBll bll = new CprodBll();
                    string filtro = cmbFiltro.SelectedItem.ToString();
                    string valor = txtPesquisa.Text;

                    dgProdutos.DataSource = bll.PesquisaProdutos(filtro, valor);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao disparar a busca por  filtro: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BotaoExcluir()
        {
            try
            {
                if (dgProdutos.CurrentRow != null)
                {
                    int codigoDoProduto = int.Parse(dgProdutos.CurrentRow.Cells["CODPRODUTO"].Value.ToString());

                    DialogResult result = MessageBox.Show("Deseja realmente excluir?", Constantes.NOME_APLICACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CprodBll bll = new CprodBll();
                        bool excluido = bll.ExcluirClientePorCodigoDoProduto(codigoDoProduto);

                        if (excluido)
                        {
                            MessageBox.Show("Cliente excluído com sucesso!", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado ou não pôde ser excluído.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PreencheGrid()
        {
            try
            {
                CprodBll bll = new CprodBll();
                DataTable tabela = bll.PesquisaProdutos("", "");
                dgProdutos.AutoGenerateColumns = true;
                dgProdutos.DataSource = tabela.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao disparar ao preeencher o grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void FrmPesquisaProdutos_Load(object sender, EventArgs e)
        {
            PreencheGrid();


            cmbFiltro.Text = "DESCRICAO";

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DisparaBuscaPorFiltro();


            if (dgProdutos.CurrentRow == null)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
            else
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }



        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DisparaBuscaPorFiltro();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = char.ToUpper(e.KeyChar);

            if (Util.IsNumber(cmbFiltro))
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void txtFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            FrmCadastroProdutos formcadastro = new FrmCadastroProdutos();
            formcadastro.Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
            dgProdutos.Refresh();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            JogaDadosProGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            BotaoExcluir();
            RecarregarGrid();
        }
    }
}