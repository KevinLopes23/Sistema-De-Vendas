using Cprod.forms;

namespace Cprod
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void iMPORTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportacao importacao = new FrmImportacao();
            importacao.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaProdutos PesquisaProdutos = new FrmPesquisaProdutos();

            PesquisaProdutos.Show();
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPesquisaDeMarcas PesquisaMarca = new FrmPesquisaDeMarcas();

            PesquisaMarca.Show();
        }

        private void eXPORTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportarArquivo exportar = new();
            exportar.Show();
        }
    }
}
