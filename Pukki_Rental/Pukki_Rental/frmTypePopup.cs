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
        public string newType, newTown, newName;
        public int newNumber, newTownID;
        public Boolean addType,addTown, addAddress = false;
        string conStr = @"Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            string sql = "";
            if (frmClientInfo.whatToInsert == 2)
            {
                if (txtType.Text == "")
                {
                    MessageBox.Show("Please fill in the given space");
                }
                else 
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    sql = "SELECT Town_Name FROM dbo.TOWN";
                    ds = new DataSet();
                    adap = new SqlDataAdapter();
                    cmd = new SqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    int availableTown = 0;

                    while (reader.Read())
                    {
                        if (reader.GetString(0).ToLower() == txtType.Text.ToLower())
                        {
                            availableTown += 1;
                        }
                    }
                    conn.Close();

                    if (availableTown == 0)
                    {
                        newTown = txtType.Text;
                        addTown = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("That town is already available.\nYou can try add a different type or press cancel to exit.");
                    }
                }
                frmClientInfo.whatToInsert = 0;
            }
            else if (frmClientInfo.whatToInsert == 1)
            {
                if (txtType.Text == "")
                {
                    MessageBox.Show("Please fill in the given space");
                }
                else
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    sql = "SELECT Street_Name, Street_Number FROM dbo.ADDRESS";
                    ds = new DataSet();
                    adap = new SqlDataAdapter();
                    cmd = new SqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    int availableAddress = 0;

                    while (reader.Read())
                    {
                        if ((reader.GetString(0).ToLower() == txtType.Text.ToLower()) && (Convert.ToInt16(reader.GetValue(1)) == Convert.ToInt16(txtType.Text)))
                        {
                            availableAddress += 1;
                        }
                    }
                    conn.Close();

                    if (availableAddress == 0)
                    {
                        conn.Open();
                        sql = "SELECT TownID FROM dbo.TOWN WHERE Town_Name = '" + comboBox1.SelectedItem + "' ";
                        ds = new DataSet();
                        adap = new SqlDataAdapter();
                        cmd = new SqlCommand(sql, conn);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            newTownID = (int)reader.GetValue(0);
                        }
                        conn.Close();

                        newNumber = Convert.ToInt16(txtType.Text);
                        newName = textBox1.Text;
                        addAddress = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("That town is already available.\nYou can try add a different type or press cancel to exit.");
                    }
                }
                frmClientInfo.whatToInsert = 0;
            }
            else
            {
                if (txtType.Text == "")
                {
                    MessageBox.Show("Please fill in the given space");
                }
                else
                {
                    conn = new SqlConnection(conStr);
                    conn.Open();
                    ds = new DataSet();
                    adap = new SqlDataAdapter();
                    sql = "SELECT Type_Description FROM dbo.VEHICLE_TYPE";
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



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTypePopup_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            comboBox1.Hide();

            if (frmClientInfo.whatToInsert == 2)
            {
                label1.Text = "Please enter the new town name below:";
            }
            else if (frmClientInfo.whatToInsert == 1)
            {
                label1.Text = "Please enter the new address below:";
                label2.Show();
                label3.Show();
                textBox1.Show();
                comboBox1.Show();

                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT Town_Name FROM dbo.TOWN";
                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
                conn.Close();
            }
            else
            {
                label1.Text = "Please enter the new vehicle type below:";
            }
                
        }
    }
}
