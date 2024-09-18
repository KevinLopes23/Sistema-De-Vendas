namespace Cprod.forms
{
    partial class FrmCadastroProdutos
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
            lblCodigoProduto = new Label();
            txtCodigoProduto = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtEstoque = new TextBox();
            label4 = new Label();
            txtPreco = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbMarca = new ComboBox();
            label7 = new Label();
            txtTipoRegistro = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            txtDataVencimento = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            lblCodigoProduto.AutoSize = true;
            lblCodigoProduto.Location = new Point(12, 51);
            lblCodigoProduto.Name = "lblCodigoProduto";
            lblCodigoProduto.Size = new Size(137, 20);
            lblCodigoProduto.TabIndex = 0;
            lblCodigoProduto.Text = "Codigo do Produto";
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.BackColor = Color.White;
            txtCodigoProduto.Enabled = false;
            txtCodigoProduto.ForeColor = Color.White;
            txtCodigoProduto.Location = new Point(12, 74);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.ReadOnly = true;
            txtCodigoProduto.Size = new Size(343, 27);
            txtCodigoProduto.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 129);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 152);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(1109, 27);
            txtDescricao.TabIndex = 2;
            txtDescricao.KeyPress += txtDescricao_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantidade Estoque";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(12, 234);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(270, 27);
            txtEstoque.TabIndex = 3;
            txtEstoque.KeyPress += txtEstoque_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 211);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(398, 234);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(311, 27);
            txtPreco.TabIndex = 4;
            txtPreco.KeyPress += txtPreco_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(841, 211);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 8;
            label5.Text = "Data Vencimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 314);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(12, 337);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(697, 28);
            cmbMarca.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(841, 314);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 12;
            label7.Text = "Tipo do Registro";
            // 
            // txtTipoRegistro
            // 
            txtTipoRegistro.Enabled = false;
            txtTipoRegistro.Location = new Point(841, 337);
            txtTipoRegistro.Name = "txtTipoRegistro";
            txtTipoRegistro.ReadOnly = true;
            txtTipoRegistro.Size = new Size(280, 27);
            txtTipoRegistro.TabIndex = 13;
            txtTipoRegistro.Text = "MANUAL";
            txtTipoRegistro.KeyPress += txtTipoRegistro_KeyPress;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(30, 395);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 29);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(156, 395);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(279, 395);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 16;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click_1;
            // 
            // txtDataVencimento
            // 
            txtDataVencimento.Location = new Point(841, 234);
            txtDataVencimento.Mask = "##/##/####";
            txtDataVencimento.Name = "txtDataVencimento";
            txtDataVencimento.Size = new Size(280, 27);
            txtDataVencimento.TabIndex = 5;
            txtDataVencimento.Leave += txtDataVencimento_Leave_1;
            // 
            // FrmCadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 450);
            Controls.Add(txtDataVencimento);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTipoRegistro);
            Controls.Add(label7);
            Controls.Add(cmbMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPreco);
            Controls.Add(label4);
            Controls.Add(txtEstoque);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtCodigoProduto);
            Controls.Add(lblCodigoProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCadastroProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastroProdutos";
            Load += FrmCadastroProdutos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoProduto;
        private Label lblDescricao;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGravar;
        private Button btnCancelar;
        private Button btnFechar;
        public TextBox txtCodigoProduto;
        public TextBox txtDescricao;
        public TextBox txtEstoque;
        public TextBox txtPreco;
        public ComboBox cmbMarca;
        public TextBox txtTipoRegistro;
        public MaskedTextBox txtDataVencimento;
    }
}