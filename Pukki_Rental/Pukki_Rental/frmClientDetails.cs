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
        

        public frmClientDetails()
        {
            InitializeComponent();
        }

        private void frmClientDetails_Load(object sender, EventArgs e)
        {
           
        }
    }
}
