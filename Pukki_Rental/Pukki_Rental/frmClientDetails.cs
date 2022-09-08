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
    public partial class frmClientDetails : Form
    {
        private static string connectionStr = "Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(connectionStr);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        string SELECT_ALL_CLIENT = "SELECT * FROM CLIENT";

        private void selectClientQuery(string sql)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataAdapter.SelectCommand = sqlCommand;
                dataSet.Clear();
                sqlDataAdapter.Fill(dataSet, "SourceTable");
                dbViewClient.DataSource = dataSet;
                dbViewClient.DataMember = "SourceTable";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void insertClientQuery(string ClientLN, string ClientFN, int ClientID_Number, int Tel_Number, string Email, int AddressID)
        {
            string query = "INSERT INTO Client(ClientLN, ClientFN, ClientID_Number, Tel_Number, Email, AddressID) VALUES(@ClientLN, @ClientFN, @ClientID_Number, @Tel_Number, @Email, @AddressID)";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ClientLN", ClientLN);
                sqlCommand.Parameters.Add("@ClientFN", ClientFN);
                sqlCommand.Parameters.Add("@ClientID_Number", ClientID_Number);
                sqlCommand.Parameters.Add("@Tel_Number", Tel_Number);
                sqlCommand.Parameters.Add("@Email", Email);
                sqlCommand.Parameters.Add("@AddressID", AddressID);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Client added successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                selectClientQuery(SELECT_ALL_CLIENT);
            }
        }

        private void deleteClientQuery(string ClientID)
        {
            string query = "DELETE FROM CLIENT WHERE ClientID LIKE ' " + ClientID + " '";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Client was deleted seccesfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }

            finally
            {
                sqlConnection.Close();
                selectClientQuery(SELECT_ALL_CLIENT);
            }

        }

        public frmClientDetails()
        {
            InitializeComponent();
        }

        private void frmClientDetails_Load(object sender, EventArgs e)
        {
            selectClientQuery(SELECT_ALL_CLIENT);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            string ClientLN = txtbLastName.Text;
            string ClientFN = txtbFirstName.Text;
            int ClientID_Number = Int32.Parse(txtbClientIDNumber.Text);
            int Tel_Number = Int32.Parse(txtbClientTelNumber.Text);
            string Email = txtbEmail.Text;
            int AddressID = Int32.Parse(txtbAddressID.Text);

            insertClientQuery(ClientLN, ClientFN, ClientID_Number, Tel_Number, Email, AddressID);

            txtbClientIDNumber.Clear();
            txtbLastName.Clear();
            txtbFirstName.Clear();
            txtbClientIDNumber.Clear();
            txtbClientTelNumber.Clear();
            txtbEmail.Clear();
            txtbAddressID.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteClientQuery(SELECT_ALL_CLIENT);
        }
    }
}
