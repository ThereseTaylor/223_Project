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

        private void receiveVehicleBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiveBack myformView = new frmReceiveBack();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void vehicleModelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void townToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddress myformView = new frmAddress();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void clientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientDetails myformView = new frmClientDetails();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void townToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTown myformView = new frmTown();
            myformView.MdiParent = this;
            myformView.Show();
        }
    }
}
