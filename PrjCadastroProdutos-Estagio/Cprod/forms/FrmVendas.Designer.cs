namespace Cprod.forms
{
    partial class FrmVendas
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
            lblProduto = new Label();
            cmbProdutos = new ComboBox();
            lblQuantidade = new Label();
            txtQuantidade = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            btnAdicionar = new Button();
            dgProdutos = new DataGridView();
            CODIGOPRODUTO = new DataGridViewTextBoxColumn();
            DESCRICAO = new DataGridViewTextBoxColumn();
            QUANTIDADE = new DataGridViewTextBoxColumn();
            PRECO = new DataGridViewTextBoxColumn();
            btnGravar = new Button();
            lblEstoqueDisponivel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(12, 56);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(62, 20);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto";
            // 
            // cmbProdutos
            // 
            cmbProdutos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdutos.FormattingEnabled = true;
            cmbProdutos.Location = new Point(12, 79);
            cmbProdutos.Name = "cmbProdutos";
            cmbProdutos.Size = new Size(335, 28);
            cmbProdutos.TabIndex = 1;
            cmbProdutos.SelectionChangeCommitted += cmbProdutos_SelectionChangeCommitted;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(376, 56);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(87, 20);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(376, 79);
            txtQuantidade.MaxLength = 10;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(125, 27);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(540, 56);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Enabled = false;
            txtPreco.Location = new Point(540, 79);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(694, 77);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgProdutos
            // 
            dgProdutos.AllowUserToAddRows = false;
            dgProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProdutos.Columns.AddRange(new DataGridViewColumn[] { CODIGOPRODUTO, DESCRICAO, QUANTIDADE, PRECO });
            dgProdutos.Location = new Point(12, 144);
            dgProdutos.Name = "dgProdutos";
            dgProdutos.ReadOnly = true;
            dgProdutos.RowHeadersWidth = 51;
            dgProdutos.Size = new Size(776, 236);
            dgProdutos.TabIndex = 7;
            // 
            // CODIGOPRODUTO
            // 
            CODIGOPRODUTO.HeaderText = "CODIGOPRODUTO";
            CODIGOPRODUTO.MinimumWidth = 6;
            CODIGOPRODUTO.Name = "CODIGOPRODUTO";
            CODIGOPRODUTO.ReadOnly = true;
            CODIGOPRODUTO.Width = 150;
            // 
            // DESCRICAO
            // 
            DESCRICAO.HeaderText = "DESCRICAO";
            DESCRICAO.MinimumWidth = 6;
            DESCRICAO.Name = "DESCRICAO";
            DESCRICAO.ReadOnly = true;
            DESCRICAO.Width = 220;
            // 
            // QUANTIDADE
            // 
            QUANTIDADE.HeaderText = "QUANTIDADE";
            QUANTIDADE.MinimumWidth = 6;
            QUANTIDADE.Name = "QUANTIDADE";
            QUANTIDADE.ReadOnly = true;
            QUANTIDADE.Width = 165;
            // 
            // PRECO
            // 
            PRECO.HeaderText = "PRECO";
            PRECO.MinimumWidth = 6;
            PRECO.Name = "PRECO";
            PRECO.ReadOnly = true;
            PRECO.Width = 187;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(12, 397);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 41);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblEstoqueDisponivel
            // 
            lblEstoqueDisponivel.AutoSize = true;
            lblEstoqueDisponivel.Location = new Point(376, 9);
            lblEstoqueDisponivel.Name = "lblEstoqueDisponivel";
            lblEstoqueDisponivel.Size = new Size(0, 20);
            lblEstoqueDisponivel.TabIndex = 9;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstoqueDisponivel);
            Controls.Add(btnGravar);
            Controls.Add(dgProdutos);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(cmbProdutos);
            Controls.Add(lblProduto);
            Name = "FrmVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmVendas";
            Load += FrmVendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private ComboBox cmbProdutos;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private Label lblPreco;
        private TextBox txtPreco;
        private Button btnAdicionar;
        private DataGridView dgProdutos;
        private Button btnGravar;
        private DataGridViewTextBoxColumn CODIGOPRODUTO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn QUANTIDADE;
        private DataGridViewTextBoxColumn PRECO;
        private Label lblEstoqueDisponivel;
    }
}