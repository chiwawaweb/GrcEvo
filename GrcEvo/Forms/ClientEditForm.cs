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
        public ClientEditForm()
        {
            InitializeComponent();
        }



        #region Gestion des événements

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
