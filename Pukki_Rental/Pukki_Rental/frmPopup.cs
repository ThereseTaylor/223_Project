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
        public int vModelID, vTypeID, vColourID;
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
            string sql = "SELECT Type_Description FROM dbo.VEHICLE_TYPE";
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
            sql = "SELECT Model_Description FROM dbo.VEHICLE_MODEL";
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
            sql = "SELECT Colour_Name FROM dbo.VEHICLE_COLOUR";
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vType = comboBox1.GetItemText(comboBox1.SelectedItem);
            conn.Open();
            string sql = "SELECT * FROM dbo.VEHICLE_TYPE";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(reader.GetValue(1).ToString() == vType)
                {
                    vTypeID = (int)(reader.GetValue(0));
                }
            }
            conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vModel = comboBox2.GetItemText(comboBox2.SelectedItem);
            conn.Open();
            string sql = "SELECT * FROM dbo.VEHICLE_MODEL";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == vModel)
                {
                    vModelID = (int)(reader.GetValue(0));
                }
            }
            conn.Close();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vColour = comboBox3.GetItemText(comboBox3.SelectedItem);
            conn.Open();
            string sql = "SELECT * FROM dbo.VEHICLE_COLOUR";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == vColour)
                {
                    vColourID = (int)(reader.GetValue(0));
                }
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
                string sql = "SELECT Registration_Plate FROM dbo.VEHICLE";
                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                int availableReg = 0;

                while (reader.Read())
                {
                    if (reader.GetString(0).ToLower() == txtReg.Text.ToLower())
                    {
                        availableReg += 1;
                    }
                }
                conn.Close();

                if (availableReg == 0)
                {
                    try
                    {
                        vehicleReg = txtReg.Text;
                        rentalCost = Convert.ToDouble(txtRentalCost.Text);
                        purchPrice = Convert.ToDouble(txtPurchPrice.Text);
                        if (dtPurchDate.Value <= DateTime.Today)
                        {
                            purchDate = dtPurchDate.Value.ToString("dd-MM-yyyy");
                            addVehicle = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cannot choose a future date");
                            conn.Close();
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
            conn.Close();
            this.Close();
        }
        
    }
}
