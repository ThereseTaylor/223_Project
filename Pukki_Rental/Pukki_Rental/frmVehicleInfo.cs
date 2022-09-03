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

            //done in one line or the code throws a tantrum. Displays vehicle table to datagridview. changing the id's to information from their respective table
            sql = "SELECT Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicleInfo.DataSource = ds;
            dgVehicleInfo.DataMember = "SourceTable";

            conn.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (rdoAdd.Checked == true)
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {
                    frmPopup popup = new frmPopup();
                    popup.ShowDialog();

                    string sql;
                    if (popup.addVehicle == true)
                    {
                        try
                        {
                            sql = "";
                            int rentalstatus = 0;
                            conn.Open();
                            sql = $"INSERT INTO VEHICLE(TypeID, ModelID, ColourID, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price, Rental_Status) " +
                                $"VALUES ({popup.vTypeID}, {popup.vModelID}, {popup.vColourID}, '{popup.vehicleReg}', {popup.purchPrice}, '{popup.purchDate}', {popup.rentalCost}, {rentalstatus})";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New Vehicle successfully added");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was an error adding the new Vehicle\n" + ex);
                            conn.Close();
                        }
                    }
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
                            conn.Close();
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
                            conn.Close();
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
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an option by data type above");
                }

            }
            else if (rdoDelete.Checked == true)
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {

                }else if(cmbTable.SelectedIndex == 1)//model
                {

                }else if(cmbTable.SelectedIndex == 2)//type
                {

                }else if(cmbTable.SelectedIndex == 3)//colour
                {

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

                //done in one line or code throws a fit
                sql = "SELECT Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";

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
