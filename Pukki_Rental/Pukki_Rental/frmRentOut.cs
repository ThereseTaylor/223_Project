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
    public partial class frmRentOut : Form
    {
        public frmRentOut()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;


        private void frmRentOut_Load(object sender, EventArgs e)
        {
            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            sql = "SELECT ClientLN, ClientFN, ClientID_Number, Tel_Number, Email, Street_Number, Street_Name " +
                  "FROM dbo.CLIENT C, dbo.ADDRESS A WHERE C.AddressID = A.AddressID ";
            
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgRentOut.DataSource = ds;
            dgRentOut.DataMember = "SourceTable";

            conn.Close();

            cmbxType.Hide();
            dgVehicle.Hide();
            label4.Text = "";
            dateTimePicker1.Hide();
            button1.Hide();
        }

        int clientID;
        int carID;
        string rentalR;

        private void dgRentOut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string clientPrompt = dgRentOut.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dgRentOut.Rows[e.RowIndex].Cells[1].Value.ToString() + " ID: " + dgRentOut.Rows[e.RowIndex].Cells[3].Value.ToString();
            string sql = "";

            Boolean myflag = false;

            string title = "Are you sure " + clientPrompt + " is the correct client?";

            DialogResult dialogResult = MessageBox.Show(title, "CLIENT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                conn.Open();
                string idNo = dgRentOut.Rows[e.RowIndex].Cells[2].Value.ToString();
                sql = "SELECT ClientID FROM dbo.CLIENT WHERE ClientID_Number = " + idNo;
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clientID = (int)reader.GetValue(0);
                }

                conn.Close();

                conn.Open();
                sql = "SELECT C.ClientID FROM dbo.RENTAL_TRANSACTION R, dbo.CLIENT C, dbo.VEHICLE V WHERE C.ClientID = R.ClientID AND R.VehicleID = V.VehicleID AND V.Rental_Status = 0";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if ((int)reader.GetValue(0) == clientID)
                    {
                        MessageBox.Show("This client is curently renting a car, they cannot rent another one.", "CLIENT", MessageBoxButtons.OK);
                        myflag = true;
                        break;
                    }
                }

                conn.Close();

                if (!myflag)
                {
                    dgRentOut.DataSource = null;
                    dgRentOut.Hide();
                    textBox1.Hide();

                    label5.Text = "Double click on the vehicle the client wants to rent:";
                    label1.Text = "Choose the clients preferred vehicle type:";

                    cmbxType.Show();
                    conn.Open();
                    sql = "SELECT Type_Description FROM dbo.VEHICLE_TYPE";
                    cmd = new SqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbxType.Items.Add(reader.GetValue(0));
                    }

                    conn.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Then please choose the correct client.", "CLIENT", MessageBoxButtons.OK);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgVehicle.Show();
            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            sql = "SELECT DISTINCT Model_Description, Type_Description, Colour_Name, Registration_Plate, Rental_Price " +
                "FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M, dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C, dbo.RENTAL_TRANSACTION R " +
                "WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID AND V.Rental_Status = 1";

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgVehicle.DataSource = ds;
            dgVehicle.DataMember = "SourceTable";

            conn.Close();
        }

        private void dgVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string carPrompt = dgVehicle.Rows[e.RowIndex].Cells[0].Value.ToString() + " " + dgVehicle.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dgVehicle.Rows[e.RowIndex].Cells[1].Value.ToString() + " Registration Plate: " + dgVehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
            string car = "Are you sure " + carPrompt + " is the correct vehicle?";
            
            DialogResult Result = MessageBox.Show(car, "VEHICLE", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                conn.Open();
                string regPlate = dgVehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
                string sql = "SELECT VehicleID, Rental_Price FROM dbo.VEHICLE WHERE Registration_Plate = '"+ regPlate +"'" ;
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    carID = (int)reader.GetValue(0);
                    rentalR = reader.GetValue(1).ToString();
                }

                conn.Close();

                label4.Text = "How long will the client be renting the vehicle?";
                dateTimePicker1.Show();
                button1.Show();
                
            }
            else if (Result == DialogResult.No)
            {
                MessageBox.Show("Then please choose the correct vehicle.", "VEHICLE", MessageBoxButtons.OK);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (dateTimePicker1.Value >= DateTime.Today)
            {
                String ReturnDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                int days = (Convert.ToDateTime(ReturnDate) - today).Days;

                if (days == 0)
                {
                    days = 1;
                }
                double transactPrice = Convert.ToDouble(rentalR) * days;

                string messageDays = "This will be " + days.ToString() + "days in total. The total for this period is R" + transactPrice.ToString() + ". Does the client agree to this?";

                DialogResult dialogResult = MessageBox.Show(messageDays, "RENTAL", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string sql = $"INSERT INTO dbo.RENTAL_TRANSACTION (VehicleID, ClientID, Transaction_Price, Transaction_Date, Return_Date) VALUES ({carID},{clientID},{transactPrice},'{today}','{ReturnDate}')";
                        adap = new SqlDataAdapter();
                        cmd = new SqlCommand(sql, conn);
                        adap.InsertCommand = cmd;
                        adap.InsertCommand.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("The rental purchase is finalised!", "RENTAL", MessageBoxButtons.OK);

                        conn.Open();
                        sql = "UPDATE dbo.VEHICLE SET Rental_Status = 0 WHERE VehicleID = '" + carID + "'";
                        adap = new SqlDataAdapter();
                        cmd = new SqlCommand(sql, conn);
                        adap.UpdateCommand = cmd;
                        adap.UpdateCommand.ExecuteNonQuery();
                        conn.Close();

                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Then please choose the correct date.", "RENTAL", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please choose a date in the future.", "DATE", MessageBoxButtons.OK);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "";

            conn.Open();
            ds = new DataSet();
            adap = new SqlDataAdapter();
            sql = "SELECT ClientLN, ClientFN, ClientID_Number, Tel_Number, Email, Street_Number, Street_Name " +
                  "FROM dbo.CLIENT C, dbo.ADDRESS A WHERE C.AddressID = A.AddressID AND UPPER(C.ClientFN) LIKE UPPER('%" + textBox1.Text + "%') ";
            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgRentOut.DataSource = ds;
            dgRentOut.DataMember = "SourceTable";
            conn.Close();
        }
    }
}
