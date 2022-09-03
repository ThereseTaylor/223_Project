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
    public partial class frmColourPopup : Form
    {
        public String newColour;
        public Boolean addColour = false;
        public frmColourPopup()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtColour.Text == "")
            {
                MessageBox.Show("Please enter a colour to submit");
            }
            else
            {
                newColour = txtColour.Text;
                addColour = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
