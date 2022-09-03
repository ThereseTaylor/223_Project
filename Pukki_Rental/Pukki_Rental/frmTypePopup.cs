using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pukki_Rental
{
    public partial class frmTypePopup : Form
    {
        public string newType;
        public Boolean addType = false;
        public frmTypePopup()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                MessageBox.Show("Please enter a type to submit");
            }
            else
            {
                newType = txtType.Text;
                addType = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
