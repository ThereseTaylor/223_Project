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
        public static int whatToChange; //need this for my change popup form
        public frmVehicleInfo()
        {
            InitializeComponent();
        }

        //tells code where its getting this data, plus some neccesary variables for using database stuff.
        string conStr = @"Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;

        private void frmVehicleInfo_Load(object sender, EventArgs e)
        {
            string sql = "";      //on load adds vehicle table to the data grid

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            //done in one line or the code throws a tantrum. Displays vehicle table to datagridview. changing the id's to information from their respective table
            sql = "SELECT VehicleID, Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicleInfo.DataSource = ds;
            dgVehicleInfo.DataMember = "SourceTable";

            conn.Close();

            cmbSelectID.Items.Clear();
            cmBox3_DeleteVehicle.Hide();
           
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string sql;
            //-----------------------------------------------------FOR ADDING TO DATABASE---------------------------------------------
            if (rdoAdd.Checked == true) //add functions
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {
                    frmPopup popup = new frmPopup(); //loads a popup used to input data that is added
                    popup.ShowDialog();

                    if (popup.addVehicle == true) //boolean variable used so it doesnt try add nothing to data, which leaves empty spaces in datagridview
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
                        catch
                        {
                            MessageBox.Show("There was an error adding the new Vehicle");
                            conn.Close();
                        }
                    }
                }
                else if (cmbTable.SelectedIndex == 1)//model
                {
                    frmModelPopup modelpopup = new frmModelPopup();
                    modelpopup.ShowDialog();

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
            //-----------------------------------------FOR DELETING FROM THE DATABASE---------------------------------------------------
            else if (rdoDelete.Checked == true) //Delete functions
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehicles
                {
                    Delete($"DELETE FROM dbo.VEHICLE WHERE VehicleID = '{cmBox3_DeleteVehicle.Text}'");
                }
                else if (cmbTable.SelectedIndex == 1)//model
                {
                    Delete($"DELETE FROM dbo.VEHICLE_MODEL WHERE ModelID = '{cmBox3_DeleteVehicle.Text}'");
                }
                else if (cmbTable.SelectedIndex == 2)//type
                {
                    Delete($"DELETE FROM dbo.VEHICLE_TYPE WHERE TypeID = '{cmBox3_DeleteVehicle.Text}'");
                }
                else if (cmbTable.SelectedIndex == 3)//colour
                {
                    Delete($"DELETE FROM dbo.VEHICLE_COLOUR WHERE ColourID = '{cmBox3_DeleteVehicle.Text}'");
                }
                else
                {
                    MessageBox.Show("Please select an option by data type above");
                }
                cmBox3_DeleteVehicle.Show();
            }
            //-------------------------------------FOR CHANGING ITEMS IN THE DATABASE--------------------------------------------------------------
            else if (rdoChange.Checked == true) //Chance functions
            {
                
                if (cmbChange.SelectedItem != null && cmbSelectID.SelectedItem != null)
                {
                    whatToChange = cmbChange.SelectedIndex;
                    frmChangePopup changePopup = new frmChangePopup();
                    changePopup.ShowDialog();

                    if (cmbChange.SelectedIndex == 0) //colour
                    {
                        if (changePopup.makeChange == true)
                        {
                            try
                            {
                                conn.Open();
                                sql = $"UPDATE VEHICLE SET ColourID = {changePopup.changeColourID} WHERE VehicleID = {cmbSelectID.SelectedItem}";
                                adap = new SqlDataAdapter();
                                cmd = new SqlCommand(sql, conn);
                                adap.InsertCommand = cmd;
                                adap.InsertCommand.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Colour successfully changed");
                            }
                            catch
                            {
                                MessageBox.Show("There was an error changing the colour");
                                conn.Close();
                            }
                        }
                    }
                    else if (cmbChange.SelectedIndex == 1)//regi
                    {
                        if (changePopup.makeChange == true)
                        {
                            try
                            {
                                conn.Open();
                                sql = $"UPDATE VEHICLE SET Registration_Plate = '{changePopup.changeRegistration}' WHERE VehicleID = {cmbSelectID.SelectedItem}";
                                adap = new SqlDataAdapter();
                                cmd = new SqlCommand(sql, conn);
                                adap.InsertCommand = cmd;
                                adap.InsertCommand.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Vehicle Registration successfully Changed");
                            }
                            catch
                            {
                                MessageBox.Show("There was an error changing the vehicle registration");
                                conn.Close();
                            }
                        }
                    }
                    else if (cmbChange.SelectedIndex == 2)//rental price
                    {
                        if (changePopup.makeChange == true)
                        {
                            try
                            {
                                conn.Open();
                                sql = $"UPDATE VEHICLE SET Rental_Price = '{changePopup.changeRentalCost}' WHERE VehicleID = {cmbSelectID.SelectedItem}";
                                adap = new SqlDataAdapter();
                                cmd = new SqlCommand(sql, conn);
                                adap.InsertCommand = cmd;
                                adap.InsertCommand.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Rental Price successfully Changed");
                            }
                            catch
                            {
                                MessageBox.Show("There was an error changing the rental price");
                                conn.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure to select which data type you would like to change and the ID of the vehicle");
                }
            }
            //----------------------------Just incase they dont select an option-------------------------------------------
            else
            {
                MessageBox.Show("Please select an option from functions");
            }


            
            
            //----------------------Refreshes the tables after adding/deleting/changing a new anything-----------------------------
            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            if (cmbTable.SelectedIndex == 0)
            {
                sql = "SELECT VehicleID, Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";
                cmd = new SqlCommand(sql, conn);
            }
            else if (cmbTable.SelectedIndex == 1)
            {
                sql = "SELECT * FROM dbo.VEHICLE_MODEL";
                cmd = new SqlCommand(sql, conn);
            }
            else if (cmbTable.SelectedIndex == 2)
            {
                sql = "SELECT * FROM dbo.VEHICLE_TYPE";
                cmd = new SqlCommand(sql, conn);
            }
            else if (cmbTable.SelectedIndex == 3)
            {
                sql = "SELECT * FROM dbo.VEHICLE_COLOUR";
                cmd = new SqlCommand(sql, conn);
            }

            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicleInfo.DataSource = ds;
            dgVehicleInfo.DataMember = "SourceTable";

            conn.Close();
        }

        private void rdoChange_CheckedChanged(object sender, EventArgs e) //hides and unhides the combobox for change
        {
            cmBox3_DeleteVehicle.Hide();
            if(rdoChange.Checked == true)
            {
                cmbChange.Visible = true;
                lblChange.Visible = true;
                cmbSelectID.Visible = true;
                lblSelectID.Visible = true;
            }
            else
            {
                cmbChange.Visible = false;
                lblChange.Visible = false;
                cmbSelectID.Visible = false;
                lblSelectID.Visible = false;
            }
            conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "SELECT VehicleID FROM dbo.VEHICLE";
            ds = new DataSet();
            adap = new SqlDataAdapter();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbSelectID.Items.Add(reader.GetValue(0));
            }

            conn.Close();
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e) //updates the data grid to show each of the tables when selected
        {
            rdoAdd.Checked = false;
            rdoChange.Checked = false;
            rdoDelete.Checked = false;

            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            if (cmbTable.SelectedIndex == 0) //vehicle
            {
                sql = "SELECT VehicleID, Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";
                rdoChange.Visible = true;
            }
            else if (cmbTable.SelectedIndex == 1) //model
            {
                sql = "SELECT * FROM dbo.VEHICLE_MODEL";
                rdoChange.Visible = false;
                rdoChange.Checked = false;
            }
            else if (cmbTable.SelectedIndex == 2)//type
            {
                sql = "SELECT * FROM dbo.VEHICLE_TYPE";
                rdoChange.Visible = false;
                rdoChange.Checked = false;
            }
            else if (cmbTable.SelectedIndex == 3)//colour
            {
                sql = "SELECT * FROM dbo.VEHICLE_COLOUR";
                rdoChange.Visible = false;
                rdoChange.Checked = false;
            }

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicleInfo.DataSource = ds;
            dgVehicleInfo.DataMember = "SourceTable";

            conn.Close();
        }

        public void Delete(string sql)
        {
            try
            {
                conn.Open();
                String Delete = sql;
                cmd = new SqlCommand(Delete, conn);
                adap = new SqlDataAdapter();
                adap.DeleteCommand = cmd;
                adap.DeleteCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Succesfully deleted");

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Combo(string sql)//fill the combo box with reg_plate so the user can select and delete that vehicle
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string fill = sql;
               // MessageBox.Show(name + ID);
                cmd = new SqlCommand(fill, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmBox3_DeleteVehicle.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgVehicleInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdoDelete_CheckedChanged(object sender, EventArgs e)
        {
            cmBox3_DeleteVehicle.Items.Clear();
            if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehicles
            {
                Combo("SELECT VehicleID FROM dbo.VEHICLE");
            }
            else if (cmbTable.SelectedIndex == 1)//model
            {
                Combo("SELECT ModelID FROM dbo.VEHICLE_MODEL");
            }
            else if (cmbTable.SelectedIndex == 2)//type
            {
                Combo("SELECT TypeID FROM dbo.VEHICLE_TYPE");
            }
            else if (cmbTable.SelectedIndex == 3)//colour
            {
                Combo("SELECT ColourID FROM dbo.VEHICLE_COLOUR");
            }
            else
            {
                MessageBox.Show("Please select an option by data type above");
            }
            cmBox3_DeleteVehicle.Show();
            lblChange.Show();
        }

        private void cmbChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdoAdd.Checked = false;
            rdoChange.Checked = false;
            rdoDelete.Checked = false;

        }

        private void rdoAdd_CheckedChanged(object sender, EventArgs e)
        {
            cmBox3_DeleteVehicle.Hide();
            lblChange.Hide();
        }
    }
}
