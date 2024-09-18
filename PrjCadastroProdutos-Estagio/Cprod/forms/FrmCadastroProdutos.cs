using Cprod.code.Apoio;
using Cprod.code.bll;
using Cprod.code.dal;
using Cprod.code.dto.dto;
using System.Data;

namespace Cprod.forms
{
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
            //FrmPesquisaProdutos frmPesquisa = new FrmPesquisaProdutos();
            PreencheComboBoxCodigosProduto();
        }

        public void LimitaCaracteres()
        {

            try
            {
                txtCodigoProduto.MaxLength = 30;
                txtDescricao.MaxLength = 30;
                txtEstoque.MaxLength = 10;
                txtPreco.MaxLength = 10;
                txtDataVencimento.MaxLength = 10;
                txtTipoRegistro.MaxLength = 10;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro a limitar caracteres: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        public bool ValidaDescricaoAtualizar()
        {
            CprodBll bll = new CprodBll();


            if (string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                if (bll.ValidaDescricao(txtDescricao.Text))
                {
                    MessageBox.Show("Descrição  já cadastrada no sistema", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Text = string.Empty;
                    txtDescricao.Focus();
                    return false;
                }
            }

            return true;

        }




        public bool ValidaDescricao()
        {
            CprodBll bll = new CprodBll();


            if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                if (bll.ValidaDescricao(txtDescricao.Text))
                {
                    MessageBox.Show("Descrição  já cadastrada no sistema", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Text = string.Empty;
                    txtDescricao.Focus();
                    return true;
                }
            }

            return false;
        }




        private void AceitaLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro a limitar apenas letras: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AceitaNumerosInteiros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro a limitar apenas Numeros: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void GeraId()
        {
            try
            {
                CProdDal dal = new CProdDal();
                int novoCodigo = dal.GeraCodigoProduto();
                txtCodigoProduto.Text = novoCodigo.ToString();
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
                if (!VerificaCamposPreenchidos())
                {
                    return;
                }


                if (ValidaDescricao())
                {
                    return;
                }


                GeraId();


                ProdutosDto dto = new ProdutosDto();
                dto.CodigoProduto = int.Parse(txtCodigoProduto.Text);
                dto.Descricao = txtDescricao.Text;
                dto.QuantidadeEstoque = int.Parse(txtEstoque.Text);
                dto.Preco = float.Parse(txtPreco.Text);
                dto.DataVencimento = DateTime.Parse(txtDataVencimento.Text);
                dto.CodigoMarca = int.Parse(cmbMarca.SelectedValue.ToString());
                dto.TipoRegistro = txtTipoRegistro.Text.Substring(0, 1);

                CprodBll bll = new CprodBll();

                Boolean retorno = bll.Gravar(dto);
                //FrmPesquisaProdutos produtos = new FrmPesquisaProdutos();
                //produtos.ShowDialog();

                if (retorno == true)
                {
                    MessageBox.Show(
                    "Gravado com Sucesso, muito obrigado", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    //txtCodigoProduto.Text = string.Empty;
                    //produtos.RecarregarGrid();
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




        private void AtualizarProduto()
        {
            try
            {

                if (!VerificaCamposPreenchidos())
                {
                    return;
                }


                ValidaDescricaoAtualizar();



                ProdutosDto dto = new ProdutosDto
                {
                    CodigoProduto = int.Parse(txtCodigoProduto.Text),
                    Descricao = txtDescricao.Text,
                    QuantidadeEstoque = int.Parse(txtEstoque.Text),
                    Preco = float.Parse(txtPreco.Text),
                    DataVencimento = DateTime.Parse(txtDataVencimento.Text),
                    CodigoMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString()),
                    TipoRegistro = txtTipoRegistro.Text.Substring(0, 1),
                };

                CprodBll bll = new CprodBll();
                bool atualizado = bll.Atualizar(dto);
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














        public Boolean VerificaCamposPreenchidos()
        {

            try
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

                if (string.IsNullOrEmpty(txtEstoque.Text) || Convert.ToDouble(txtEstoque.Text) <= 0)
                {
                    MessageBox.Show(
                       "Insira uma quantidade de estoque valido",
                       Constantes.NOME_APLICACAO,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation
                       );
                    txtEstoque.Focus();
                    return false;
                }



                if (string.IsNullOrEmpty(txtPreco.Text) || Convert.ToDouble(txtPreco.Text) <= 0)
                {
                    MessageBox.Show(
                       "Insira um valor de preço valido",
                       Constantes.NOME_APLICACAO,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation
                       );
                    txtPreco.Focus();
                    return false;
                }


                DateTime dataVencimento;
                if (!string.IsNullOrEmpty(txtCodigoProduto.Text))
                {
                    return true;
                }
                else
                {
                    if (!DateTime.TryParse(txtDataVencimento.Text, out dataVencimento) || dataVencimento < DateTime.Today || dataVencimento == null)
                    {
                        MessageBox.Show(
                            "Insira uma data válida.",
                            Constantes.NOME_APLICACAO,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );
                        txtDataVencimento.Text = string.Empty;
                        txtDataVencimento.Focus();
                        return false;
                    }
                }

                if (string.IsNullOrEmpty(cmbMarca.Text))
                {
                    MessageBox.Show(
                       "Selecione uma marca valida",
                       Constantes.NOME_APLICACAO,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation
                       );
                    cmbMarca.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtTipoRegistro.Text))
                {
                    MessageBox.Show(
                       "Insira um tipo de registro valido",
                       Constantes.NOME_APLICACAO,
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation
                       );
                    txtTipoRegistro.Focus();
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







        public void LimpaCampos()
        {

            try
            {
                txtCodigoProduto.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtEstoque.Text = string.Empty;
                txtPreco.Text = string.Empty;
                txtDataVencimento.Text = string.Empty;
                cmbMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao limpar campos: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // txtTipoRegistro.Text = string.Empty;

        }





        public void PreencheComboBoxCodigosProduto()
        {

            try
            {
                CProdDal dal = new CProdDal();
                DataTable dtCodigos = dal.ColocaMarcaCombo();

                cmbMarca.DataSource = dtCodigos;
                cmbMarca.DisplayMember = "MARCA";
                cmbMarca.ValueMember = "CODMARCA";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao preencher o ComboBox: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void FrmCadastroProdutos_Load(object sender, EventArgs e)
        {
            LimitaCaracteres();
            //cmbMarca.SelectedValue = 328928424;
            //cmbMarca.SelectedIndex = -1;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            BotaoGravar();
        }


        private void txtDataVencimento_Leave_1(object sender, EventArgs e)
        {
            Util.ValidaData(txtDataVencimento);
        }

        private void txtTipoRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceitaLetras(e);
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceitaNumerosInteiros(e);

        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmMenu menu = new FrmMenu();
            //menu.Show();

            //FrmPesquisaProdutos produtos = new FrmPesquisaProdutos();
            //produtos.RecarregarGrid();

            Close();
        }




        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoProduto.Text))
            {
                BotaoGravar();
            }
            else
            {
                AtualizarProduto();
            }




        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpaCampos();

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }
    }
}
