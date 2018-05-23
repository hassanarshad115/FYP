using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace FYP
{
    public partial class rForm : Form
    {
        ReportDocument cry = new ReportDocument();

        public rForm()
        {
            InitializeComponent();
        }

        private void rForm_Load(object sender, EventArgs e)
        {
            //cry.Load("C:\\Users\\HASSAN MALIK\\Desktop\\NewlatestFypMra\\FYP\\CR.rpt");

            //SqlDataAdapter cmd = new SqlDataAdapter("if not exists(select * from [dbo].[" + textBox1.Text.Trim() + "])  ", conn);

            //cry.Load("..\\..\\CR.rpt");
            //SqlDataAdapter cmd = new SqlDataAdapter("select * from login  ", conn);

            ////cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //cmd.Fill(ds, "DATAS");
            //cry.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = cry;
        }
        SqlConnection conn = new SqlConnection(ConfigurationClass.ConfigurationMethod());

        DataSet dst = new DataSet();
        SqlCommand cm;
        private void button1_Click(object sender, EventArgs e)
        {
            // cm = new SqlCommand("IF EXISTS (SELECT * FROM [dbo].login  ) begin",conn);
            //SqlDataAdapter ad = new SqlDataAdapter(cm);
            //ad.Fill(dst);

            //int i = dst.Tables[0].Rows.Count;
            //if (i > 0)
            //{

            cry.Load("..\\..\\CR.rpt");
            //SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[" + textBox1.Text.Trim() + "]", conn);
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[login]", conn);

            DataSet ds = new DataSet();
            cmd.Fill(ds, "DATAS");
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;



            //}
            //else
            //{
            //    MessageBox.Show("Table is not Exists in Database");
            //}
            //cm = new SqlCommand("end", conn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cry.Load("..\\..\\CR2.rpt");
            //SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[" + textBox1.Text.Trim() + "]", conn);
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [dbo].[Mcs91_21SI]", conn);

            DataSet ds = new DataSet();
            cmd.Fill(ds, "D");
            cry.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
