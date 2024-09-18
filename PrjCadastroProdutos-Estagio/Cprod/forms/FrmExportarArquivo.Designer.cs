namespace Cprod.forms
{
    partial class FrmExportarArquivo
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
            lblDiretorioDeSaida = new Label();
            txtPesquisa = new TextBox();
            btnLocalizar = new Button();
            btnExportar = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblDiretorioDeSaida
            // 
            lblDiretorioDeSaida.AutoSize = true;
            lblDiretorioDeSaida.Location = new Point(12, 28);
            lblDiretorioDeSaida.Name = "lblDiretorioDeSaida";
            lblDiretorioDeSaida.Size = new Size(131, 20);
            lblDiretorioDeSaida.TabIndex = 0;
            lblDiretorioDeSaida.Text = "Diretorio de Saida";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 51);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(649, 27);
            txtPesquisa.TabIndex = 1;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(667, 51);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(123, 29);
            btnLocalizar.TabIndex = 2;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(12, 103);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(226, 53);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar Cadastro para Arquivo";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(274, 103);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(226, 53);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(527, 103);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(226, 53);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmExportarArquivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 182);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExportar);
            Controls.Add(btnLocalizar);
            Controls.Add(txtPesquisa);
            Controls.Add(lblDiretorioDeSaida);
            Name = "FrmExportarArquivo";
            Text = "FrmExportarArquivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiretorioDeSaida;
        private TextBox txtPesquisa;
        private Button btnLocalizar;
        private Button btnExportar;
        private Button btnCancelar;
        private Button btnFechar;
    }
}