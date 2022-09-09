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
    public partial class frmAddress : Form
    {
        private static string connectionStr = "Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(connectionStr);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        string SELECT_ALL_ADDRESS = "SELECT * FROM ADDRESS";

        private void selectAddressQuery(string sql)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataAdapter.SelectCommand = sqlCommand;
                dataSet.Clear();
                sqlDataAdapter.Fill(dataSet, "SourceTable");
                dbViewAddress.DataSource = dataSet;
                dbViewAddress.DataMember = "SourceTable";
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

        private void insertAddressQuery(int townId, int streetNumber, string streetName)
        {
            string query = "INSERT INTO ADDRESS(TownID, Street_Number, Street_Name) VALUES(@TownID, @Street_Number, @Street_Name)";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@TownID", townId);
                sqlCommand.Parameters.Add("@Street_Number", streetNumber);
                sqlCommand.Parameters.Add("@Street_Name", streetName);


                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Address added successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                selectAddressQuery(SELECT_ALL_ADDRESS);
            }
        }

        private void deleteAddressQuery(string addressId)
        {
            string query = "DELETE FROM ADDRESS WHERE AddressID LIKE ' " + addressId + " '";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Address was deleted seccesfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }

            finally
            {
                sqlConnection.Close();
                selectAddressQuery(SELECT_ALL_ADDRESS);
            }

        }

        public frmAddress()
        {
            InitializeComponent();
        }

        private void frmAddress_Load(object sender, EventArgs e)
        {
            selectAddressQuery(SELECT_ALL_ADDRESS);
        }

        private void btnClientAddress_Click(object sender, EventArgs e)
        {
            int townId = 0;// nog kry
            int streetNumber = Int32.Parse(txtbStreetNumber.Text);
            string streetName = txtbStreetName.Text;

            insertAddressQuery(townId, streetNumber, streetName);

            txtbStreetNumber.Clear();
            txtbStreetName.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteAddressQuery(SELECT_ALL_ADDRESS);
        }
    }
}
