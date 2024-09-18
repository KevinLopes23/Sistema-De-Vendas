using Cprod.code.Apoio;
using Cprod.code.bll;
using Cprod.code.dto.dto;
using System.Data;

namespace Cprod.forms
{
    public partial class FrmPesquisaDeMarcas : Form
    {
        public FrmPesquisaDeMarcas()
        {
            InitializeComponent();
        }

        private void PreencheGrid(string marca)
        {
            try
            {
                CprodBll bll = new CprodBll();
                DataTable tabela = bll.PesquisaMarca(marca);
                dgMarca.AutoGenerateColumns = true;
                dgMarca.DataSource = tabela.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao disparar ao preeencher o grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void PesquisaPorDescricao(string marca)
        {

            try
            {
                CprodBll bll = new CprodBll();

                DataTable dt = bll.PesquisaMarca(marca);

                dgMarca.AutoGenerateColumns = true;

                // Converte o DataTable para um DataView e o vincula ao DataGrid
                dgMarca.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exibir os dados no grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void RecarregarGrid()
        {
            try
            {
                CprodBll bll = new CprodBll();
                dgMarca.DataSource = bll.PesquisaMarca(txtPesquisaMarca.Text); // Recarrega os dados no grid com base na pesquisa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao recarregar o grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BotaoExcluir()
        {
            try
            {
                if (dgMarca.CurrentRow != null)
                {
                    int codigomarca = int.Parse(dgMarca.CurrentRow.Cells["CODIGO"].Value.ToString());

                    DialogResult result = MessageBox.Show("Deseja realmente excluir?", Constantes.NOME_APLICACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CprodBll bll = new CprodBll();
                        bool excluido = bll.ExcluirMarca(codigomarca);

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



        public void JogaDadosProGrid()
        {

            try
            {
                if (dgMarca.CurrentRow != null)
                {
                    int codigomarca = Convert.ToInt32(dgMarca.CurrentRow.Cells["CODIGO"].Value);

                    CprodBll bll = new();
                    MarcaDto dto = new MarcaDto();
                    dto = bll.DadosMarca(codigomarca);

                    int codmarca = dto.CodigoMarca;
                    string descricao = dto.Descricao;



                    FrmCadastroMarca formCadastroMarcas = new FrmCadastroMarca();



                    // Preenche os campos com os dados da linha selecionada no DataGrid
                    formCadastroMarcas.txtCodigo.Text = codmarca.ToString();
                    formCadastroMarcas.txtDescricao.Text = descricao;


                    formCadastroMarcas.ShowDialog();

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





        private void FrmPesquisaDeMarcas_Load(object sender, EventArgs e)
        {
            PreencheGrid(string.Empty);

            txtPesquisaMarca.MaxLength = 50;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PesquisaPorDescricao(txtPesquisaMarca.Text);


            if (dgMarca.CurrentRow == null)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroMarca cadastroDeMarca = new FrmCadastroMarca();
            cadastroDeMarca.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            JogaDadosProGrid();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPesquisaMarca.Text = string.Empty;
            RecarregarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            BotaoExcluir();
            RecarregarGrid();
        }

        private void txtPesquisaMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }
    }
}
