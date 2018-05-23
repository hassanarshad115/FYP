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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm lf = new loginForm();
            lf.Show();
        }
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select * from login where NicNo= '" + nicMaskedTextBox1.Text + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("card h ");
                this.Close();
                loginForm lf = new loginForm();
                lf.Show();
            }
            else
            {
                MessageBox.Show(nicMaskedTextBox1.Text + "  NicNo is Not Exists.\nPlease Enter Correct NicNo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nicMaskedTextBox1.Clear();
                nicMaskedTextBox1.Focus();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
