using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrcEvo.Forms
{
    public partial class ClientEditForm : Form
    {
        // new MailServerSettings().ShowDialog(); // à tester

        public ClientEditForm()
        {

            InitializeComponent();

            //this.comboBox1.Validating += new CancelEventHandler(this.comboBox1_Validating);

        }

        private void Save()
        {

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



        
        private void TxtNom_Validating(object sender, CancelEventArgs e)
        {
            if (TxtNom.Text.Length<2)
            {
                errorProvider1.SetError(TxtNom, "Nom incorrect");
            }
            else
            {
                errorProvider1.SetError(TxtNom, string.Empty);
            }
        }
    }
}
