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
        public string vModelID, vTypeID, vColourID;
        public Boolean addVehicle = false;
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
            string sql = "SELECT Type_Description FROM VEHICLE_TYPE";
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
            sql = "SELECT Model_Description FROM VEHICLE_MODEL";
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
            sql = "SELECT Colour_Name FROM VEHICLE_COLOUR";
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
            if(txtPurchPrice.Text == "" || txtReg.Text == "" || txtRentalCost.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please ensure to fill out the data correctly");
            }
            else
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT Registration_Plate FROM VEHICLE";
                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int availableColour = 0;

                while (reader.Read())
                {
                    if (reader.GetString(0).ToLower() == txtReg.Text.ToLower())
                    {
                        availableColour += 1;
                    }
                }
                conn.Close();

                if (availableColour == 0)
                {
                    try
                    {
                        vehicleReg = txtReg.Text;
                        rentalCost = Convert.ToDouble(txtRentalCost.Text);
                        purchPrice = Convert.ToDouble(txtPurchPrice.Text);
                        if (dtPurchDate.Value < DateTime.Today)
                        {
                            purchDate = dtPurchDate.Value.ToString("dd-MM-yyyy");
                            addVehicle = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot choose a future date");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Please ensure you enter in the correct information");
                    }
                }
                else
                {
                    MessageBox.Show("There is already a vehicle with that registration,\nplease enter a new registration or press cancel to exit");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
