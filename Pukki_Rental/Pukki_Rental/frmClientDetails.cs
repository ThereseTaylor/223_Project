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
        SqlDataReader reader;

        public string ClientFN, ClientLN, ClientID, ClientTele, ClientEmail;
        public bool addClient = false;
        public int AddressID;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public frmClientDetails()
        {
            InitializeComponent();
        }

        private void frmClientDetails_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionStr);
            sqlConnection.Open();
            string sql = "SELECT Street_Name FROM dbo.ADDRESS";
            dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                cmbStrName.Items.Add(reader.GetString(0));
            }
            sqlConnection.Close();


            sqlConnection = new SqlConnection(connectionStr);
            sqlConnection.Open();
            sql = "SELECT Street_Number FROM dbo.ADDRESS";
            dataSet = new DataSet();
            sqlDataAdapter = new SqlDataAdapter();
            sqlCommand = new SqlCommand(sql, sqlConnection);
            reader = sqlCommand.ExecuteReader();
            
            while (reader.Read())
            {
                cmbStrNum.Items.Add(reader.GetString(0));
            }
            sqlConnection.Close();
        }

        Boolean flag = false;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtFName.Text == "" || txtIDNum.Text == "" || txtLName.Text == "" || txtTelNum.Text == "" || cmbStrName.SelectedItem == null || cmbStrNum.SelectedItem == null)
            {
                MessageBox.Show("Please ensure to fill out the form correctly");
            }
            else
            {

                ClientEmail = txtEmail.Text;
                ClientFN = txtFName.Text;
                ClientID = txtIDNum.Text;
                ClientLN = txtLName.Text;
                ClientTele = txtTelNum.Text;
                try
                {
                    bool hbool = false;
                    bool gbool = false;

                    if (txtLName.Text.Any(char.IsDigit) == true)
                    {
                        MessageBox.Show("Please enter a valid Last Name.");
                        gbool = false;
                    }
                    else if (txtFName.Text.Any(char.IsDigit) == true)
                    {
                        MessageBox.Show("Please enter a valid First Name.");
                        gbool = false;
                    }
                    else
                    {
                        gbool = true;
                    }


                    if (ClientID.Length != 13)
                    {
                        MessageBox.Show("Please enter a valid ID.");
                        hbool = false;
                    }
                    else if (ClientTele.Length != 10)
                    {
                        MessageBox.Show("Please enter a valid Telephone number.");
                        hbool = false;
                    }
                    else
                    {
                        try
                        {
                            int clientnum = int.Parse(ClientID);
                            int clientel = int.Parse(ClientTele);
                            hbool = true;
                        }
                        catch
                        {
                            MessageBox.Show("Please enter a 13 digit ID number and a 10 digit telephone number.");
                            hbool = false;
                        }
                    }

                    if (hbool && gbool)
                    {
                        string streetName = cmbStrName.GetItemText(cmbStrName.SelectedItem);
                        string streetNum = cmbStrNum.GetItemText(cmbStrNum.SelectedItem);
                        sqlConnection.Open();
                        string sql = "SELECT AddressID, Street_Name, Street_Number FROM dbo.ADDRESS";
                        sqlCommand = new SqlCommand(sql, sqlConnection);
                        reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetValue(2).ToString());
                            if ((reader.GetValue(1).ToString() == streetName) && (reader.GetValue(2).ToString() == streetNum))
                            {
                                MessageBox.Show("in");
                                AddressID = (int)reader.GetValue(0);
                                flag = true;
                                break;
                            }
                        }

                        sqlConnection.Close();

                        if (flag == false)
                        {
                            MessageBox.Show("Please enter a valid address.", "RETURN", MessageBoxButtons.OK);
                        }
                        else
                        {
                            addClient = true;
                            this.Close();
                        }
                    }

                }
                catch
                {

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
