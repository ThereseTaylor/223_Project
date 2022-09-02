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
    public partial class frmPopup : Form
    {
        public string vehicleReg, purchDate;
        public double rentalCost, purchPrice;
        string conStr = @"Data Source=DESKTOP-GVIQ2PC;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
        public frmPopup()
        {
            InitializeComponent();
        }
        private void frmPopup_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "SELECT * FROM VEHICLE_TYPE";
            ds = new DataSet();
            adap = new SqlDataAdapter();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }
            conn.Close();
            
            
            conn = new SqlConnection(conStr);
            conn.Open();
            sql = "SELECT * FROM VEHICLE_MODEL";
            ds = new DataSet();
            adap = new SqlDataAdapter();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString(0));
            }
            conn.Close();


            conn = new SqlConnection(conStr);
            conn.Open();
            sql = "SELECT * FROM VEHICLE_COLOUR";
            ds = new DataSet();
            adap = new SqlDataAdapter();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox3.Items.Add(reader.GetString(0));
            }
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                vehicleReg = txtReg.Text;
                if(dtPurchDate.Value < DateTime.Today)
                {
                    purchDate = dtPurchDate.Value.ToString("dd-MM-yyyy");
                }
                else
                {
                    MessageBox.Show("Cannot choose a future date");
                }
                rentalCost = Convert.ToDouble(txtRentalCost.Text);
                purchPrice = Convert.ToDouble(txtPurchPrice.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please ensure you enter in the correct information");
            }
        }

        
    }
}
