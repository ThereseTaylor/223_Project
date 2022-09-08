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

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReports myformView = new frmReports();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void welcomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ggToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
