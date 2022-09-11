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
           if (ActiveMdiChild != null)// closes previous child form
           {
                ActiveMdiChild.Close();
           }
            
            frmRentOut myformView = new frmRentOut();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void receiveVehicleBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)// closes previous child form
            {
                ActiveMdiChild.Close();
            }

            frmReceiveBack myformView = new frmReceiveBack();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void vehicleModelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void townToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)// closes previous child form
            {
                ActiveMdiChild.Close();
            }

            frmAddress myformView = new frmAddress();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void clientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            frmClientDetails myformView = new frmClientDetails();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void townToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)// closes previous child form
            {
                ActiveMdiChild.Close();
            }

            frmTown myformView = new frmTown();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void vehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)// closes previous child form
            {
                ActiveMdiChild.Close();
            }

            frmVehicleInfo myformView = new frmVehicleInfo();
            myformView.MdiParent = this;
            myformView.Show();

        }

        private void clientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)// closes previous child form
            {
                ActiveMdiChild.Close();
            }

            frmReports myformView = new frmReports();
            myformView.MdiParent = this;
            myformView.Show();
        }
    }
}
