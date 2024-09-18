namespace Cprod.forms
{
    partial class FrmEstorno
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
            lblCodVenda = new Label();
            txtCodigoVenda = new TextBox();
            btnOk = new Button();
            dgEstorno = new DataGridView();
            btnEstorno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEstorno).BeginInit();
            SuspendLayout();
            // 
            // lblCodVenda
            // 
            lblCodVenda.AutoSize = true;
            lblCodVenda.Location = new Point(12, 26);
            lblCodVenda.Name = "lblCodVenda";
            lblCodVenda.Size = new Size(124, 20);
            lblCodVenda.TabIndex = 0;
            lblCodVenda.Text = "Codigo da Venda";
            // 
            // txtCodigoVenda
            // 
            txtCodigoVenda.Location = new Point(142, 26);
            txtCodigoVenda.MaxLength = 20;
            txtCodigoVenda.Name = "txtCodigoVenda";
            txtCodigoVenda.Size = new Size(125, 27);
            txtCodigoVenda.TabIndex = 1;
            txtCodigoVenda.KeyPress += txtCodigoVenda_KeyPress;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(283, 26);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dgEstorno
            // 
            dgEstorno.AllowUserToAddRows = false;
            dgEstorno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEstorno.Location = new Point(12, 79);
            dgEstorno.Name = "dgEstorno";
            dgEstorno.RowHeadersWidth = 51;
            dgEstorno.Size = new Size(761, 306);
            dgEstorno.TabIndex = 3;
            // 
            // btnEstorno
            // 
            btnEstorno.Location = new Point(12, 400);
            btnEstorno.Name = "btnEstorno";
            btnEstorno.Size = new Size(94, 29);
            btnEstorno.TabIndex = 4;
            btnEstorno.Text = "Estorno";
            btnEstorno.UseVisualStyleBackColor = true;
            btnEstorno.Click += btnEstorno_Click;
            // 
            // FrmEstorno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEstorno);
            Controls.Add(dgEstorno);
            Controls.Add(btnOk);
            Controls.Add(txtCodigoVenda);
            Controls.Add(lblCodVenda);
            Name = "FrmEstorno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstorno";
            Load += FrmEstorno_Load;
            ((System.ComponentModel.ISupportInitialize)dgEstorno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodVenda;
        private TextBox txtCodigoVenda;
        private Button btnOk;
        private DataGridView dgEstorno;
        private Button btnEstorno;
    }
}