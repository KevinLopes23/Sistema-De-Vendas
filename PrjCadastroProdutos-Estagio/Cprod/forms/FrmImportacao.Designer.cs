namespace Cprod.forms
{
    partial class FrmImportacao
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
            components = new System.ComponentModel.Container();
            lblArquivo = new Label();
            txtCaminho = new TextBox();
            btnLocalizar = new Button();
            dgImportacao = new DataGridView();
            CODIGOPRODUTO = new DataGridViewTextBoxColumn();
            DESCRICAO = new DataGridViewTextBoxColumn();
            MENSAGENS = new DataGridViewTextBoxColumn();
            btnImportar = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            lblLinhasDoArquivo = new Label();
            lblLinhasImportadas = new Label();
            lblLinhasExistentes = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar2 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgImportacao).BeginInit();
            SuspendLayout();
            // 
            // lblArquivo
            // 
            lblArquivo.AutoSize = true;
            lblArquivo.Location = new Point(12, 9);
            lblArquivo.Name = "lblArquivo";
            lblArquivo.Size = new Size(95, 20);
            lblArquivo.TabIndex = 0;
            lblArquivo.Text = "Arquivo (.txt)";
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new Point(12, 32);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new Size(598, 27);
            txtCaminho.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(631, 32);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(134, 29);
            btnLocalizar.TabIndex = 2;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // dgImportacao
            // 
            dgImportacao.AllowUserToAddRows = false;
            dgImportacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgImportacao.Columns.AddRange(new DataGridViewColumn[] { CODIGOPRODUTO, DESCRICAO, MENSAGENS });
            dgImportacao.Location = new Point(12, 67);
            dgImportacao.Name = "dgImportacao";
            dgImportacao.RowHeadersWidth = 51;
            dgImportacao.Size = new Size(753, 239);
            dgImportacao.TabIndex = 3;
            // 
            // CODIGOPRODUTO
            // 
            CODIGOPRODUTO.DataPropertyName = "CODPRODUTO";
            CODIGOPRODUTO.HeaderText = "CODIGOPRODUTO";
            CODIGOPRODUTO.MinimumWidth = 6;
            CODIGOPRODUTO.Name = "CODIGOPRODUTO";
            CODIGOPRODUTO.Width = 150;
            // 
            // DESCRICAO
            // 
            DESCRICAO.DataPropertyName = "DESCRICAO";
            DESCRICAO.HeaderText = "DESCRICAO";
            DESCRICAO.MinimumWidth = 6;
            DESCRICAO.Name = "DESCRICAO";
            DESCRICAO.Width = 125;
            // 
            // MENSAGENS
            // 
            MENSAGENS.HeaderText = "MENSAGENS";
            MENSAGENS.MinimumWidth = 6;
            MENSAGENS.Name = "MENSAGENS";
            MENSAGENS.Width = 125;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(12, 312);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(238, 58);
            btnImportar.TabIndex = 4;
            btnImportar.Text = "Importar para Cadastro";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(256, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(238, 58);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(527, 312);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(238, 58);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblLinhasDoArquivo
            // 
            lblLinhasDoArquivo.AutoSize = true;
            lblLinhasDoArquivo.Location = new Point(485, 163);
            lblLinhasDoArquivo.Name = "lblLinhasDoArquivo";
            lblLinhasDoArquivo.Size = new Size(0, 20);
            lblLinhasDoArquivo.TabIndex = 7;
            lblLinhasDoArquivo.Click += lblLinhasDoArquivo_Click;
            // 
            // lblLinhasImportadas
            // 
            lblLinhasImportadas.AutoSize = true;
            lblLinhasImportadas.Location = new Point(485, 194);
            lblLinhasImportadas.Name = "lblLinhasImportadas";
            lblLinhasImportadas.Size = new Size(0, 20);
            lblLinhasImportadas.TabIndex = 8;
            // 
            // lblLinhasExistentes
            // 
            lblLinhasExistentes.AutoSize = true;
            lblLinhasExistentes.Location = new Point(485, 226);
            lblLinhasExistentes.Name = "lblLinhasExistentes";
            lblLinhasExistentes.Size = new Size(0, 20);
            lblLinhasExistentes.TabIndex = 9;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 400);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(753, 29);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(631, 3);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(134, 26);
            progressBar2.TabIndex = 11;
            // 
            // FrmImportacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(lblLinhasExistentes);
            Controls.Add(lblLinhasImportadas);
            Controls.Add(lblLinhasDoArquivo);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnImportar);
            Controls.Add(dgImportacao);
            Controls.Add(btnLocalizar);
            Controls.Add(txtCaminho);
            Controls.Add(lblArquivo);
            Name = "FrmImportacao";
            Text = "FrmImportacao";
            ((System.ComponentModel.ISupportInitialize)dgImportacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArquivo;
        private TextBox txtCaminho;
        private Button btnLocalizar;
        private DataGridView dgImportacao;
        private Button btnImportar;
        private Button btnCancelar;
        private Button btnFechar;
        private DataGridViewTextBoxColumn CODIGOPRODUTO;
        private DataGridViewTextBoxColumn DESCRICAO;
        private DataGridViewTextBoxColumn MENSAGENS;
        private Label lblLinhasDoArquivo;
        private Label lblLinhasImportadas;
        private Label lblLinhasExistentes;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar2;
    }
}