using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pukki_Rental
{
    public partial class frmColourPopup : Form
    {
        public String newColour;
        public Boolean addColour = false;
        string conStr = @"Data Source=DESKTOP-GVIQ2PC;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
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
                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT Colour_Name FROM dbo.VEHICLE_COLOUR";
                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int availableColour = 0;

                while (reader.Read())
                {
                    if (reader.GetString(0).ToLower() == txtColour.Text.ToLower())
                    {
                        availableColour += 1;
                    }
                }
                conn.Close();
                
                if(availableColour == 0)
                {
                    newColour = txtColour.Text;
                    addColour = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That colour is already available.\nYou can try add a different colour or press cancel to exit.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
