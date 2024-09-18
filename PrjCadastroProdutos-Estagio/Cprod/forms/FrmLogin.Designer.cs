namespace Cprod
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDescricao = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            pctImagemConfianca = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctImagemConfianca).BeginInit();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(29, 89);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(427, 50);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Cprod - Controle de Acesso";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 143);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(29, 237);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.Location = new Point(29, 166);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(517, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.KeyPress += txtUsuario_KeyPress_1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(29, 260);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(517, 27);
            txtSenha.TabIndex = 4;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(436, 324);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(110, 54);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pctImagemConfianca
            // 
            pctImagemConfianca.BackColor = Color.FromArgb(0, 192, 0);
            pctImagemConfianca.Image = Properties.Resources.Confianca;
            pctImagemConfianca.Location = new Point(29, 12);
            pctImagemConfianca.Name = "pctImagemConfianca";
            pctImagemConfianca.Size = new Size(373, 74);
            pctImagemConfianca.SizeMode = PictureBoxSizeMode.StretchImage;
            pctImagemConfianca.TabIndex = 6;
            pctImagemConfianca.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(581, 399);
            Controls.Add(pctImagemConfianca);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblDescricao);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pctImagemConfianca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescricao;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private PictureBox pctImagemConfianca;
    }
}
