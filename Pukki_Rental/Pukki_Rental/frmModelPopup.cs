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
    public partial class frmModelPopup : Form
    {
        public string newModel;
        public frmModelPopup()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtModel.Text == "")
            {
                MessageBox.Show("Please enter a model to submit");
            }
            else
            {
                newModel = txtModel.Text;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
