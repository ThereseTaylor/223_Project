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
    public partial class frmTypePopup : Form
    {
        public string newType;
        public Boolean addType = false;
        string conStr = @"Data Source=LAPTOP-ON3GIIKN\SQLEXPRESS;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;



        public frmTypePopup()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                MessageBox.Show("Please enter a type to submit");
            }
            else
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT Type_Description FROM dbo.VEHICLE_TYPE";
                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int availableType = 0;

                while (reader.Read())
                {
                    if (reader.GetString(0).ToLower() == txtType.Text.ToLower())
                    {
                        availableType += 1;
                    }
                }
                conn.Close();

                if (availableType == 0)
                {
                    newType = txtType.Text;
                    addType = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That vehicle type is already available.\nYou can try add a different type or press cancel to exit.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTypePopup_Load(object sender, EventArgs e)
        {

        }
    }
}
