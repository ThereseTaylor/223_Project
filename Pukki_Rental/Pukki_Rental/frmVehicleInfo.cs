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



        //tells code where its getting this data, plus some neccesary variables for using database stuff.
        string conStr = @"Data Source=LAPTOP-ON3GIIKN\SQLEXPRESS;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dr;

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

            Combo();
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
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {
                    Delete();
                } else if (cmbTable.SelectedIndex == 1)//model
                {
                    Delete();
                }
                else if (cmbTable.SelectedIndex == 2)//type
                {
                    Delete();
                }
                else if (cmbTable.SelectedIndex == 3)//colour
                {
                    Delete();
                }
                else
                {
                    MessageBox.Show("Please select an option by data type above");
                }
            }
            //-------------------------------------FOR CHANGING ITEMS IN THE DATABASE--------------------------------------------------------------
            else if (rdoChange.Checked == true) //Chance functions
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {

                } else if (cmbTable.SelectedIndex == 1)//model
                {

                } else if (cmbTable.SelectedIndex == 2)//type
                {

                } else if (cmbTable.SelectedIndex == 3)//colour
                {

                }
                else
                {
                    MessageBox.Show("Please select an option by data type above");
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
                sql = "SELECT Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";
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
            if (rdoChange.Checked == true)
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
            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            if (cmbTable.SelectedIndex == 0)
            {
                sql = "SELECT Model_Description, Type_Description, Colour_Name, Registration_Plate, Purchase_Price, Purchase_Date, Rental_Price FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M , dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID";
            }
            else if (cmbTable.SelectedIndex == 1)
            {
                sql = "SELECT * FROM dbo.VEHICLE_MODEL";
            } else if (cmbTable.SelectedIndex == 2)
            {
                sql = "SELECT * FROM dbo.VEHICLE_TYPE";
            }
            else if (cmbTable.SelectedIndex == 3)
            {
                sql = "SELECT * FROM dbo.VEHICLE_COLOUR";
            }

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicleInfo.DataSource = ds;
            dgVehicleInfo.DataMember = "SourceTable";

            conn.Close();

            LoadAll();
        }


        public void Delete()
        {
            try
            {
               

                f2pop popDelete = new f2pop();
                popDelete.ShowDialog();

                if (popDelete.conf == true)
                {
                    /*conn.Open();
                    String Delete = $"DELETE FROM dbo.VEHICLE, dbo.VEHICLE_COLOUR, dbo.VEHICLE_MODEL, dbo.VEHICLE_TYPE  WHERE  = VehicleID, TypeID, ModelID, ColourID = '{cmBox3_DeleteVehicle.Text}'";
                    cmd = new SqlCommand(Delete, conn);
                    adap = new SqlDataAdapter();
                    adap.DeleteCommand = cmd;
                    adap.DeleteCommand.ExecuteNonQuery();
                    conn.Close();*/

                    conn.Open();
                    String Delete = $"DELETE FROM VEHICLE WHERE  VEHICLEID= '{cmBox3_DeleteVehicle.Text}'";
                    cmd = new SqlCommand(Delete, conn);
                    adap = new SqlDataAdapter();
                    adap.DeleteCommand = cmd;
                    adap.DeleteCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(cmBox3_DeleteVehicle.Text + " recored deleted");
                }
                else
                {
                    MessageBox.Show(cmBox3_DeleteVehicle.Text + " not deleted");
                }

                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Combo()//fill the combo box with reg_plate so the user can select and delete that vehicle
        {
            try 
            {
                /*conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string fill = "SELECT Vehicle_ID, Type_ID, Model_ID, Colour_ID FROM dbo.VEHICLE, dbo.VEHICLE_TYPE, dbo.VEHICLE_MODEL, dbo.VEHICLE_COLOUR";
                cmd = new SqlCommand(fill, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmBox3_DeleteVehicle.Items.Add(dr.GetValue(0));
                }
                conn.Close();*/


                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();
                string fill = "SELECT VehicleID FROM VEHICLE ";
                cmd = new SqlCommand(fill, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmBox3_DeleteVehicle.Items.Add(dr.GetValue(0));
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void LoadAll()
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
    }
}
