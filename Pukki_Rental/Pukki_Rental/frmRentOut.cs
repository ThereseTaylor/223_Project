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
            label3.Text = "";
            dgVehicle.Hide();
            label4.Text = "";
        }

        int clientID;
        int carID;
        string rentalR;

        private void dgRentOut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string clientPrompt = dgRentOut.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dgRentOut.Rows[e.RowIndex].Cells[1].Value.ToString() + " ID: " + dgRentOut.Rows[e.RowIndex].Cells[3].Value.ToString();
            string sql = "";

            conn.Open();
            sql = "SELECT ClientID, Return_Status " +
                "FROM dbo.RENTAL_TRANSACTION " +
                "WHERE Return_Status = 'N' OR Return_Status = 'O' ";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            Boolean myflag = false;

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() == clientID.ToString())
                {
                    DialogResult dialog = MessageBox.Show("This client is currently renting another car.", "CLIENT", MessageBoxButtons.OK);
                    myflag = true;
                }
            }

            conn.Close();

            if (!myflag)
            {
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

                    dgRentOut.DataSource = null;
                    dgRentOut.Hide();

                    label1.Text = "Double click on the vehicle the client wants to rent:";
                    label3.Text = "Choose the clients preferred vehicle type:";

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
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Then please choose the correct client.", "CLIENT", MessageBoxButtons.OK);
                }

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

            sql = "SELECT Model_Description, Type_Description, Colour_Name, Registration_Plate, Rental_Price " +
                "FROM dbo.VEHICLE V, dbo.VEHICLE_MODEL M, dbo.VEHICLE_TYPE T, dbo.VEHICLE_COLOUR C " +
                "WHERE V.ModelID = M.ModelID AND V.TypeID = T.TypeID AND V.ColourID = C.ColourID AND Rental_Status = 0";

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
                MessageBox.Show("Thank you.", "VEHICLE", MessageBoxButtons.OK);
                conn.Close();

                label4.Text = "How long will the client be renting the vehicle?";
                DateTime today = DateTime.Today;

                try
                {
                    conn.Open();
                    sql = $"INSERT INTO dbo.RENTAL_TRANSACTION (VehicleID, ClientID, Transaction_Price, Transaction_Date, Return_Status) VALUES ({carID},{clientID},{rentalR},'{today}','{"N"}')";
                    adap.InsertCommand = cmd;
                    adap.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception message)
                {
                    MessageBox.Show(message.ToString());
                }
                
            }
            else if (Result == DialogResult.No)
            {
                MessageBox.Show("Then please choose the correct vehicle.", "VEHICLE", MessageBoxButtons.OK);
            }

        }
    }
}
