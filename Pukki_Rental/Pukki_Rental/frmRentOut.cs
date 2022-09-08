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

        string conStr = @"Data Source=LAPTOP-ON3GIIKN\SQLEXPRESS;Initial Catalog=dbPUKKI_RENTAL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet ds;


        private void frmRentOut_Load(object sender, EventArgs e)
        {
            string sql = "";

            conn = new SqlConnection(conStr);
            conn.Open();

            ds = new DataSet();
            adap = new SqlDataAdapter();

            sql = "SELECT * FROM dbo.VEHICLE";

            cmd = new SqlCommand(sql, conn);
            adap.SelectCommand = cmd;
            adap.Fill(ds, "SourceTable");

            dgRentOut.DataSource = ds;
            dgRentOut.DataMember = "SourceTable";

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
