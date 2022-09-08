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
            lblHeader.Visible = false;
            comboReports.Items.Clear();
            cmbMonth.SelectedIndex = 0;

            comboReports.Items.Add("Sales report per month");
            comboReports.Items.Add("Client report");
            comboReports.Items.Add("Inventory report");
            comboReports.Items.Add("Rented out cars report"); // Management report

            comboReports.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = (cmbMonth.SelectedIndex) + 1;
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            string date = "";

            if (month == 1) // January
            {
                date = "BETWEEN '01/01/2022' AND '01/31/2022'";
            }
            else if (month == 2) // February
            {
                date = "BETWEEN '02/01/2022' AND '02/28/2022'";
            }
            else if (month == 3) // March
            {
                date = "BETWEEN '03/01/2022' AND '03/31/2022'";
            }
            else if (month == 4) // April
            {
                date = "BETWEEN '04/01/2022' AND '04/30/2022'";
            }
            else if (month == 5) // May
            {
                date = "BETWEEN '05/01/2022' AND '05/31/2022'";
            }
            else if (month == 6) // June
            {
                date = "BETWEEN '06/01/2022' AND '06/30/2022'";
            }
            else if (month == 7) // July
            {
                date = "BETWEEN '07/01/2022' AND '07/31/2022'";
            }
            else if (month == 8) // August
            {
                date = "BETWEEN '08/01/2022' AND '08/31/2022'";
            }
            else if (month == 9) // September
            {
                date = "BETWEEN '09/01/2022' AND '09/30/2022'";
            }
            else if (month == 10) // October
            {
                date = "BETWEEN '10/01/2022' AND '10/31/2022'";
            }
            else if (month == 11) // November
            {
                date = "BETWEEN '11/01/2022' AND '11/30/2022'";
            }
            else // December
            {
                date = "BETWEEN '12/01/2022' AND '12/31/2022'";
            }

            try
            {
                // ConnectionString with path to DB
                constr = @"Data Source=LAPTOP-9VKTMA6M;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False ";
                conn = new SqlConnection(constr);

                // Test if DB available
                try
                {
                    conn.Open();
                    conn.Close();
                    // MessageBox.Show("Database connection successful.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database connection unsuccessful!");
                    Close();
                }

                // Open DB
                conn.Open();
                adpt = new SqlDataAdapter();
                ds = new DataSet();

                // Set SQL to display all data
                if (comboReports.SelectedIndex == 0) // Sales report per month
                {
                    string mnth = cmbMonth.SelectedItem.ToString();
                    sql = "SELECT * FROM RENTAL_TRANSACTION WHERE Transaction_Date "+ date;
                    lblHeader.Text = "Sales report of " + mnth;
                }
                else if (comboReports.SelectedIndex == 1) // Client report
                {
                    sql = "SELECT ClientLN, ClientFN, ClientID_Number, Tel_Number, Email FROM CLIENT";
                    lblHeader.Text = "Client report";
                }
                else if (comboReports.SelectedIndex == 2) // Inventory report
                {
                    sql = "SELECT * FROM VEHICLE";
                    lblHeader.Text = "Inventory report";
                }
                else if (comboReports.SelectedIndex == 3) // Management report
                {
                    sql = "SELECT VehicleID, TypeID, ModelID, ColourID, Registration_Plate, Rental_Price, Rental_Status FROM VEHICLE WHERE Rental_Status > 0";
                    lblHeader.Text = "Vehicles currently out rented";
                }

                // Implement SQL
                comd = new SqlCommand(sql, conn);
                adpt.SelectCommand = comd;
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

        private void btnExportText_Click(object sender, EventArgs e)
        {

        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboReports.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}