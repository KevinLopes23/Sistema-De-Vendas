using Cprod.code.Apoio;
using Cprod.code.bll;
using Cprod.code.dal;
using Cprod.code.dto.dto;

namespace Cprod.forms
{
    public partial class FrmCadastroMarca : Form
    {
        public FrmCadastroMarca()
        {
            InitializeComponent();
        }


        public void LimitaCaracteres()
        {

            try
            {
                txtCodigo.MaxLength = 20;
                txtDescricao.MaxLength = 30;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro a limitar caracteres: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void GeraId()
        {
            try
            {
                CProdDal dal = new CProdDal();
                int novoCodigo = dal.GeraCodigoMarca();
                txtCodigo.Text = novoCodigo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gerar novo id: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        public void BotaoGravar()
        {

            try
            {

                if (!VerificaDescriçãoPreenchida())
                {
                    return;
                }


                if (ValidaDescricaoMarca())
                {
                    return;
                }


                GeraId();


                MarcaDto dto = new MarcaDto();
                dto.CodigoMarca = int.Parse(txtCodigo.Text);
                dto.Descricao = txtDescricao.Text;


                CprodBll bll = new CprodBll();

                Boolean retorno = bll.GravarMarca(dto);


                if (retorno == true)
                {
                    MessageBox.Show(
                    "Gravado com Sucesso, muito obrigado", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricao.Text = string.Empty;
                    txtCodigo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(
                    "Erro ao gravar. Consulte o suporte.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao gravar os campos: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        public Boolean VerificaDescriçãoPreenchida()
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show(
                   "Insira uma descrição valida",
                   Constantes.NOME_APLICACAO,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
                   );
                txtDescricao.Focus();
                return false;
            }
            return true;

        }



        private void AtualizarMarca()
        {
            try
            {

                //// if (!VerificaCamposPreenchidos())
                // {
                //     return;
                // }


                //  ValidaDescricaoAtualizar();



                if (!VerificaDescriçãoPreenchida())
                {
                    return;
                }

                MarcaDto dto = new MarcaDto
                {
                    CodigoMarca = int.Parse(txtCodigo.Text),
                    Descricao = txtDescricao.Text
                };





                CprodBll bll = new CprodBll();
                bool atualizado = bll.AtualizarMarca(dto);
                //        FrmPesquisaProdutos pesquisa = new FrmPesquisaProdutos();
                //      pesquisa.ShowDialog();



                if (atualizado)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        pesquisa.RecarregarGrid();
                }

                else
                {
                    MessageBox.Show("Não foi possível atualizar o cliente.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o cliente: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public bool ValidaDescricaoMarca()
        {
            CprodBll bll = new CprodBll();


            if (!string.IsNullOrEmpty(txtDescricao.Text))
            {
                if (bll.ValidaDescricaoMarca(txtDescricao.Text))
                {
                    MessageBox.Show("Descrição  já cadastrada no sistema", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Text = string.Empty;
                    txtDescricao.Focus();
                    return true;
                }
            }

            return false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                BotaoGravar();
            }
            else
            {
                AtualizarMarca();
            }

            // this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = string.Empty;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void FrmCadastroMarca_Load(object sender, EventArgs e)
        {
            txtDescricao.MaxLength = 50;
        }
    }

}

