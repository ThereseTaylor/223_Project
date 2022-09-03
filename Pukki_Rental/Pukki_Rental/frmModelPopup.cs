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
    public partial class frmModelPopup : Form
    {
        public string newModel;
        public Boolean addModel = false;
        string conStr = @"Data Source=DESKTOP-GVIQ2PC;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
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
                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT Model_Description FROM VEHICLE_MODEL";
                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int availableType = 0;

                while (reader.Read())
                {
                    if (reader.GetString(0).ToLower() == txtModel.Text.ToLower())
                    {
                        availableType += 1;
                    }
                }
                conn.Close();

                if (availableType == 0)
                {
                    newModel = txtModel.Text;
                    addModel = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That model is already available.\nYou can try add a different model or press cancel to exit.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
