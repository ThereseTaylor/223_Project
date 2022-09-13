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
using System.Data.Sql;

namespace Pukki_Rental
{
    public partial class frmReports : Form
    {
        // Global variables declaration
        string constr = "";
        SqlConnection conn;
        SqlCommand comd;
        SqlDataAdapter adpt;
        DataSet ds;
        string sql;

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            // Clear all objects and set initial/default values

            comboReports.Items.Clear();
            cmbMonth.SelectedIndex = 0;

            label2.Hide();
            cmbMonth.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            comboBox1.Hide();
            label12.Hide();
            comboReports.Items.Add("Sales report per month");
            comboReports.Items.Add("Amount of sales per month");
            comboReports.Items.Add("Inventory report");

            //comboReports.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboReports.SelectedIndex == 0) // Sales report per month
            {
                label2.Show();
                cmbMonth.Show();
                radioButton1.Hide();
                radioButton2.Hide();
                comboBox1.Hide();
                label12.Hide();
            }
            else if (comboReports.SelectedIndex == 1) //Amount of sales transactions per month
            {
                label2.Hide();
                cmbMonth.Hide();
                radioButton1.Show();
                radioButton2.Show();
                comboBox1.Show();
                label12.Show();

            }
            else if (comboReports.SelectedIndex == 2) // Inventory report
            {
                label2.Hide();
                cmbMonth.Hide();
                radioButton1.Hide();
                radioButton2.Hide();
                comboBox1.Hide();
                label12.Hide();
            }

        }

        private void btnExportText_Click(object sender, EventArgs e)
        {

        }
        
        DateTime start, end;

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = (cmbMonth.SelectedIndex) + 1;

            if (month == 1) // January
            {
                start = new DateTime(2022,01,01);
                end = new DateTime(2022, 01, 31);
            }
            else if (month == 2) // February
            {
                start = new DateTime(2022, 02, 01);
                end = new DateTime(2022, 02, 28);
            }
            else if (month == 3) // March
            {
                start = new DateTime(2022, 03, 01);
                end = new DateTime(2022, 03, 31);
            }
            else if (month == 4) // April
            {
                MessageBox.Show("in");
                start = new DateTime(2022, 04, 01);
                end = new DateTime(2022, 04, 30);
            }
            else if (month == 5) // May
            {
                start = new DateTime(2022, 05, 01);
                end = new DateTime(2022, 05, 31);
            }
            else if (month == 6) // June
            {
                start = new DateTime(2022, 06, 01);
                end = new DateTime(2022, 06, 30);
            }
            else if (month == 7) // July
            {
                start = new DateTime(2022, 07, 01);
                end = new DateTime(2022, 07, 31);
            }
            else if (month == 8) // August
            {
                start = new DateTime(2022, 08, 01);
                end = new DateTime(2022, 08, 31);
            }
            else if (month == 9) // September
            {
                start = new DateTime(2022, 09, 01);
                end = new DateTime(2022, 09, 30);
            }
            else if (month == 10) // October
            {
                start = new DateTime(2022, 10, 01);
                end = new DateTime(2022, 10, 31);
            }
            else if (month == 11) // November
            {
                start = new DateTime(2022, 11, 01);
                end = new DateTime(2022, 11, 30);
            }
            else // December
            {
                start = new DateTime(2022, 12, 01);
                end = new DateTime(2022, 12, 31);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ConnectionString with path to DB
                constr = @"Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                conn = new SqlConnection(constr);

                // Open DB
                conn.Open();
                adpt = new SqlDataAdapter();
                ds = new DataSet();

                // Set SQL to display all data
                if (comboReports.SelectedIndex == 0) // Sales report per month
                {
                    label2.Show();
                    cmbMonth.Show();
                    string mnth = cmbMonth.SelectedItem.ToString();
                    sql = "SELECT Model_Description AS 'Vehicle Model', Type_Description AS 'Vehicle Type', Colour_Name AS 'Vehicle Colour', Registration_Plate AS 'Registration Plate', Transaction_Price AS 'Purchase Price', Transaction_Date AS 'Date Purchased' FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C, dbo.RENTAL_TRANSACTION R WHERE R.VehicleID = V.VehicleID AND V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID AND Transaction_Date BETWEEN @startDate AND @endDate";

                    comd = new SqlCommand(sql, conn);
                    adpt.SelectCommand = comd;
                    adpt.SelectCommand.Parameters.AddWithValue("@startDate", start);
                    adpt.SelectCommand.Parameters.AddWithValue("@endDate", end);
                    adpt.Fill(ds, "SourceTable");

                    // Fill gridview
                    gvReport.DataSource = ds;
                    gvReport.DataMember = "SourceTable";
                  
                    // Close DB
                    conn.Close();
                }
                else if (comboReports.SelectedIndex == 1) //Amount of sales transactions per month
                {                    
                    if (comboBox1.SelectedIndex == 0)
                    {
                        if (radioButton2.Checked == true)///ASC
                        {
                            sql = "SELECT FORMAT(Transaction_Date,'MMMM') AS Month, COUNT(TransactionID) AS 'Amount of Transactions' FROM dbo.RENTAL_TRANSACTION GROUP BY FORMAT(Transaction_Date,'MMMM') ORDER BY Month";
                        }
                        else
                        {
                            sql = "SELECT FORMAT(Transaction_Date,'MMMM') AS Month, COUNT(TransactionID) AS 'Amount of Transactions' FROM dbo.RENTAL_TRANSACTION GROUP BY FORMAT(Transaction_Date,'MMMM') ORDER BY Month DESC";
                        }
                           
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        if (radioButton2.Checked == true)//ASC
                        {
                            sql = "SELECT FORMAT(Transaction_Date,'MMMM') AS Month, COUNT(TransactionID) AS 'Amount of Transactions' FROM dbo.RENTAL_TRANSACTION GROUP BY FORMAT(Transaction_Date,'MMMM') ORDER BY 'Amount of Transactions'";
                        }
                        else
                        {
                            sql = "SELECT FORMAT(Transaction_Date,'MMMM') AS Month, COUNT(TransactionID) AS 'Amount of Transactions' FROM dbo.RENTAL_TRANSACTION GROUP BY FORMAT(Transaction_Date,'MMMM') ORDER BY 'Amount of Transactions' DESC";
                        }
                    }
                    else
                    {
                        sql = "SELECT FORMAT(Transaction_Date,'MMMM') AS Month, COUNT(TransactionID) AS 'Amount of Transactions' FROM dbo.RENTAL_TRANSACTION GROUP BY FORMAT(Transaction_Date,'MMMM')";
                    }

                }

                else if (comboReports.SelectedIndex == 2) // Inventory report
                {
                    sql = "SELECT Model_Description AS 'Vehicle Model', Type_Description AS 'Vehicle Type', Colour_Name AS 'Vehicle Colour', Registration_Plate AS 'Registration Plate', Purchase_Price AS 'Purchase Price', Purchase_Date AS 'Date Purchased', Rental_Price AS 'Rental Price' FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID ORDER BY Purchase_Date";
                }


                // Implement SQL
                comd = new SqlCommand(sql, conn);
                adpt.SelectCommand = comd;
                adpt.SelectCommand.Parameters.AddWithValue("@startDate", start);
                adpt.SelectCommand.Parameters.AddWithValue("@endDate", end);
                adpt.Fill(ds, "SourceTable");

                // Fill gridview
                gvReport.DataSource = ds;
                gvReport.DataMember = "SourceTable";

                // Close DB
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}