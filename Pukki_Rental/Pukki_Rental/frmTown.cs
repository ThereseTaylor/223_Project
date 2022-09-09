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
    public partial class frmTown : Form
    {
        private static string connectionStr = "Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(connectionStr);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        SqlDataReader reader;
        string SELECT_ALL_TOWN = "SELECT * FROM TOWN";

        private void selectTownQuery(string sql)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlDataAdapter.SelectCommand = sqlCommand;
                dataSet.Clear();
                sqlDataAdapter.Fill(dataSet, "SourceTable");
                dbViewTown.DataSource = dataSet;
                dbViewTown.DataMember = "SourceTable";
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

        private void insertTownQuery(string Town_Name)
        {
            string query = "INSERT INTO TOWN(Town_Name) VALUES(@Town_Name)";
            MessageBox.Show(Town_Name);
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Town_Name", Town_Name);
                

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Town added successfuly");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                selectTownQuery(SELECT_ALL_TOWN);
            }
        }

        private void deleteTownQuery(string TownID)
        {
            string query = "DELETE FROM TOWN WHERE TownID LIKE ' " + TownID  + " '";
            
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Town was deleted seccesfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }

            finally
            {
                sqlConnection.Close();
                selectTownQuery(SELECT_ALL_TOWN);
            }

        }

        public frmTown()
        {
            InitializeComponent();
        }

        private void frmTown_Load(object sender, EventArgs e)
        {
            selectTownQuery(SELECT_ALL_TOWN);
        }

        public int Town_ID;
        private void btnClientTown_Click(object sender, EventArgs e)
        {
            string Town_Name = txtbTownName.Text;
            sqlConnection.Open();
            string sql = "SELECT TownID FROM dbo.TOWN WHERE Town_Name= '" + Town_Name + "'";
            sqlCommand = new SqlCommand(sql, sqlConnection);
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                Town_ID = (int)reader.GetValue(0);
            }

            sqlConnection.Close();

            insertTownQuery(Town_Name);
            txtbTownName.Clear();
        }

        private void btnDeleteTown_Click(object sender, EventArgs e)
        {
            deleteTownQuery(SELECT_ALL_TOWN);
        }
    }
}
