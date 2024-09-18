using Cprod.code.Apoio;
using Cprod.code.bll;



namespace Cprod
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool ValidarLogin(string usuario, string senha)
        {
            CprodBll bll = new CprodBll();

            try
            {

                if (string.IsNullOrWhiteSpace(usuario))
                {
                    MessageBox.Show("Por favor, preencha seu usuario.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return false;

                }


                if (string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Por favor, preencha sua senha.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSenha.Focus();
                    return false;

                }

                bool loginValido = bll.ValidarLogin(usuario, senha);

                if (loginValido)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                    return false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao validar o login: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }





        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidarLogin(txtUsuario.Text, txtSenha.Text))
            {
                FrmMenu menu = new FrmMenu();
                menu.Show();

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';

        }


        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
