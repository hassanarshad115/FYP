using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class Show_Students_RecordForm : Form
    {
        public Show_Students_RecordForm()
        {
            InitializeComponent();
        }

        private void Show_Students_RecordForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = GetInformation();
            
        }

        private DataTable GetInformation()
        {
            DataTable dt = new DataTable();

            string connectionstring = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("sp_showStudentRecord", conn);
            adapter.Fill(dt);

            return dt;
        }
    }
}
