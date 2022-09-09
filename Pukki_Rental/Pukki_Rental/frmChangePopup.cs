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
    public partial class frmChangePopup : Form
    {
        public int changeColourID, whatToChange;
        public string changeRegistration;
        public double changeRentalCost;
        public bool makeChange = false;
        string conStr = @"Data Source=DESKTOP-GVIQ2PC;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;
        public frmChangePopup()
        {
            InitializeComponent();
        }

        private void frmChangePopup_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "SELECT Colour_Name FROM dbo.VEHICLE_COLOUR";
            ds = new DataSet();
            adap = new SqlDataAdapter();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbColour.Items.Add(reader.GetString(0));
            }
            conn.Close();

            whatToChange = frmVehicleInfo.whatToChange;

            if (whatToChange == 0)
            {
                lblText.Text = "Select a new colour below";
                cmbColour.Visible = true;
            }
            else if (whatToChange == 1)
            {
                lblText.Text = "Enter the new registration below";
                txtChangedInfo.Visible = true;
            }
            else if(whatToChange == 2)
            {
                lblText.Text = "Enter the new rental cost below";
                txtChangedInfo.Visible = true;
            }
        }

        private void cmbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newColour = cmbColour.GetItemText(cmbColour.SelectedItem);
            conn.Open();
            string sql = "SELECT * FROM dbo.VEHICLE_COLOUR";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == newColour)
                {
                    changeColourID = (int)(reader.GetValue(0));
                }
            }
            conn.Close();
            makeChange = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            makeChange = false;
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (whatToChange == 1) //registration part
            { 
                if(txtChangedInfo.Text == "")
                {
                    MessageBox.Show("Please enter a new registration or press cancel");
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
                        if (reader.GetString(0).ToLower() == txtChangedInfo.Text.ToLower())
                        {
                            availableReg += 1;
                        }
                    }
                    conn.Close();

                    if (availableReg == 0)
                    {
                        changeRegistration = txtChangedInfo.Text;
                        makeChange = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You already have a vehicle with that registration\nYou cannot have duplicates");
                    }
                }
            }
            else if(whatToChange == 2) //Rental cost part
            {
                if(txtChangedInfo.Text == "")
                {
                    MessageBox.Show("Please enter a new rental price or press cancel");
                }
                else
                {
                    try
                    {
                        changeRentalCost = Convert.ToDouble(txtChangedInfo.Text);
                        makeChange = true;
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Please ensure to enter a valid number");
                    }
                }
            }
            else if(whatToChange == 0)//closes the form for colour, thats it lol
            {
                if(cmbColour.SelectedItem == null)
                {
                    MessageBox.Show("Please select a new colour or press cancel");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
