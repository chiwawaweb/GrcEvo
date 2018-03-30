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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TabClient.SuspendLayout();
            this.TabAdresse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNom
            // 
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Location = new System.Drawing.Point(153, 59);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(527, 20);
            this.TxtNom.TabIndex = 0;
            this.TxtNom.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNom_Validating);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(48, 62);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(35, 13);
            this.LblNom.TabIndex = 1;
            this.LblNom.Text = "Nom :";
            // 
            // CbxPays
            // 
            this.CbxPays.FormattingEnabled = true;
            this.CbxPays.Location = new System.Drawing.Point(147, 71);
            this.CbxPays.Name = "CbxPays";
            this.CbxPays.Size = new System.Drawing.Size(181, 21);
            this.CbxPays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pays :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(605, 381);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(524, 381);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // TabClient
            // 
            this.TabClient.Controls.Add(this.TabAdresse);
            this.TabClient.Controls.Add(this.TabLivraison);
            this.TabClient.Location = new System.Drawing.Point(12, 161);
            this.TabClient.Name = "TabClient";
            this.TabClient.SelectedIndex = 0;
            this.TabClient.Size = new System.Drawing.Size(668, 214);
            this.TabClient.TabIndex = 11;
            // 
            // TabAdresse
            // 
            this.TabAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.TabAdresse.Controls.Add(this.CbxPays);
            this.TabAdresse.Controls.Add(this.label1);
            this.TabAdresse.Location = new System.Drawing.Point(4, 22);
            this.TabAdresse.Name = "TabAdresse";
            this.TabAdresse.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabAdresse.Size = new System.Drawing.Size(660, 188);
            this.TabAdresse.TabIndex = 0;
            this.TabAdresse.Text = "Adresse";
            // 
            // TabLivraison
            // 
            this.TabLivraison.BackColor = System.Drawing.SystemColors.Control;
            this.TabLivraison.Location = new System.Drawing.Point(4, 22);
            this.TabLivraison.Name = "TabLivraison";
            this.TabLivraison.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabLivraison.Size = new System.Drawing.Size(660, 188);
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
            this.textBox1.Location = new System.Drawing.Point(149, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 20);
            this.textBox1.TabIndex = 12;
            // 
            // ChkProspect
            // 
            this.ChkProspect.AutoSize = true;
            this.ChkProspect.Location = new System.Drawing.Point(84, 25);
            this.ChkProspect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkProspect.Name = "ChkProspect";
            this.ChkProspect.Size = new System.Drawing.Size(68, 17);
            this.ChkProspect.TabIndex = 13;
            this.ChkProspect.Text = "Prospect";
            this.ChkProspect.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 24);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 20);
            this.textBox2.TabIndex = 14;
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(169, 26);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(38, 13);
            this.LblCode.TabIndex = 15;
            this.LblCode.Text = "Code :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(608, 27);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Prospect";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ClientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 415);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
    }
}