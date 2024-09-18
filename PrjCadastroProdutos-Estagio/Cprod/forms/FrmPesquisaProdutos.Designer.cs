namespace Cprod
{
    partial class FrmPesquisaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisaProdutos));
            cmbFiltro = new ComboBox();
            txtPesquisa = new TextBox();
            btnOk = new Button();
            dgProdutos = new DataGridView();
            CODPRODUTO = new DataGridViewTextBoxColumn();
            DESCRICAO = new DataGridViewTextBoxColumn();
            QTDESTOQUE = new DataGridViewTextBoxColumn();
            PRECO = new DataGridViewTextBoxColumn();
            DATAVENCIMENTO = new DataGridViewTextBoxColumn();
            MARCA = new DataGridViewTextBoxColumn();
            TIPOREGISTRO = new DataGridViewTextBoxColumn();
            btnNovo = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnVoltar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltro
            // 
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { "CODPRODUTO", "DESCRICAO" });
            cmbFiltro.Location = new Point(6, 55);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(160, 28);
            cmbFiltro.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(172, 56);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(486, 27);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            txtPesquisa.KeyPress += txtPesquisa_KeyPress;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(664, 56);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dgProdutos
            // 
            dgProdutos.AllowUserToAddRows = false;
            dgProdutos.BackgroundColor = Color.White;
            dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProdutos.Columns.AddRange(new DataGridViewColumn[] { CODPRODUTO, DESCRICAO, QTDESTOQUE, PRECO, DATAVENCIMENTO, MARCA, TIPOREGISTRO });
            dgProdutos.Location = new Point(8, 87);
            dgProdutos.Name = "dgProdutos";
            dgProdutos.RowHeadersWidth = 51;
            dgProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProdutos.Size = new Size(1428, 538);
            dgProdutos.TabIndex = 3;
            // 
            // CODPRODUTO
            // 
            CODPRODUTO.DataPropertyName = "CODPRODUTO";
            CODPRODUTO.HeaderText = "Cod Produto";
            CODPRODUTO.MinimumWidth = 6;
            CODPRODUTO.Name = "CODPRODUTO";
            CODPRODUTO.Width = 125;
            // 
            // DESCRICAO
            // 
            DESCRICAO.DataPropertyName = "DESCRICAO";
            DESCRICAO.HeaderText = "Descrição";
            DESCRICAO.MinimumWidth = 6;
            DESCRICAO.Name = "DESCRICAO";
            DESCRICAO.Width = 300;
            // 
            // QTDESTOQUE
            // 
            QTDESTOQUE.DataPropertyName = "QTDESTOQUE";
            QTDESTOQUE.HeaderText = "Estoque";
            QTDESTOQUE.MinimumWidth = 6;
            QTDESTOQUE.Name = "QTDESTOQUE";
            QTDESTOQUE.Width = 125;
            // 
            // PRECO
            // 
            PRECO.DataPropertyName = "PRECO";
            PRECO.HeaderText = "Preço";
            PRECO.MinimumWidth = 6;
            PRECO.Name = "PRECO";
            PRECO.Width = 125;
            // 
            // DATAVENCIMENTO
            // 
            DATAVENCIMENTO.DataPropertyName = "DATAVENCIMENTO";
            DATAVENCIMENTO.HeaderText = "Data Vencto";
            DATAVENCIMENTO.MinimumWidth = 6;
            DATAVENCIMENTO.Name = "DATAVENCIMENTO";
            DATAVENCIMENTO.Width = 125;
            // 
            // MARCA
            // 
            MARCA.DataPropertyName = "Marca";
            MARCA.HeaderText = "Marca";
            MARCA.MinimumWidth = 6;
            MARCA.Name = "MARCA";
            MARCA.Width = 200;
            // 
            // TIPOREGISTRO
            // 
            TIPOREGISTRO.DataPropertyName = "TIPOREGISTRO";
            TIPOREGISTRO.HeaderText = "Tipo Registro";
            TIPOREGISTRO.MinimumWidth = 6;
            TIPOREGISTRO.Name = "TIPOREGISTRO";
            TIPOREGISTRO.Width = 125;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(19, 630);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 35);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(133, 630);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 35);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(253, 630);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 35);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1215, 630);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(1332, 630);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 35);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1353, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmPesquisaProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1449, 674);
            Controls.Add(pictureBox1);
            Controls.Add(btnVoltar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(dgProdutos);
            Controls.Add(btnOk);
            Controls.Add(txtPesquisa);
            Controls.Add(cmbFiltro);
            Name = "FrmPesquisaProdutos";
            Text = "PesquisaProdutos";
            Load += FrmPesquisaProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFiltro;
        private TextBox txtPesquisa;
        private Button btnOk;
        private DataGridView dgProdutos;
        private Button btnCancelar;
        private Button btnVoltar;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CODPRODUTO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn QTDESTOQUE;
        private DataGridViewTextBoxColumn PRECO;
        private DataGridViewTextBoxColumn DATAVENCIMENTO;
        private DataGridViewTextBoxColumn MARCA;
        private DataGridViewTextBoxColumn TIPOREGISTRO;
        public Button btnNovo;
        public Button btnAlterar;
        public Button btnExcluir;
    }
}