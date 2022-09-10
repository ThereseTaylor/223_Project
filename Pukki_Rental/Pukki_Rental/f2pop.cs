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
    public partial class f2pop : Form
    {

        public bool conf = false;

        public f2pop()
        {
            InitializeComponent();
        }

        private void f2pop_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Canc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn2_Sumbit_Click(object sender, EventArgs e)
        {
            conf = true;

            MessageBox.Show("confir");
            this.Close();
        }
    }
}
