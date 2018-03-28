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
        public string nomClient;

        //ClientEdit clientEdit = new ClientEdit();

        public ClientEditForm()
        {
            InitializeComponent();

            
        }

        

        

        private void Save()
        {
            nomClient = TxtNom.Text;
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
    }
}
