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
    public partial class frmReceiveBack : Form
    {
        public frmReceiveBack()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=LAPTOP-8IITND7R;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader reader;

        private void frmReceiveBack_Load(object sender, EventArgs e)
        {
            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            sql = "SELECT ClientLN, Registration_Plate FROM dbo.RENTAL_TRANSACTION r, dbo.CLIENT c, dbo.VEHICLE v WHERE Return_Status = 'N' AND r.ClientID = c.ClientID AND r.VehicleID = v.VehicleID ";

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgReceiveBack.DataSource = ds;
            dgReceiveBack.DataMember = "SourceTable";

            conn.Close();
        }

        private void dgReceiveBack_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int carID = 0;
            int transactionID = 0;
            DialogResult Result = MessageBox.Show("", "RETURN", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                conn.Open();
                string regPlate = dgReceiveBack.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sql = "SELECT VehicleID FROM dbo.VEHICLE WHERE Registration_Plate = '" + regPlate + "'";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    carID = (int)reader.GetValue(0);
                }
                conn.Close();


                conn.Open();
                sql = "SELECT TransactionID FROM dbo.RENTAL_TRANSACTION WHERE VehicleID = '" + carID + "' AND Return_Status = 'N' ";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    transactionID = (int)reader.GetValue(0);
                }
                conn.Close();

                conn.Open();
                sql = "UPDATE dbo.RENTAL_TRANSACTION SET Return_Status = 'Y' WHERE TransactionID = '" + transactionID + "'";
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                adap.UpdateCommand = cmd;
                adap.UpdateCommand.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Return successfully proccessed!", "RETURN", MessageBoxButtons.OK);
            }
            else if (Result == DialogResult.No)
            {
                MessageBox.Show("Then please choose the correct one.", "RETURN", MessageBoxButtons.OK);
            }
        }
    }
}
