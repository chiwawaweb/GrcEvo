using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrcEvo.Controller;

namespace GrcEvo.Forms
{
    public partial class ClientEditForm : Form
    {
        public static string nomClient { get; set; }

        
        

        public ClientEditForm()
        {
           

            InitializeComponent();

            this.comboBox1.Validating += new
            System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);

            errorProvider1.SetError(TxtNom, "erreur 1");
            errorProvider1.SetError(textBox1, "erreur 2");
        }

        private void Save()
        {
            nomClient = TxtNom.Text;
            ClientEdit clientEdit = new ClientEdit();
            clientEdit.SaveData();

        }

        public void AfficheErreurs()
        {
            //ClientEdit clientEdit = new ClientEdit();
            //MessageBox.Show(erreurs.ToString());
        }

        #region Gestion des événements

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }



        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(comboBox1.Text);
                errorProvider1.SetError(comboBox1, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBox1, "Texte trop court");
            }
        }

       
    }
}
