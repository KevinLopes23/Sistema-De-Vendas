using Cprod.code.dal;
using Cprod.code.dto.dto;

namespace Cprod.forms
{
    public partial class FrmExportarArquivo : Form
    {
        public FrmExportarArquivo()
        {
            InitializeComponent();
        }


        private void Localizar()
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPesquisa.Text = fbd.SelectedPath;
                }
            }
        }

        private void Exportar()
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                MessageBox.Show("Por favor, selecione um diretório para salvar o arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string caminhoArquivo = Path.Combine(txtPesquisa.Text, "Produtos.txt");

                CProdDal dal = new CProdDal();
                List<ProdutosDto> produtos = dal.ExportarDados();

                using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                {

                    sw.WriteLine("CodProduto|Descrição|Qtd Estoque|Preço|Data Vencimento|CodMarca|TipoRegistro");



                    foreach (ProdutosDto produto in produtos)
                    {
                        string linha = $"{(produto.CodigoProduto != 0 ? produto.CodigoProduto.ToString() : "")}|" +
                           $"{(!string.IsNullOrEmpty(produto.Descricao) ? produto.Descricao : "")}|" +
                           $"{(produto.QuantidadeEstoque != 0 ? produto.QuantidadeEstoque.ToString() : "")}|" +
                           $"{(produto.Preco != 0.0 ? produto.Preco.ToString("F2") : "")}|" +
                          $"{(produto.DataVencimento != DateTime.MinValue ? produto.DataVencimento.ToString("dd/MM/yyyy") : "")}|" +
                           $"{(produto.CodigoMarca != 0 ? produto.CodigoMarca.ToString() : "")}|" +
                           $"{(!string.IsNullOrEmpty(produto.TipoRegistro) ? produto.TipoRegistro : "")}";



                        sw.WriteLine(linha);
                    }
                }

                MessageBox.Show("Dados exportados com sucesso!", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Localizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = string.Empty;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
