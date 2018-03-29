namespace GrcEvo.Forms
{
    partial class ClientEditForm
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
            this.components = new System.ComponentModel.Container();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.CbxPays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TabClient = new System.Windows.Forms.TabControl();
            this.TabAdresse = new System.Windows.Forms.TabPage();
            this.TabLivraison = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChkProspect = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.TabClient.SuspendLayout();
            this.TabAdresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNom
            // 
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Location = new System.Drawing.Point(230, 91);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(788, 26);
            this.TxtNom.TabIndex = 0;
            this.TxtNom.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNom_Validating);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(72, 95);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(50, 20);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "Nom :";
            // 
            // CbxPays
            // 
            this.CbxPays.FormattingEnabled = true;
            this.CbxPays.Location = new System.Drawing.Point(220, 109);
            this.CbxPays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(270, 28);
            this.CbxPays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pays :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(908, 586);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(112, 35);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(786, 586);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 35);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // TabClient
            // 
            this.TabClient.Controls.Add(this.TabAdresse);
            this.TabClient.Controls.Add(this.TabLivraison);
            this.TabClient.Location = new System.Drawing.Point(18, 248);
            this.TabClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabClient.Name = "TabClient";
            this.TabClient.SelectedIndex = 0;
            this.TabClient.Size = new System.Drawing.Size(1002, 329);
            this.TabClient.TabIndex = 11;
            // 
            // TabAdresse
            // 
            this.TabAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.TabAdresse.Controls.Add(this.CbxPays);
            this.TabAdresse.Controls.Add(this.label1);
            this.TabAdresse.Location = new System.Drawing.Point(4, 29);
            this.TabAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabAdresse.Name = "TabAdresse";
            this.TabAdresse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabAdresse.Size = new System.Drawing.Size(994, 296);
            this.TabAdresse.TabIndex = 0;
            this.TabAdresse.Text = "Adresse";
            // 
            // TabLivraison
            // 
            this.TabLivraison.BackColor = System.Drawing.SystemColors.Control;
            this.TabLivraison.Location = new System.Drawing.Point(4, 29);
            this.TabLivraison.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabLivraison.Name = "TabLivraison";
            this.TabLivraison.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabLivraison.Size = new System.Drawing.Size(994, 296);
            this.TabLivraison.TabIndex = 1;
            this.TabLivraison.Text = "Livraison";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(224, 172);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(788, 26);
            this.textBox1.TabIndex = 12;
            // 
            // ChkProspect
            // 
            this.ChkProspect.AutoSize = true;
            this.ChkProspect.Location = new System.Drawing.Point(126, 39);
            this.ChkProspect.Name = "ChkProspect";
            this.ChkProspect.Size = new System.Drawing.Size(98, 24);
            this.ChkProspect.TabIndex = 13;
            this.ChkProspect.Text = "Prospect";
            this.ChkProspect.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 14;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(254, 40);
            this.LblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(55, 20);
            this.LblCode.TabIndex = 15;
            this.LblCode.Text = "Code :";
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.ControlBox = false;
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ChkProspect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TabClient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.TxtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Fiche client";
            this.TabClient.ResumeLayout(false);
            this.TabAdresse.ResumeLayout(false);
            this.TabAdresse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.ComboBox CbxPays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl TabClient;
        private System.Windows.Forms.TabPage TabAdresse;
        private System.Windows.Forms.TabPage TabLivraison;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ChkProspect;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.TextBox textBox2;
    }
}