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
    public partial class frmVehicleInfo : Form
    {
        public frmVehicleInfo()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=DESKTOP-GVIQ2PC;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;

        private void frmVehicleInfo_Load(object sender, EventArgs e)
        {
            string sql = "";      //on load adds vehicle table to the data grid

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            sql = "SELECT * FROM dbo.VEHICLE";

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicleInfo.DataSource = ds;
            dgVehicleInfo.DataMember = "SourceTable";

            conn.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if(rdoAdd.Checked == true)
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {
                    frmPopup popup = new frmPopup();
                    popup.ShowDialog();

                }
                else if (cmbTable.SelectedIndex == 1)//model
                {
                    frmModelPopup modelpopup = new frmModelPopup();
                    modelpopup.ShowDialog();

                    string sql;
                    if (modelpopup.addModel == true)
                    {
                        try
                        {
                            conn.Open();
                            sql = $"INSERT INTO VEHICLE_MODEL(Model_Description)" + $"VALUES ('{modelpopup.newModel}')";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New model successfully added");
                        }
                        catch
                        {
                            MessageBox.Show("There was an error adding the new model");
                        }
                    }

                }
                else if (cmbTable.SelectedIndex == 2)//type
                {
                    frmTypePopup typepopup = new frmTypePopup();
                    typepopup.ShowDialog();

                    string sql;
                    if (typepopup.addType == true)
                    {
                        try
                        {
                            conn.Open();
                            sql = $"INSERT INTO VEHICLE_TYPE(Type_Description)" + $"VALUES ('{typepopup.newType}')";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New type successfully added");
                        }
                        catch
                        {
                            MessageBox.Show("There was an error adding the new type");
                        }
                    }
                }
                else if (cmbTable.SelectedIndex == 3)//colour
                {
                    frmColourPopup colourpopup = new frmColourPopup();
                    colourpopup.ShowDialog();

                    string sql;
                    if (colourpopup.addColour == true)
                    {
                        try
                        {
                            conn.Open();
                            sql = $"INSERT INTO VEHICLE_COLOUR(Colour_Name)" + $"VALUES ('{colourpopup.newColour}')";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New colour successfully added");
                        }
                        catch
                        {
                            MessageBox.Show("There was an error adding the new colour");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an option by data type above");
                }

            }
        }

        private void rdoChange_CheckedChanged(object sender, EventArgs e) //hides and unhides the combobox for change
        {
            if(rdoChange.Checked == true)
            {
                cmbChange.Visible = true;
                lblChange.Visible = true;
            }
            else
            {
                cmbChange.Visible = false;
                lblChange.Visible = false;
            }
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e) //updates the data grid to show each of the tables when selected
        {
            if (cmbTable.SelectedIndex == 0) //vehicle
            {
                string sql = "";

                conn = new SqlConnection(conStr);
                conn.Open();

                ds = new DataSet();
                adap = new SqlDataAdapter();

                sql = "SELECT * FROM dbo.VEHICLE";

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgVehicleInfo.DataSource = ds;
                dgVehicleInfo.DataMember = "SourceTable";

                conn.Close();
            }
            else if (cmbTable.SelectedIndex == 1) //model
            {
                string sql = "";

                conn = new SqlConnection(conStr);
                conn.Open();

                ds = new DataSet();
                adap = new SqlDataAdapter();

                sql = "SELECT * FROM dbo.VEHICLE_MODEL";

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgVehicleInfo.DataSource = ds;
                dgVehicleInfo.DataMember = "SourceTable";

                conn.Close();
            }
            else if(cmbTable.SelectedIndex == 2) //type
            {
                string sql = "";

                conn = new SqlConnection(conStr);
                conn.Open();

                ds = new DataSet();
                adap = new SqlDataAdapter();

                sql = "SELECT * FROM dbo.VEHICLE_TYPE";

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgVehicleInfo.DataSource = ds;
                dgVehicleInfo.DataMember = "SourceTable";

                conn.Close();
            }
            else if (cmbTable.SelectedIndex == 3) //colour
            {
                string sql = "";

                conn = new SqlConnection(conStr);
                conn.Open();

                ds = new DataSet();
                adap = new SqlDataAdapter();

                sql = "SELECT * FROM dbo.VEHICLE_COLOUR";

                cmd = new SqlCommand(sql, conn);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgVehicleInfo.DataSource = ds;
                dgVehicleInfo.DataMember = "SourceTable";

                conn.Close();
            }
        }
    }
}
