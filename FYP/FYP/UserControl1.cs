using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Excel;

namespace FYP
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        int rs; // rs yha lia ha
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            SqlCommand cmd;
            sessiongroupBox1.Visible = false;
            newsemestergroupBox1.Visible = true;

            if (springradioButton1.Checked == true)//for spring
            {

                string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "S" + "([RollNo] INT NOT NULL,[RegNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL )";
                cmd = new SqlCommand(q, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                toplabel6.Text = sessionmaskedTextBox1.Text + "S";//yha concatinate kia h session ko 
                MessageBox.Show("successfully create table");


            }
            if (fallradioButton2.Checked == true)
            {

                string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "F" + "([RollNo] INT NOT NULL,[RegNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL )";
                cmd = new SqlCommand(q, conn);

                conn.Open();
                //string a = sessionmaskedTextBox1.Text + "F";
                //insertValueMethod(a);
                cmd.ExecuteNonQuery();
                conn.Close();


            }
        }





        private void newsemsterbutton1_Click(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = false;
            newsemestergroupBox1.Visible = false;
        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            string connection = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connection);

            string q = "INSERT INTO [dbo]." + toplabel6.Text + "([RollNo],[RegNo],[Name],[FatherName]) VALUES( @r,@ad,@n,@f)";
            SqlCommand cmd1 = new SqlCommand(q, conn);
            //cmd1.Parameters.AddWithValue("@r", rollnotextBox1.Text);
            //cmd1.Parameters.AddWithValue("@ad", regnotextBox2.Text);
            //cmd1.Parameters.AddWithValue("@n", nametextBox3.Text);
            //cmd1.Parameters.AddWithValue("@f", fathernametextBox4.Text);
            conn.Open();
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Table Data Enter Successfully");
            txtBoxClearMethod();
        }
        private void txtBoxClearMethod()
        {
            //regnotextBox2.Clear();
            //nametextBox3.Clear();
            //fathernametextBox4.Clear();
        }
        DataSet res;
        private void chosefilebutton2_Click(object sender, EventArgs e)
        {
            //Subject 1
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook |*.xls;*.xlsx;*.XLS;*.SLSX", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    res = reader.AsDataSet();
                    sheetcomboBox1.Items.Clear();
                    foreach (DataTable dt in res.Tables)
                    {
                        sheetcomboBox1.Items.Add(dt.TableName);
                        reader.Close();
                    }
                }
            }
        }

        private void sheetcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = res.Tables[sheetcomboBox1.SelectedIndex];

            //dataGridView1.Columns.Add("newColumnName", "CGPA");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //marks = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
                //GPACall();
                dataGridView1.Rows[i].Cells[3].Value = a;
            }
            dataGridView1.Refresh();
        }
        //int marks;
        //double gpa;
        string a;
        int r;
        private void insertbutton2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb"].ConnectionString);
            SqlCommand cmd;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegNo],[Name],[FatherName])VALUES('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "')", conn);
                conn.Open();
                r = cm.ExecuteNonQuery();
                conn.Close();

            }
            MessageBox.Show("insert data successfully");
        }
    }
}
