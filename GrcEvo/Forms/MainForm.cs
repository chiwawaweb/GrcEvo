using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrcEvo.DAL;

namespace GrcEvo.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ClientProvider clientProvider = new ClientProvider();
            clientProvider.CountAll();
        }

        #region Gestion des événements

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void BtnClientNew_Click(object sender, EventArgs e)
        {
            /* TEMPORAIRE */
            ClientEditForm clientEditForm = new ClientEditForm();
            clientEditForm.ShowDialog();
        }
    }
}
