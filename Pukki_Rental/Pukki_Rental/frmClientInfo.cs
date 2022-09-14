﻿using System;
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
    public partial class frmClientInfo : Form
    {
        public static int newToChange, whatToInsert, townToChange; //need this for my change popup form
        public frmClientInfo()
        {
            InitializeComponent();
        }
        private void frmClientInfo_Load(object sender, EventArgs e)
        {
            string sql = "";      //on load adds vehicle table to the data grid

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            //Displays vehicle table to datagridview. changing the id's to information from their respective table
            sql = "SELECT  C.ClientID AS 'Client Number', C.ClientLN AS Surname, C.ClientFN AS Name, C.ClientID_Number AS 'ID Number', C.Tel_Number AS 'Telephone Number', C.Email AS Email, A.Street_Number AS 'Street Number', A.Street_Name AS 'Street Name' " +
                  "FROM dbo.CLIENT C, dbo.ADDRESS A WHERE C.AddressID = A.AddressID";
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgClientInfo.DataSource = ds;
            dgClientInfo.DataMember = "SourceTable";

            conn.Close();
            lblChange.Hide();
            lblSelectID.Hide();
            cmBox3_DeleteVehicle.Hide();
            cmbChange.Hide();
            cmbSelectID.Hide();
            cmbSelectID.Items.Clear();
            cmBox3_DeleteVehicle.Hide();
        }


        //tells code where its getting this data, plus some neccesary variables for using database stuff.
        string conStr = @"Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;

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

        public void Combo(string sql)
        {
            try
            {
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string fill = sql;
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

        private void rdoDelete_CheckedChanged_1(object sender, EventArgs e)
        {
            cmbChange.Hide();
            cmbSelectID.Hide();
            lblSelectID.Show();
            cmBox3_DeleteVehicle.Show();
            cmBox3_DeleteVehicle.Items.Clear();
            if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehicles
            {
                Combo("SELECT ClientID FROM dbo.CLIENT");
            }
            else if (cmbTable.SelectedIndex == 1)//address
            {
                Combo("SELECT AddressID FROM dbo.ADDRESS");
            }
            else if (cmbTable.SelectedIndex == 2)//town
            {
                Combo("SELECT TownID FROM dbo.TOWN");
            }

            else
            {
                MessageBox.Show("Please select an option by data type above");
            }
            
        }

        private void rdoAdd_CheckedChanged_1(object sender, EventArgs e)
        {
            lblSelectID.Hide();
            cmBox3_DeleteVehicle.Hide();
            lblChange.Hide();
        }

        private void cmbChange_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            rdoAdd.Checked = false;
            //rdoChange.Checked = false;
            rdoDelete.Checked = false;
        }

        private void cmbTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            rdoAdd.Checked = false;
            rdoChange.Checked = false;
            rdoDelete.Checked = false;

            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            if (cmbTable.SelectedIndex == 0) //client
            {
                sql = "SELECT  C.ClientID AS 'Client Number', C.ClientLN AS Surname, C.ClientFN AS Name, C.ClientID_Number AS 'ID Number', C.Tel_Number AS 'Telephone Number', C.Email AS Email, A.Street_Number AS 'Street Number', A.Street_Name AS 'Street Name'  " +
                  "FROM dbo.CLIENT C, dbo.ADDRESS A WHERE C.AddressID = A.AddressID";
                rdoChange.Visible = true;
            }
            else if (cmbTable.SelectedIndex == 1) //address
            {
                sql = "SELECT AddressID AS 'Address Number', Street_Number AS 'Street Number', Street_Name AS 'Street Name' FROM dbo.ADDRESS";
                rdoChange.Visible = true;
                ///rdoChange.Checked = false;
            }
            else if (cmbTable.SelectedIndex == 2)//town
            {
                sql = "SELECT TownID AS 'Town Number', Town_Name AS 'Town Name' FROM dbo.TOWN";
                rdoChange.Visible = true;
                //rdoChange.Checked = false;
            }

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgClientInfo.DataSource = ds;
            dgClientInfo.DataMember = "SourceTable";

            conn.Close();
        }

        private void rdoChange_CheckedChanged_1(object sender, EventArgs e)
        {

            if (cmbTable.SelectedIndex == 0)
            {
                cmbChange.Items.Clear();
                cmbChange.Items.Add("Last Name");
                cmbChange.Items.Add("Telephone Number");
                cmbChange.Items.Add("Email");
                cmbSelectID.Items.Clear();
                cmBox3_DeleteVehicle.Hide();

                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT ClientID FROM dbo.CLIENT";
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
            else if (cmbTable.SelectedIndex == 1)
            {
                cmbChange.Items.Clear();
                cmbSelectID.Items.Clear();
                cmbChange.Items.Add("Street Name");

                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT AddressID FROM dbo.ADDRESS";
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
            else if (cmbTable.SelectedIndex == 2)
            {
                cmbChange.Items.Clear();
                cmbChange.Items.Add("Town Name");
                cmbSelectID.Items.Clear();

                conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "SELECT TownID FROM dbo.TOWN";
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

            if (rdoChange.Checked == true)
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
            
            
            
        }

        private void btnExecute_Click_1(object sender, EventArgs e)
        {
            string sql;
            //-----------------------------------------------------FOR ADDING TO DATABASE---------------------------------------------
            if (rdoAdd.Checked == true) //add functions
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Vehciles
                {
                    frmClientDetails popupClient = new frmClientDetails(); //loads a popup used to input data that is added
                    popupClient.ShowDialog();

                    if (popupClient.addClient == true) //boolean variable used so it doesnt try add nothing to data, which leaves empty spaces in datagridview
                    {
                        try
                        {
                            sql = "";
                            conn.Open();
                            sql = $"INSERT INTO CLIENT(ClientLN, ClientFN, ClientID_Number, Tel_Number, Email, AddressID) VALUES('{popupClient.ClientLN}', '{popupClient.ClientFN}', '{popupClient.ClientID}', '{popupClient.ClientTele}', '{popupClient.ClientEmail}', {popupClient.AddressID})";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New client successfully added");
                        }
                        catch
                        {
                            MessageBox.Show("There was an error adding the new Client");
                            conn.Close();
                        }
                    }
                }
                else if (cmbTable.SelectedIndex == 1)//address
                {
                    whatToInsert = 1;
                    frmTypePopup addresspopup = new frmTypePopup();
                    addresspopup.ShowDialog();

                    if (addresspopup.addAddress == true)
                    {
                        try
                        {
                            conn.Open();
                            sql = $"INSERT INTO ADDRESS(Street_Number, Street_Name, TownID) VALUES ({addresspopup.newNumber},'{addresspopup.newName}',{addresspopup.newTownID})";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New address successfully added");
                        }
                        catch
                        {
                            MessageBox.Show("There was an error adding the new Address");
                            conn.Close();
                        }

 
                    }

                }
                else if (cmbTable.SelectedIndex == 2)//town
                {
                    whatToInsert = 2;
                    frmTypePopup typepopup = new frmTypePopup();
                    typepopup.ShowDialog();

                    if (typepopup.addTown == true)
                    {
                        try
                        {
                            conn.Open();
                            sql = $"INSERT INTO TOWN(Town_Name) VALUES ('{typepopup.newTown}')";
                            adap = new SqlDataAdapter();
                            cmd = new SqlCommand(sql, conn);
                            adap.InsertCommand = cmd;
                            adap.InsertCommand.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("New town successfully added");
                        }
                        catch
                        {
                            MessageBox.Show("There was an error adding the new town");
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a table option above.");
                }

            }
            //-----------------------------------------FOR DELETING FROM THE DATABASE---------------------------------------------------
            else if (rdoDelete.Checked == true) //Delete functions
            {
                if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Clients
                {
                    Delete($"DELETE FROM dbo.CLIENT WHERE ClientID = '{cmBox3_DeleteVehicle.Text}'");
                    rdoDelete.Checked = false;
                }
                else if (cmbTable.SelectedIndex == 1)//address
                {
                    Delete($"DELETE FROM dbo.ADDRESS WHERE AddressID = '{cmBox3_DeleteVehicle.Text}'");
                    rdoDelete.Checked = false;
                }
                else if (cmbTable.SelectedIndex == 2)//town
                {
                    Delete($"DELETE FROM dbo.TOWN WHERE TownID = '{cmBox3_DeleteVehicle.Text}'");
                    rdoDelete.Checked = false;
                }
                else
                {
                    MessageBox.Show("Please select a table option above.");
                }
                cmBox3_DeleteVehicle.Show();
            }
            //-------------------------------------FOR CHANGING ITEMS IN THE DATABASE--------------------------------------------------------------
            else if (rdoChange.Checked == true) //Change functions
            {
                if (cmbChange.SelectedItem != null && cmbSelectID.SelectedItem != null)
                {

                    if (cmbTable.SelectedIndex == 0) //0 shows it will be first option in the combobox. Clients
                    {
                        newToChange = cmbChange.SelectedIndex + 3;
                        frmChangePopup changePopup = new frmChangePopup();
                        changePopup.ShowDialog();

                        //cmbChange.Items.Add("AddressID");
                       
                        if (cmbChange.SelectedIndex == 0) //LastName
                        {

                            if (changePopup.makeChange == true)
                            {
                                try
                                {
                                    conn.Open();
                                    sql = $"UPDATE dbo.CLIENT SET ClientLN = '{changePopup.changeLastName}' WHERE ClientID = {cmbSelectID.SelectedItem}";
                                    adap = new SqlDataAdapter();
                                    cmd = new SqlCommand(sql, conn);
                                    adap.InsertCommand = cmd;
                                    adap.InsertCommand.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Client last name successfully changed");
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error changing the client's last name");
                                    conn.Close();
                                }
                            }
                        }
                        else if (cmbChange.SelectedIndex == 1)//TelNumber
                        {
                            if (changePopup.makeChange == true)
                            {
                                try
                                {
                                    conn.Open();
                                    sql = $"UPDATE dbo.CLIENT SET Tel_Number = '{changePopup.changeTel}' WHERE ClientID = {cmbSelectID.SelectedItem}";
                                    adap = new SqlDataAdapter();
                                    cmd = new SqlCommand(sql, conn);
                                    adap.InsertCommand = cmd;
                                    adap.InsertCommand.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Client telephone number successfully changed!");
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error changing the client's telephone number.");
                                    conn.Close();
                                }
                            }
                        }
                        else if (cmbChange.SelectedIndex == 2)//Email
                        {
                            if (changePopup.makeChange == true)
                            {
                                try
                                {
                                    conn.Open();
                                    sql = $"UPDATE dbo.CLIENT SET Email = '{changePopup.changeEmail}' WHERE ClientID = {cmbSelectID.SelectedItem}";
                                    adap = new SqlDataAdapter();
                                    cmd = new SqlCommand(sql, conn);
                                    adap.InsertCommand = cmd;
                                    adap.InsertCommand.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Client's email successfully Changed");
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error changing the client's email");
                                    conn.Close();
                                }
                            }
                        }
                    }
                    else if (cmbTable.SelectedIndex == 1)//Address
                    {
                        townToChange = cmbChange.SelectedIndex + 2;
                        frmChangePopup changePops = new frmChangePopup();
                        changePops.ShowDialog();

                        if (cmbChange.SelectedIndex == 0) //StreetName
                        {
                            if (changePops.makeChange == true)
                            {
                                try
                                {
                                    conn.Open();
                                    sql = $"UPDATE dbo.ADDRESS SET Street_Name = '{changePops.changeStreetName}' WHERE AddressID = {cmbSelectID.SelectedItem}";
                                    adap = new SqlDataAdapter();
                                    cmd = new SqlCommand(sql, conn);
                                    adap.InsertCommand = cmd;
                                    adap.InsertCommand.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Street name successfully changed");
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error changing the street's name");
                                    conn.Close();
                                }
                            }
                        }
                    }
                    else if (cmbTable.SelectedIndex == 2)//Town
                    {
                        townToChange = cmbChange.SelectedIndex + 1;
                        frmChangePopup changePop = new frmChangePopup();
                        changePop.ShowDialog();
                        
                        
                        //MessageBox.Show(townToChange.ToString());

                        if (cmbChange.SelectedIndex == 0) //TownName
                        {
                            if (changePop.makeChange == true)
                            {
                                try
                                {
                                    conn.Open();
                                    sql = $"UPDATE dbo.TOWN SET Town_Name = '{changePop.changeTownName}' WHERE TownID = {cmbSelectID.SelectedItem}";
                                    adap = new SqlDataAdapter();
                                    cmd = new SqlCommand(sql, conn);
                                    adap.InsertCommand = cmd;
                                    adap.InsertCommand.ExecuteNonQuery();
                                    conn.Close();
                                    MessageBox.Show("Town name successfully changed");
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error changing the town's name");
                                    conn.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an option by data type above");
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure to select which data type you would like to change and the ID of the client");
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
                sql = "SELECT  C.ClientID AS 'Client Number', C.ClientLN AS Surname, C.ClientFN AS Name, C.ClientID_Number AS 'ID Number', C.Tel_Number AS 'Telephone Number', C.Email AS Email, A.Street_Number AS 'Street Number', A.Street_Name AS 'Street Name'  " +
                  "FROM dbo.CLIENT C, dbo.ADDRESS A WHERE C.AddressID = A.AddressID";
                cmd = new SqlCommand(sql, conn);
            }
            else if (cmbTable.SelectedIndex == 1)
            {
                sql = "SELECT AddressID AS 'Address Number', Street_Number AS 'Street Number', Street_Name FROM dbo.ADDRESS";
                cmd = new SqlCommand(sql, conn);
            }
            else if (cmbTable.SelectedIndex == 2)
            {
                sql = "SELECT TownID AS 'Town Number', Town_Name AS 'Town Name' FROM dbo.TOWN";
                cmd = new SqlCommand(sql, conn);
            }

            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgClientInfo.DataSource = ds;
            dgClientInfo.DataMember = "SourceTable";

            conn.Close();
        }
    }
}