namespace Cprod
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            pctImagem = new PictureBox();
            menuStrip1 = new MenuStrip();
            mtMenu = new ToolStripMenuItem();
            pRODUTOSToolStripMenuItem = new ToolStripMenuItem();
            mARCAToolStripMenuItem = new ToolStripMenuItem();
            iMPORTARToolStripMenuItem = new ToolStripMenuItem();
            eXPORTARToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pctImagem).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pctImagem
            // 
            pctImagem.BackColor = Color.Transparent;
            pctImagem.BackgroundImageLayout = ImageLayout.None;
            pctImagem.Image = (Image)resources.GetObject("pctImagem.Image");
            pctImagem.Location = new Point(0, 39);
            pctImagem.Name = "pctImagem";
            pctImagem.Size = new Size(1600, 900);
            pctImagem.SizeMode = PictureBoxSizeMode.AutoSize;
            pctImagem.TabIndex = 0;
            pctImagem.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mtMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(812, 36);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mtMenu
            // 
            mtMenu.DropDownItems.AddRange(new ToolStripItem[] { pRODUTOSToolStripMenuItem, mARCAToolStripMenuItem, iMPORTARToolStripMenuItem, eXPORTARToolStripMenuItem });
            mtMenu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtMenu.Name = "mtMenu";
            mtMenu.Size = new Size(86, 32);
            mtMenu.Text = "MENU";
            // 
            // pRODUTOSToolStripMenuItem
            // 
            pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            pRODUTOSToolStripMenuItem.Size = new Size(224, 32);
            pRODUTOSToolStripMenuItem.Text = "PRODUTOS";
            pRODUTOSToolStripMenuItem.Click += pRODUTOSToolStripMenuItem_Click;
            // 
            // mARCAToolStripMenuItem
            // 
            mARCAToolStripMenuItem.Name = "mARCAToolStripMenuItem";
            mARCAToolStripMenuItem.Size = new Size(224, 32);
            mARCAToolStripMenuItem.Text = "MARCA";
            mARCAToolStripMenuItem.Click += mARCAToolStripMenuItem_Click;
            // 
            // iMPORTARToolStripMenuItem
            // 
            iMPORTARToolStripMenuItem.Name = "iMPORTARToolStripMenuItem";
            iMPORTARToolStripMenuItem.Size = new Size(224, 32);
            iMPORTARToolStripMenuItem.Text = "IMPORTAR";
            iMPORTARToolStripMenuItem.Click += iMPORTARToolStripMenuItem_Click;
            // 
            // eXPORTARToolStripMenuItem
            // 
            eXPORTARToolStripMenuItem.Name = "eXPORTARToolStripMenuItem";
            eXPORTARToolStripMenuItem.Size = new Size(224, 32);
            eXPORTARToolStripMenuItem.Text = "EXPORTAR";
            eXPORTARToolStripMenuItem.Click += eXPORTARToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(812, 511);
            Controls.Add(pctImagem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pctImagem).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private PictureBox pctImagem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mtMenu;
        private ToolStripMenuItem pRODUTOSToolStripMenuItem;
        private ToolStripMenuItem mARCAToolStripMenuItem;
        private ToolStripMenuItem iMPORTARToolStripMenuItem;
        private ToolStripMenuItem eXPORTARToolStripMenuItem;
    }
}