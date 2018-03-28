namespace GrcEvo.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MenuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSep01 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuParametres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClientNew = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClientNew});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1071, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 564);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1071, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // MenuFichier
            // 
            this.MenuFichier.Name = "MenuFichier";
            this.MenuFichier.Size = new System.Drawing.Size(54, 20);
            this.MenuFichier.Text = "Fichier";
            // 
            // MenuQuitter
            // 
            this.MenuQuitter.Name = "MenuQuitter";
            this.MenuQuitter.Size = new System.Drawing.Size(180, 22);
            this.MenuQuitter.Text = "Quitter";
            // 
            // MenuSep01
            // 
            this.MenuSep01.Name = "MenuSep01";
            this.MenuSep01.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuParametres
            // 
            this.MenuParametres.Name = "MenuParametres";
            this.MenuParametres.Size = new System.Drawing.Size(180, 22);
            this.MenuParametres.Text = "Paramètres";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // BtnClientNew
            // 
            this.BtnClientNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientNew.Image")));
            this.BtnClientNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClientNew.Name = "BtnClientNew";
            this.BtnClientNew.Size = new System.Drawing.Size(83, 22);
            this.BtnClientNew.Text = "New client";
            this.BtnClientNew.Click += new System.EventHandler(this.BtnClientNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 586);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRC Evo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuFichier;
        private System.Windows.Forms.ToolStripMenuItem MenuParametres;
        private System.Windows.Forms.ToolStripSeparator MenuSep01;
        private System.Windows.Forms.ToolStripMenuItem MenuQuitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton BtnClientNew;
    }
}