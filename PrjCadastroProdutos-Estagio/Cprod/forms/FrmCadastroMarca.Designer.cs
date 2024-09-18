namespace Cprod.forms
{
    partial class FrmCadastroMarca
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
            lblCodigo = new Label();
            lblDescricao = new Label();
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 50);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 114);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(12, 73);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(265, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 137);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(755, 27);
            txtDescricao.TabIndex = 3;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            txtDescricao.KeyPress += txtDescricao_KeyPress;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(12, 202);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 29);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(136, 202);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(261, 202);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmCadastroMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 279);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            Controls.Add(lblDescricao);
            Controls.Add(lblCodigo);
            Name = "FrmCadastroMarca";
            Text = "CadastroMarca";
            Load += FrmCadastroMarca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblDescricao;
        private Button btnGravar;
        private Button btnCancelar;
        private Button btnFechar;
        public TextBox txtCodigo;
        public TextBox txtDescricao;
    }
}