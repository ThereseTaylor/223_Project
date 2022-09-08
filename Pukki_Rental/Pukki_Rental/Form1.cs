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
    public partial class frmWelcome : Form
    {
       

        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rentAVehicleOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRentOut myformView = new frmRentOut();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void vehicleModelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetails frmClientDetails = new frmClientDetails();
            frmClientDetails.Show(this);
        }

        private void townToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddress frmAddress = new frmAddress();
            frmAddress.Show(this);
        }

        private void townToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTown frmTown = new frmTown();
            frmTown.Show(this);
        }
    }
}
