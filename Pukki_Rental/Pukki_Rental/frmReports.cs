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
            btnExportText.Enabled = false;
            cmbMonth.SelectedIndex = 0;

            comboReports.Items.Add("Sales report per month");
            comboReports.Items.Add("Client report");
            comboReports.Items.Add("Inventory report");
            comboReports.Items.Add("Management report");

            comboReports.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExportText.Enabled = true;
            string month = cmbMonth.SelectedItem.ToString();

            try
            {
                // ConnectionString with path to DB
                constr = @"";
                conn = new SqlConnection(constr);

                // Test if DB available
                try
                {
                    conn.Open();
                    conn.Close();
                    MessageBox.Show("Database connection successful.");
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
                    sql = "";
                    lblHeader.Text = "Sales report of " + month;
                }
                else if (comboReports.SelectedIndex == 1) // Client report
                {
                    sql = "";
                    lblHeader.Text = "Client report";
                }
                else if (comboReports.SelectedIndex == 2) // Inventory report
                {
                    sql = "";
                    lblHeader.Text = "Inventory report";
                }
                else if (comboReports.SelectedIndex == 3) // Management report
                {
                    sql = "";
                    lblHeader.Text = "Management report";
                }

                // Implement SQL
                comd = new SqlCommand(sql, conn);
                adpt.SelectCommand = comd;
                adpt.Fill(ds, "SourceTable");

                // Fill gridview
                

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
    }
}
