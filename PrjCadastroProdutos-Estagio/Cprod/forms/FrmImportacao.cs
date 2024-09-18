using Cprod.code.Apoio;
using Cprod.code.bll;
using Cprod.code.dto.dto;

namespace Cprod.forms
{
    public partial class FrmImportacao : Form
    {
        public FrmImportacao()
        {
            InitializeComponent();
        }


        private void LocalizaEJogaProGrid()
        {
            try
            {
                CprodBll bll = new CprodBll();
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Arquivo de Texto (*.txt)|*.txt"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminho.Text = ofd.FileName;
                    string[] linhas = File.ReadAllLines(ofd.FileName);

                    dgImportacao.Rows.Clear();

                    progressBar2.Maximum = linhas.Length;
                    progressBar2.Value = 0;

                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split('|');

                        if (dados.Length < 2)
                        {
                            dgImportacao.Rows.Add(dados.ElementAtOrDefault(0) ?? "", "", "FALHA");
                            progressBar2.Value += 1;
                            continue;
                        }

                        int codmarca;
                        if (!int.TryParse(dados[0], out codmarca))
                        {

                            dgImportacao.Rows.Add(dados.ElementAtOrDefault(0) ?? "", dados[1], "FALHA");
                            progressBar2.Value += 1;
                            continue;
                        }

                        bool existe = bll.VerificaSeExiste(codmarca);

                        if (existe)
                        {
                            dgImportacao.Rows.Add(dados.ElementAtOrDefault(0) ?? "", dados[1], "DUPLICIDADE");
                            progressBar2.Value += 1;
                            continue;
                        }


                        bool isCodigoInt = int.TryParse(dados[0], out _);

                        string mensagem = isCodigoInt ? "OK" : "FALHA";

                        dgImportacao.Rows.Add(dados[0], dados[1], mensagem);

                        progressBar2.Value += 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao jogar os dados pro grid: {ex.Message}", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public async void Importar()
        {
            try
            {
                List<ProdutosDto> listaProdutos = new List<ProdutosDto>();
                ProdutosDto dto = new ProdutosDto();
                CprodBll bll = new CprodBll();
                int linhasImportadas = 0;
                int linhasJaExistentes = 0;
                int totalLinhas = dgImportacao.RowCount;

                DialogResult dialogResult = MessageBox.Show("Deseja importar o item?", "Confirmação", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = totalLinhas;
                    progressBar1.Value = 0;


                    await Task.Run(() =>
                    {
                        foreach (DataGridViewRow row in dgImportacao.Rows)
                        {
                            string condicao = row.Cells["MENSAGENS"].Value?.ToString();

                            if (condicao == "OK")
                            {
                                int codmarca;
                                if (!int.TryParse(row.Cells["CODIGOPRODUTO"].Value?.ToString(), out codmarca))
                                {
                                    // Se a conversão falhar, registra a linha com "FALHA"
                                    this.Invoke(new Action(() => dgImportacao.Rows.Add(row.Cells["CODIGOPRODUTO"].Value?.ToString(), row.Cells["DESCRICAO"].Value?.ToString(), "FALHA")));
                                    continue;
                                }

                                bool existe = bll.VerificaSeExiste(codmarca);

                                if (!existe)
                                {
                                    dto = new ProdutosDto();
                                    dto.CodigoProduto = Convert.ToInt32(row.Cells["CODIGOPRODUTO"].Value);
                                    dto.Descricao = row.Cells["DESCRICAO"].Value.ToString();
                                    listaProdutos.Add(dto);
                                    linhasImportadas++;
                                    //bll.Importar(codmarca, row.Cells["DESCRICAO"].Value?.ToString());

                                }
                            }

                            if (condicao == "DUPLICIDADE")
                            {
                                linhasJaExistentes++;
                            }


                            this.Invoke(new Action(() =>
                            {
                                progressBar1.Value += 1;
                            }));
                        }

                    });

                    if (listaProdutos.Any())
                    {
                        bll.Importar(listaProdutos);
                    }

                    // Atualiza os labels no formulário com as informações calculadas
                    lblLinhasDoArquivo.Text = $"Qtde de linhas do arquivo: {totalLinhas}";
                    lblLinhasImportadas.Text = $"Qtde de linhas importadas: {linhasImportadas}";
                    lblLinhasExistentes.Text = $"Qtde de produtos já existentes: {linhasJaExistentes}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao importar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }























        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocalizaEJogaProGrid();

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Importar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCaminho.Text = string.Empty;
            dgImportacao.Rows.Clear();
            dgImportacao.DataSource = null;
            dgImportacao.Refresh();
            lblLinhasExistentes.Text = string.Empty;
            lblLinhasDoArquivo.Text = string.Empty;
            lblLinhasImportadas.Text = string.Empty;



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblLinhasDoArquivo_Click(object sender, EventArgs e)
        {

        }


    }
}
