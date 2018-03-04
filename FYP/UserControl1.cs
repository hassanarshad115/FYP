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
        /// <summary>
        /// We Make Multiple array for 1 to 4 Semester of Mcs 
        /// and in all array we put the name of Subjects and all array are used in bellow where 
        /// need for combobox for select an subject of smemster
        /// </summary>


        public static string[] M1 = new string[6] { "Programming Fundamental", "Digital Logic Design", "Database System", "Operating System", "English", "Islamic Studies" };
        public static string[] M2 = new string[6] { "Data Structures and Algorithms", "Data Communication & Networking ", "Web Programming", "Object Oriented Programming", "Distribute Database System", "Software Engineering - I" };
        public static string[] M3 = new string[6] { "Visual Programming ", "Computer Graphics", "Software Engineering - II", "Theory of Automata Theory and Formal Languages", "Elective-I", "Project-I" };
        public static string[] M4 = new string[7] { "Artificial Intelligence", "Computer Architecture and Assembly Language", "Compiler Construction", "Anslysis of Algorithm", "Elective-II", "Elective-III", "Project-II" };



        //global connection with MySql is creating
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-C78EE50;Initial Catalog=FYPDB;Integrated Security=True");
        int rs; // rs yha lia ha
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd;


            if (springradioButton1.Checked == true)//for spring
            {
                if (session1comboBox1.SelectedIndex.ToString() == "0")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "SI";//yha concatinate kia h session ko 
                    //toplabellabel7.Text = "First Semester";
                    newsemestergroupBox1.Visible = true;
                    newSemesterAfterFirstbutton5.Visible = false;
                    newsemesterchosefilebutton2.Visible = true;
                    newsemestersheetcomboBox1.Visible = true;
                    insertbutton2.Visible = true;
                    MessageBox.Show("successfully create table");
                }
                if (session1comboBox1.SelectedIndex.ToString() == "1")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "SII";//yha concatinate kia h session ko 
                    string d = sessionmaskedTextBox1.Text + "SI";
                    //toplabellabel7.Text = d;


                    newsemesterdataGridView1.DataSource = GetData(d);//previus table ka data show krny k lye
                    newsemestergroupBox1.Visible = true;
                    newSemesterAfterFirstbutton5.Visible = true;
                    newsemesterchosefilebutton2.Visible = false;
                    newsemestersheetcomboBox1.Visible = false;
                    insertbutton2.Visible = false;

                    MessageBox.Show("successfully create table");
                }
                if (session1comboBox1.SelectedIndex.ToString() == "2")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "SIII";//yha concatinate kia h session ko 
                    string d = sessionmaskedTextBox1.Text + "SII";

                    newsemesterchosefilebutton2.Visible = false;
                    newsemestersheetcomboBox1.Visible = false;
                    insertbutton2.Visible = false;

                    newsemesterdataGridView1.DataSource = GetData(d);//previus table ka data show krny k lye
                    MessageBox.Show("successfully create table");
                    newSemesterAfterFirstbutton5.Visible = true;

                }
                if (session1comboBox1.SelectedIndex.ToString() == "3")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SIV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "SIV";//yha concatinate kia h session ko 
                    string d = sessionmaskedTextBox1.Text + "SIII";

                    newsemesterchosefilebutton2.Visible = false;
                    newsemestersheetcomboBox1.Visible = false;
                    insertbutton2.Visible = false;

                    newsemesterdataGridView1.DataSource = GetData(d);//previus table ka data show krny k lye
                    MessageBox.Show("successfully create table");
                    newSemesterAfterFirstbutton5.Visible = true;
                }
            }
            //now create table for Fall Students
            if (fallradioButton2.Checked == true)
            {
                if (session1comboBox1.SelectedIndex.ToString() == "0")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "FI";//yha concatinate kia h session ko 
                    //toplabellabel7.Text = "First Semester";
                    MessageBox.Show("successfully create table");
                    newSemesterAfterFirstbutton5.Visible = false;
                }
                if (session1comboBox1.SelectedIndex.ToString() == "1")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "FII";//yha concatinate kia h session ko 
                    string d = sessionmaskedTextBox1.Text + "FI";

                    newsemesterchosefilebutton2.Visible = false;
                    newsemestersheetcomboBox1.Visible = false;
                    insertbutton2.Visible = false;

                    newsemesterdataGridView1.DataSource = GetData(d);//previus table ka data show krny k lye
                    MessageBox.Show("successfully create table");
                    newSemesterAfterFirstbutton5.Visible = true;

                }
                if (session1comboBox1.SelectedIndex.ToString() == "2")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "FIII";//yha concatinate kia h session ko 
                    string d = sessionmaskedTextBox1.Text + "FII";

                    newsemesterchosefilebutton2.Visible = false;
                    newsemestersheetcomboBox1.Visible = false;
                    insertbutton2.Visible = false;

                    newsemesterdataGridView1.DataSource = GetData(d);//previus table ka data show krny k lye
                    MessageBox.Show("successfully create table");
                    newSemesterAfterFirstbutton5.Visible = true;
                }
                if (session1comboBox1.SelectedIndex.ToString() == "3")
                {
                    string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FIV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                    cmd = new SqlCommand(q, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    toplabel6.Text = sessionmaskedTextBox1.Text + "FIV";//yha concatinate kia h session ko 
                    string d = sessionmaskedTextBox1.Text + "FIII";

                    newsemesterchosefilebutton2.Visible = false;
                    newsemestersheetcomboBox1.Visible = false;
                    insertbutton2.Visible = false;

                    newsemesterdataGridView1.DataSource = GetData(d);//previus table ka data show krny k lye
                    MessageBox.Show("successfully create table");
                    newSemesterAfterFirstbutton5.Visible = true;
                }

            }
        }

        //METHOD FOR SHOW PREVIOUS TABLE STUDENTS RECORDS IN DATAGRIDVIEW
        private DataTable GetData(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] ,[RegdNo],[Name],[FatherName],[TQP1],[TM1] from [dbo]." + o + " ", conn);
            adapter.Fill(dt);
            return dt;
        }

        private void newsemsterbutton1_Click(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            sessiongroupBox1.Visible = false;
            newsemestergroupBox1.Visible = false;
            resultgroupBox1.Visible = false;
            afteResultgroupBox1.Visible = false;

        }

        private DataTable GetDataGrade(string V)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [COPM] from" + V, conn);
            adapter.Fill(dt);
            return dt;
        }
        private DataTable GetDataGS(string V)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select  from" + V, conn);
            adapter.Fill(dt);
            return dt;
        }

        DataSet res = new DataSet();
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
                    newsemestersheetcomboBox1.Items.Clear();
                    foreach (DataTable dt in res.Tables)
                    {
                        newsemestersheetcomboBox1.Items.Add(dt.TableName);
                        reader.Close();
                    }
                }
            }
        }
        //string a;
        private void sheetcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newsemesterdataGridView1.DataSource = res.Tables[newsemestersheetcomboBox1.SelectedIndex];

            //dataGridView1.Columns.Add("newColumnName", "CGPA");

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    //marks = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value);
            //    //GPACall();
            //    dataGridView1.Rows[i].Cells[3].Value = a;
            //}
            //dataGridView1.Refresh();
        }
        //int marks;
        //double gpa;

        int r;
        private void insertbutton2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < newsemesterdataGridView1.Rows.Count; i++)
            {

                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + "')", conn);

                //SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[TQP1],[TM1])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                conn.Open();
                r = cm.ExecuteNonQuery();
                conn.Close();

            }
            MessageBox.Show("insert data successfully");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            semeterCountLoad();
        }

        private void semeterCountLoad()
        {

            yoursemestercomboBox2.Items.Clear();
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "0")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(M1[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(M2[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "2")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(M3[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "3")
            {
                for (int i = 0; i < 7; i++)
                {
                    yoursemestercomboBox2.Items.Add(M4[i]);
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (resultspringradioButton2.Checked == true)
            {
                ShowDataOnLabelInResultGroupbox();//for spring

            }
            if (resultfallradioButton1.Checked == true)
            {
                ShowDataOnLabelInResultGroupBoxfOrFall();

            }


        }

        private void ShowDataOnLabelInResultGroupBoxfOrFall()
        {
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "1")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FI";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "2")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FII";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "3")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FIII";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "4")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FIV";
            }
            topAfterResultlabel2.Text = "[" + yoursemestercomboBox2.Text + "]";
        }

        private void ShowDataOnLabelInResultGroupbox()
        {
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "1")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SI";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "2")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SII";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "3")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SIII";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "4")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SIV";
            }
            topAfterResultlabel2.Text = "[" + yoursemestercomboBox2.Text + "]";
        }

        private void afterResultChoseFilebutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel 97-2003 WorkBook|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    //if (ofd.FilterIndex == 1)
                    reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    //else
                    //    reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    res = reader.AsDataSet();
                    afterResultcomboBox.Items.Clear();
                    foreach (DataTable dt in res.Tables)
                    {
                        afterResultcomboBox.Items.Add(dt.TableName);
                        reader.Close();
                    }
                }
            }
        }

        private void afterResultcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            afterResultdataGridView2.DataSource = res.Tables[afterResultcomboBox.SelectedIndex];
        }

        private void resultbutton2_Click(object sender, EventArgs e)
        {
            resultgroupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            for (int i = 0; i < afterResultdataGridView2.Rows.Count; i++)
            {
                conn.Open();
                cmd = new SqlCommand(@"UPDATE " + topAfterResultlabel1.Text + " Set " + topAfterResultlabel2.Text + "='" + afterResultdataGridView2.Rows[i].Cells[5].Value + "' WHERE RollNo = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                //YHA quality points wala colum ko pic krna pryga
                rs = cmd.ExecuteNonQuery();
                conn.Close();

            }
            MessageBox.Show("successfully");
        }

        private void afteResultgroupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlCommand cmd;
        private void button4_Click(object sender, EventArgs e)
        {


            conn.Open();




            conn.Close();
            MessageBox.Show("successfully");
        }

        private void GetGrade(string valueOfMaskTextBox)
        {

            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + "set [GRADE]= 'A+' where [COPM]<= 100 AND [COPM] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update" + valueOfMaskTextBox + " set [GRADE]= 'A' where [COPM]< 95 AND [COPM] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE]= 'B+' WHERE [COPM]< 85 AND [COPM] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE]= 'B' where [COPM]< 80 AND [COPM] >=70 ", conn);
            cmd.ExecuteNonQuery();
        }
        private void GetGrade1(string valueOfMaskTextBox)
        {

            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + "set [GRADE2]= 'A+' where [COPM2]<= 100 AND [COPM2] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update" + valueOfMaskTextBox + " set [GRADE2]= 'A' where [COPM2]< 95 AND [COPM2] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE2]= 'B+' WHERE [COPM2]< 85 AND [COPM2] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE2]= 'B' where [COPM2]< 80 AND [COPM2] >=70 ", conn);
            cmd.ExecuteNonQuery();
        }
        private void GetGrade2(string valueOfMaskTextBox)
        {

            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + "set [GRADE3]= 'A+' where [COPM3]<= 100 AND [COPM3] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update" + valueOfMaskTextBox + " set [GRADE3]= 'A' where [COPM3]< 95 AND [COPM3] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE3]= 'B+' WHERE [COPM3]< 85 AND [COPM3] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE3]= 'B' where [COPM3]< 80 AND [COPM3] >=70 ", conn);
            cmd.ExecuteNonQuery();
        }
        private void GetGrade3(string valueOfMaskTextBox)
        {

            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + "set [GRADE4]= 'A+' where [COPM4]<= 100 AND [COPM4] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update" + valueOfMaskTextBox + " set [GRADE4]= 'A' where [COPM4]< 95 AND [COPM4] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE4]= 'B+' WHERE [COPM4]< 85 AND [COPM4] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE4]= 'B' where [COPM4]< 80 AND [COPM4] >=70 ", conn);
            cmd.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void RMAKERSAVEbutton5_Click(object sender, EventArgs e)
        {
            if (RMAKERSPRINGradioButton2.Checked == true)//for spring
            {
                if (RMAKERcomboBox1.SelectedIndex.ToString() == "0")
                {
                    string j = RMAKERmaskedTextBox1.Text.Trim() + "SI";


                    cmd = new SqlCommand(@" update " + j + " set [TM] = [" + M1[0] + "] + [" + M1[1] + "] + [" + M1[2] + "] + [" + M1[3] + "] + [" + M1[4] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5] " + "," + "[SGPA] = [QP]/15" + "," + "[COPM] =  ([TM]/500)*100 " + "," + "[TQP1]=[QP]" + "," + "[TM1]=[TM] " + "," + "[CGPA]=[SGPA]" + "," + "[COPM1]=[COPM]", conn); conn.Open();
                    cmd.ExecuteNonQuery();
                    //cmd = new SqlCommand(@" update " + RMAKERmaskedTextBox1.Text.Trim() + "SI"  +" set [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5] ", conn);
                    //cmd.ExecuteNonQuery();
                    //cmd = new SqlCommand(@" update " + RMAKERmaskedTextBox1.Text.Trim() + "set [SGPA] = [QP]/15 ", conn);
                    //cmd.ExecuteNonQuery();
                    //cmd = new SqlCommand(@" update [Mcs11_11SI] set [COPM] =  ([TM]/500)*100", conn);
                    //cmd.ExecuteNonQuery();

                    gradedataGridView1.DataSource = GetDataGrade(j);

                    for (int i = 0; i < gradedataGridView1.Rows.Count; i++)
                    {
                        GetGrade(j);
                    }
                    cmd = new SqlCommand(@"update " + j + " set [GRADE1]=[GRADE]", conn);
                    cmd.ExecuteNonQuery();

                    //cmd = new SqlCommand(@"update " + j + " set [RESULT]='G.S' WHER " + M1[0] + ">=60", conn);
                    //cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("successfully create table");

                }

                if (RMAKERcomboBox1.SelectedIndex.ToString() == "1")
                {
                    //cmd = new SqlCommand(@" update " + RMAKERmaskedTextBox1.Text.Trim() + "SII" + " set [TM] = [" + M2[0] + "] + [" + M2[1] + "] + [" + M2[2] + "] + [" + M2[3] + "] + [" + M2[4] + "] + [" + M2[5] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] " + "," + "[SGPA] = [QP]/18" + "," + "[COPM] =  ([TM]/600)*100 " + "," + "[TQP]=[QP]" + "," + "[TM1]=[TM] " + "," + "[CGPA1]=[SGPA]" + "," + "[GRADE1]=[GRADE]" + "," + "[COPM1]=[COPM]", conn); conn.Open();
                    cmd = new SqlCommand(@" update " + RMAKERmaskedTextBox1.Text.Trim() + "SII" + " set [TM] = [" + M2[0] + "] + [" + M2[1] + "] + [" + M2[2] + "] + [" + M2[3] + "] + [" + M2[4] + "] + [" + M2[5] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] " + "," + "[SGPA] = [QP]/18" + "," + "[COPM] =  ([TM]/600)*100 " + "," + "[GQP]=[TQP1]+[QP]" + "," + "[GTM]=[TM]+[TM1]" + "," + "[CGPA]=[GQP]/33" + "," + "[COPM2]=[GTM]/1100 ", conn); conn.Open();

                    cmd.ExecuteNonQuery();
                    string j = RMAKERmaskedTextBox1.Text.Trim() + "SII";

                    gradedataGridView1.DataSource = GetDataGrade(j);
                    for (int i = 0; i < gradedataGridView1.Rows.Count; i++)
                    {
                        GetGrade(j);
                    }
                    for (int i = 0; i < gradedataGridView1.Rows.Count; i++)
                    {
                        GetGrade1(j);
                    }


                    conn.Close();
                    MessageBox.Show("successfully create table");

                }
                if (RMAKERcomboBox1.SelectedIndex.ToString() == "2")
                {
                    cmd = new SqlCommand(@" update " + RMAKERmaskedTextBox1.Text.Trim() + "SIII" + " set [TM] = [" + M1[0] + "] + [" + M1[1] + "] + [" + M1[2] + "] + [" + M1[3] + "] + [" + M1[4] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5] " + "," + "[SGPA] = [QP]/15,[COPM] =  ([TM]/500)*100 " + "," + "[TQP]=[QP]" + "," + "[TM1]=[TM] " + "," + "[CGPA1]=[SGPA]" + "," + "[GRADE1]=[GRADE]" + "," + "[COPM1]=[COPM]", conn); conn.Open();
                    cmd.ExecuteNonQuery();
                    string j = RMAKERmaskedTextBox1.Text.Trim() + "SIII";

                    gradedataGridView1.DataSource = GetDataGrade(j);
                    for (int i = 0; i < gradedataGridView1.Rows.Count; i++)
                    {
                        GetGrade(j);
                    }
                    for (int i = 0; i < gradedataGridView1.Rows.Count; i++)
                    {
                        GetGrade1(j);
                    }
                    conn.Close();
                    MessageBox.Show("successfully create table");

                }
                if (RMAKERcomboBox1.SelectedIndex.ToString() == "3")
                {
                    cmd = new SqlCommand(@" update " + RMAKERmaskedTextBox1.Text.Trim() + "SI" + " set [TM] = [" + M1[0] + "] + [" + M1[1] + "] + [" + M1[2] + "] + [" + M1[3] + "] + [" + M1[4] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5] " + "," + "[SGPA] = [QP]/15,[COPM] =  ([TM]/500)*100 " + "," + "[TQP]=[QP]" + "," + "[TM1]=[TM] " + "," + "[CGPA1]=[SGPA]" + "," + "[GRADE1]=[GRADE]" + "," + "[COPM1]=[COPM]", conn); conn.Open();
                    cmd.ExecuteNonQuery();
                    //gradedataGridView1.DataSource = GetDataGrade();
                    for (int i = 0; i < gradedataGridView1.Rows.Count; i++)
                    {
                        //GetGrade();
                    }
                    conn.Close();
                    MessageBox.Show("successfully create table");

                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < newsemesterdataGridView1.Rows.Count; i++)
            {

                //SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[TQP1],[TM])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + "')", conn);

                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[TQP1],[TM1])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                conn.Open();
                r = cm.ExecuteNonQuery();
                conn.Close();

            }
            MessageBox.Show("insert data successfully");
        }
    }
}