namespace Cprod.forms
{
    partial class FrmPesquisaDeMarcas
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
            txtPesquisaMarca = new TextBox();
            btnOk = new Button();
            dgMarca = new DataGridView();
            CODIGO = new DataGridViewTextBoxColumn();
            DESCRICAO = new DataGridViewTextBoxColumn();
            btnNovo = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgMarca).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisaMarca
            // 
            txtPesquisaMarca.Location = new Point(12, 29);
            txtPesquisaMarca.Name = "txtPesquisaMarca";
            txtPesquisaMarca.Size = new Size(740, 27);
            txtPesquisaMarca.TabIndex = 0;
            txtPesquisaMarca.KeyPress += txtPesquisaMarca_KeyPress;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(772, 29);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dgMarca
            // 
            dgMarca.AllowUserToAddRows = false;
            dgMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMarca.Columns.AddRange(new DataGridViewColumn[] { CODIGO, DESCRICAO });
            dgMarca.Location = new Point(12, 77);
            dgMarca.Name = "dgMarca";
            dgMarca.RowHeadersWidth = 51;
            dgMarca.Size = new Size(854, 394);
            dgMarca.TabIndex = 2;
            // 
            // CODIGO
            // 
            CODIGO.DataPropertyName = "CODMARCA";
            CODIGO.HeaderText = "CODIGO";
            CODIGO.MinimumWidth = 6;
            CODIGO.Name = "CODIGO";
            CODIGO.Width = 300;
            // 
            // DESCRICAO
            // 
            DESCRICAO.DataPropertyName = "MARCA";
            DESCRICAO.HeaderText = "DESCRICAO";
            DESCRICAO.MinimumWidth = 6;
            DESCRICAO.Name = "DESCRICAO";
            DESCRICAO.Width = 500;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 491);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(125, 491);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(238, 491);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(360, 491);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(483, 491);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmPesquisaDeMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 544);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(dgMarca);
            Controls.Add(btnOk);
            Controls.Add(txtPesquisaMarca);
            Name = "FrmPesquisaDeMarcas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesquisaDeMarcas";
            Load += FrmPesquisaDeMarcas_Load;
            ((System.ComponentModel.ISupportInitialize)dgMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisaMarca;
        private Button btnOk;
        private DataGridView dgMarca;
        private Button btnNovo;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnFechar;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn DESCRICAO;
    }
}