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
    public partial class frmWelcomePage : Form
    {
        public frmWelcomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rentAVehicleOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) //closes previous child form
            {
                ActiveMdiChild.Close();
            }

            frmRentOut myformView = new frmRentOut();
            myformView.MdiParent = this;
            myformView.Show();
        }

        private void vehicleInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null) //closes previous child form
            {
                ActiveMdiChild.Close();
            }
            
            frmVehicleInfo formviewing = new frmVehicleInfo();
            formviewing.MdiParent = this;

            formviewing.Dock = DockStyle.Fill; //forces child form to fill space of parent form. Doesnt help when parent form is made smaller

            formviewing.Show();
        }

        private void welcomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null) //closes previous child form
            {
                ActiveMdiChild.Close();
            }
        }
    }
}
