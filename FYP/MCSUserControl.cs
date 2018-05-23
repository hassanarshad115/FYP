using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel;
using DGVPrinterHelper;

namespace FYP
{
    public partial class MCSUserControl : UserControl
    {
        public MCSUserControl()
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
        SqlConnection conn = new SqlConnection("Data Source=HASSAN-MALIK;Initial Catalog=FYPDB;Integrated Security=True");
        int rs; // rs yha lia ha



        private void button1_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty())
            {


                SqlCommand cmd;


                if (springradioButton1.Checked == true)//for spring
                {
                    if (session1comboBox1.SelectedIndex.ToString() == "0")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "SIII";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "SII";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;

                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "3")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SIV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "SIV";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "SIII";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                }
                //now create table for Fall Students
                if (fallradioButton2.Checked == true)
                {
                    if (session1comboBox1.SelectedIndex.ToString() == "0")
                    {
                        insertbutton2.Visible = true;
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FI";//yha concatinate kia h session ko 

                        //toplabellabel7.Text = "First Semester";
                        MessageBox.Show("Successfully Create "+ toplabel6.Text+ " Table ");
                        newSemesterAfterFirstbutton5.Visible = false;
                        
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "1")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
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
                        MessageBox.Show("Successfully Create " + toplabel6.Text + " Table ");

                        newSemesterAfterFirstbutton5.Visible = true;

                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "2")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

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
                        MessageBox.Show("Successfully Create " + toplabel6.Text + " Table ");

                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "3")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FIV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(2000) NULL)";

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
                        MessageBox.Show("Successfully Create " + toplabel6.Text + " Table ");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }

                }

                newsemestergroupBox1.Enabled = true;

            }
        }

        private bool isCheckEmpty()
        {
            if (sessionmaskedTextBox1.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Session TextBox is Empty");
                sessionmaskedTextBox1.Focus();
                return false;

            }
            if (session1comboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Session Combobox is Empty");
                return false;
            }
            if (springradioButton1.Checked == false && fallradioButton2.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Select Spring or Fall");
                return false;
            }

            return true;
        }


        //METHOD FOR SHOW PREVIOUS TABLE STUDENTS RECORDS IN DATAGRIDVIEW
        private DataTable GetData(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] ,[RegdNo],[Name],[FatherName],[TQP1],[TM1],[REMARKS],[CGPA] from [dbo]." + o + " ", conn);
            adapter.Fill(dt);
            return dt;
        }
        private DataTable GetData23(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] ,[RegdNo],[Name],[FatherName],[GQP],[GTM],[REMARKS],[CGPA] from [dbo]." + o + " ", conn);
            adapter.Fill(dt);
            return dt;
        }


        private void session1comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        DataSet res = new DataSet();
        private void newsemesterchosefilebutton2_Click(object sender, EventArgs e)
        {
            //Subject 1
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook |*.xls;*.XLS;", ValidateNames = true })
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

        private void newsemestersheetcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            newsemesterdataGridView1.DataSource = res.Tables[newsemestersheetcomboBox1.SelectedIndex];

        }


        private void insertbutton2_Click(object sender, EventArgs e)
        {
            if (isEmpty5())
            {


                for (int i = 0; i < newsemesterdataGridView1.Rows.Count; i++)
                {
                    if (newsemesterdataGridView1.Rows[i].Cells[0].Value is DBNull)
                    {
                        break;
                    }
                    else
                    {
                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "')", conn);

                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }

                }
                MessageBox.Show("Insert Data Successfully into the Table");
                newsemesterdataGridView1.Columns.Clear();
                newsemestersheetcomboBox1.Items.Clear();

           
            }
        }

        private bool isEmpty5()
        {
            if (newsemestersheetcomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Please Select Sheet");
                return false;
            }
            return true;
        }

        private void newSemesterAfterFirstbutton5_Click(object sender, EventArgs e)
        {
           
            if (session1comboBox1.SelectedIndex.ToString() == "1")
                {


                    for (int i = 0; i < newsemesterdataGridView1.Rows.Count; i++)
                    {
                        if (newsemesterdataGridView1.Rows[i].Cells[0].Value is DBNull)
                        {
                            break;
                        }
                        else
                        {
                            double d = Convert.ToDouble(newsemesterdataGridView1.Rows[i].Cells[7].Value);
                            if (d >= 1.70)
                            {
                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[TQP1],[TM1])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }

                }
                else
            if (session1comboBox1.SelectedIndex.ToString() == "2")
                {
                    for (int i = 0; i < newsemesterdataGridView1.Rows.Count; i++)
                    {
                        if (newsemesterdataGridView1.Rows[i].Cells[7].Value is DBNull)
                        {
                            break;
                        }
                        else
                        {
                            double d = Convert.ToDouble(newsemesterdataGridView1.Rows[i].Cells[7].Value);
                            if (d >= 2.0)
                            {

                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[QP2],[TM2])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }
                }
                else
            if (session1comboBox1.SelectedIndex.ToString() == "3")
                {
                    for (int i = 0; i < newsemesterdataGridView1.Rows.Count; i++)
                    {
                        if (newsemesterdataGridView1.Rows[i].Cells[7].Value is DBNull)
                        {
                            break;
                        }
                        else
                        {
                            double d = Convert.ToDouble(newsemesterdataGridView1.Rows[i].Cells[7].Value);
                            if (d >= 2.0)
                            {

                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[QP3],[TM3])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }
                }
                MessageBox.Show("Insert Data Successfully into the Table");
                newsemesterdataGridView1.Columns.Clear();
            // newsemestersheetcomboBox1.Items.Clear();
            newsemesterchosefilebutton2.Visible = false;
            newsemestersheetcomboBox1.Visible = false;
            insertbutton2.Visible = false;

        }

        private void InresultsemestercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        private void semeterCountLoad98()
        {

            yoursemestercomboBox98.Items.Clear();
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "0")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(M1[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(M2[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "2")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(M3[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "3")
            {
                for (int i = 0; i < 7; i++)
                {
                    yoursemestercomboBox98.Items.Add(M4[i]);
                }
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty20())
            {
                if (resultspringradioButton2.Checked == true)
                {
                    afteResultgroupBox1.Visible = true;
                    ShowDataOnLabelInResultGroupbox();//for spring


                }
                if (resultfallradioButton1.Checked == true)
                {
                    ShowDataOnLabelInResultGroupBoxfOrFall();

                }
                afteResultgroupBox1.Enabled = true;
            }
        }

        private bool isCheckEmpty20()
        {

            if (resultmaskedTextBox1.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Enter Session");
                resultmaskedTextBox1.Focus();
                return false;
            }
            if (InresultsemestercomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Semester");
                return false;
            }
            if (resultspringradioButton2.Checked == false && resultfallradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Semester");
                return false;
            }
            if (yoursemestercomboBox2.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Subject");
                return false;
            }
            return true;
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
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook |*.xls;*.XLS;", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
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
            dataGridView5.DataSource = res.Tables[afterResultcomboBox.SelectedIndex];



        }





        private void button3_Click(object sender, EventArgs e)

        {
            if (isSheetEmtpy())
            {
                SqlCommand cmd, cd;
                for (int i = 10; i < dataGridView5.Rows.Count; i++)
                {

                    if (dataGridView5.Rows[i].Cells[0].Value is DBNull)
                    {
                        break;
                    }
                    else
                    {
                        double s = Convert.ToDouble(dataGridView5.Rows[i].Cells[5].Value);

                        conn.Open();
                        cmd = new SqlCommand(@"UPDATE " + topAfterResultlabel1.Text + " Set " + topAfterResultlabel2.Text + "='" + dataGridView5.Rows[i].Cells[5].Value + "' WHERE RollNo = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                        //YHA quality points wala colum ko pic krna pryga
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        //////yaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa 
                        //int q =    afterResultdataGridView2.Rows[i].Cells[5].Value  ;





                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "0")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP1 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "1")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP2 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "2")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP3 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "3")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP4 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "4")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP5 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "5")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            // Islamyat k QP ni hota Q k wo non cradit ha .................................................................
                            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "0")
                            {
                                conn.Open();

                                cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP6 = 0  ", conn);
                                cd.ExecuteNonQuery();
                                conn.Close();
                            }
                            else
                            {
                                conn.Open();

                                cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP6 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                                cd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "6")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP7 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + dataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                }
                MessageBox.Show("successfully");

                dataGridView5.Columns.Clear();
                afterResultcomboBox.Items.Clear();

            }
        }

        private bool isSheetEmtpy()
        {
            if (afterResultcomboBox.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Please Select Sheet");
                return false;
            }
            return true;
        }


        //method 
        private DataTable GetDataGrade(string V)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [COPM] from " + V, conn);
            adapter.Fill(dt);
            return dt;
        }

        // /METHODS FOR GRADE
        SqlCommand cmd;
        private void GetGrade(string valueOfMaskTextBox)
        {

            conn.Open();
            //FOR  GRADE
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'A+' where [COPM]<= 100 AND [COPM] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'A' where [COPM]< 95 AND [COPM] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'B+' WHERE [COPM] < 85 AND [COPM] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'B' where [COPM]< 80 AND [COPM] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'C' where [COPM]< 70 AND [COPM] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'D' where [COPM]< 60 AND [COPM] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox + " set [GRADE] = 'F' where [COPM]< 50 AND [COPM] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetGrade1(string valueOfMaskTextBox1)
        {
            conn.Open();
            //FOR SECOND SEMESTER
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2]= 'A+' where [COPM2]<= 100 AND [COPM2] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2]= 'A' where [COPM2] < 95 AND [COPM2] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2]= 'B+' WHERE [COPM2] < 85 AND [COPM2] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2]= 'B' where [COPM2] < 80 AND [COPM2] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2] = 'C' where [COPM2]< 70 AND [COPM2] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2] = 'D' where [COPM2]< 60 AND [COPM2] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox1 + " set [GRADE2] = 'F' where [COPM2]< 50 AND [COPM2] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetGrade2(string valueOfMaskTextBox2)
        {
            conn.Open();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3]= 'A+' where [COPM3]<= 100 AND [COPM3] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3]= 'A' where [COPM3] < 95 AND [COPM3] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3]= 'B+' WHERE [COPM3] < 85 AND [COPM3] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3]= 'B' where [COPM3] < 80 AND [COPM3] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3] = 'C' where [COPM3]< 70 AND [COPM] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3] = 'D' where [COPM3]< 60 AND [COPM] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox2 + " set [GRADE3] = 'F' where [COPM3]< 50 AND [COPM] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetGrade3(string valueOfMaskTextBox3)
        {
            conn.Open();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4]= 'A+' where [COPM4] <= 100 AND [COPM4] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4]= 'A' where [COPM4] < 95 AND [COPM4] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4]= 'B+' WHERE [COPM4] < 85 AND [COPM4] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4]= 'B' where [COPM4] < 80 AND [COPM4] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4] = 'C' where [COPM4]< 70 AND [COPM4] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4] = 'D' where [COPM4]< 60 AND [COPM4] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE4] = 'F' where [COPM4]< 50 AND [COPM4] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Update R Source k lya
        // Update R Source k lya
        private DataTable GetDataSply1(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] , [TQP1] , [TM1],[REMARKS] from [dbo]." + o + " ", conn);

            adapter.Fill(dt);
            return dt;
        }
        // Update R Source k lya
        private DataTable GetDataSply2(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] , [GQP] , [GTM],[REMARKS] from [dbo]." + o + " ", conn);
            adapter.Fill(dt);
            //ya tqp2 and tm2 man ani cahya
            return dt;
        }
        //pahla wala ka result bnana and update k lya bhi tya use karna 
        private void semester1updateandnew1(string s1)
        {

            ResultSemester1(s1);

            gradedataGridView11.DataSource = GetDataGrade(s1);

            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s1);
            }
            //grade uper set kia ha islye nichy grade set kia for for neeed
            cmd = new SqlCommand(@"update " + s1 + " set [GRADE1]=[GRADE]", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void semester1updateandnew2(string s2)
        {
            ResultSemester2(s2);

            gradedataGridView11.DataSource = GetDataGrade(s2);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s2);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade1(s2);
            }


        }
        private void semester1updateandnew3(string s3)
        {
            //string s3 = RMAKERmaskedTextBox1.Text.Trim() + "SIII";

            //conn.Open();
            ResultSemester3(s3);

            gradedataGridView11.DataSource = GetDataGrade(s3);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s3);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade2(s3);
            }
            //conn.Close();
        }
        private void semester1updateandnew4(string s4)
        {
            // string s4 = RMAKERmaskedTextBox1.Text.Trim() + "SIV";

            //conn.Open();

            ResultSemester4(s4);

            gradedataGridView11.DataSource = GetDataGrade(s4);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s4);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade3(s4);
            }

            //conn.Close();
        }



        // making result query 
        private void ResultSemester4(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + M4[0] + "] + [" + M4[1] + "] + [" + M4[2] + "] + [" + M4[3] + "] + [" + M4[4] + "] + [" + M4[5] + "] + [" + M4[6] + "] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6]+[QP7] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round( [QP]/21 , 2 ) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/700)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP3] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM3] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]= round ( [GQP]/72 , 2 ) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM4] = round(( [GTM]/2400 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + M4[0] + "] >= 60 and[" + M4[1] + "] >= 60 and[" + M4[2] + "] >= 60 and[" + M4[3] + "] >= 60 and[" + M4[4] + "] >= 60 and[" + M4[5] + "] >= 60 and[" + M4[6] + "] >= 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21401') WHERE [" + M4[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21402') WHERE [" + M4[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21403') WHERE [" + M4[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21404') WHERE [" + M4[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21405') WHERE [" + M4[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21406') WHERE [" + M4[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21406') WHERE [" + M4[6] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void ResultSemester3(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + M3[0] + "] + [" + M3[1] + "] + [" + M3[2] + "] + [" + M3[3] + "] + [" + M3[4] + "]  + [" + M3[5] + "] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round( [QP]/18 , 2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP2] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM2] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]= round([GQP]/51 , 2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM3]=round(( [GTM]/1700 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + M3[0] + "] >= 60 and[" + M3[1] + "] >= 60 and[" + M3[2] + "] >= 60 and[" + M3[3] + "] >= 60 and[" + M3[4] + "] >= 60 and[" + M3[5] + "] >= 60 ", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21301') WHERE [" + M3[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21302') WHERE [" + M3[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21303') WHERE [" + M3[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21304') WHERE [" + M3[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21305') WHERE [" + M3[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21306') WHERE [" + M3[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ResultSemester2(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + M2[0] + "] + [" + M2[1] + "] + [" + M2[2] + "] + [" + M2[3] + "] + [" + M2[4] + "] + [" + M2[5] + "] ", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round([QP]/18 , 2) ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100 ,2)  ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [GQP]=[TQP1]+[QP] ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM1] ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [CGPA]= round([GQP]/33 , 2) ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [COPM2] = round(([GTM] / 1100 )*100 ,2) ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + M2[0] + "] >= 60 and[" + M2[1] + "] >= 60 and[" + M2[2] + "] >= 60 and[" + M2[3] + "] >= 60 and[" + M2[4] + "] >= 60 and[" + M2[5] + "] >= 60 ", conn);

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21201') WHERE [" + M2[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21202') WHERE [" + M2[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21203') WHERE [" + M2[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21204') WHERE [" + M2[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21205') WHERE [" + M2[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21206') WHERE [" + M2[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void ResultSemester1(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + M1[0] + "] + [" + M1[1] + "] + [" + M1[2] + "] + [" + M1[3] + "] + [" + M1[4] + "] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round([QP]/15 ,2)", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/500)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [TQP1]=[QP] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [TM1]=[TM] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]= [SGPA]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM1]= round([COPM] ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set   [RESULT] = 'G.S' WHERE [" + M1[0] + "] >= 60 and [" + M1[1] + "] >= 60 and [" + M1[2] + "] >= 60 and [" + M1[3] + "] >= 60 and [" + M1[4] + "] >= 60 and [" + M1[5] + "] >= 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]= '' ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]= 'CSIT21101' WHERE [" + M1[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21102') WHERE [" + M1[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21103') WHERE [" + M1[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21104') WHERE [" + M1[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21105') WHERE [" + M1[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT21106') WHERE [" + M1[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        string rs4 = "";
        string rs3 = "";
        string rs2 = "";
        string rs1 = "";
        string fs4 = "";
        string fs3 = "";
        string fs2 = "";
        string fs1 = "";







        private void button5_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty1())
            {
                SqlCommand cmd;


                if (previusRetainerSpringradioButton2.Checked == true)//for spring
                {
                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "0")
                    {
                        if (newRetainerradioButton2.Checked == true)
                        {
                            fs1 = previousmaskedTextBox1.Text.Trim() + "SI";

                            rs1 = retainerMaskedTextBox2.Text.Trim() + "SI";
                            string q = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Successfully Create Table  "+ rs1);
                        }
                        if (oldRetainerradioButton1.Checked == true)
                        {

                            InformationAndErrorClass.ErrorMessage("Not Allowed");
                        }
                    }

                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "1")
                    {
                        if (oldRetainerradioButton1.Checked == true)
                        {

                            rs2 = retainerMaskedTextBox2.Text.Trim() + "SII";
                            rs1 = RPREmaskedTextBox1.Text.Trim() + "SI";
                            // previousmaskedTextBox1


                            string q1 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Successfully Create Table  " + rs2);


                        }


                        if (newRetainerradioButton2.Checked == true)
                        {
                            rs2 = retainerMaskedTextBox2.Text.Trim() + "SII";

                            fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                            rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";


                            string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            string q = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }


                        MessageBox.Show("Successfully Create Table  " );

                    }
                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "2")
                    {
                        if (newRetainerradioButton2.Checked == true)
                        {

                            rs3 = retainerMaskedTextBox2.Text.Trim() + "SIII";

                            fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                            fs2 = previousmaskedTextBox1.Text.Trim() + "SII";

                            rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";
                            rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "SII";



                            string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q2, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q3, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully Create Table  " );

                        }
                        if (oldRetainerradioButton1.Checked == true)
                        {
                            rs3 = retainerMaskedTextBox2.Text.Trim() + "SIII";
                            rs2 = RPREmaskedTextBox1.Text.Trim() + "SII";


                            string q = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully Create Table  ");

                        }


                    }
                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "3")
                    {
                        if (newRetainerradioButton2.Checked == true)
                        {
                            rs4 = retainerMaskedTextBox2.Text.Trim() + "SIV";


                            fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                            fs2 = previousmaskedTextBox1.Text.Trim() + "SII";
                            fs3 = previousmaskedTextBox1.Text.Trim() + "SIII";


                            rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";
                            rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "SII";
                            rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "SIII";

                            string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q2, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q3, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q4, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Successfully Create Table  ");
                        }
                        if (oldRetainerradioButton1.Checked == true)
                        {
                            rs4 = retainerMaskedTextBox2.Text.Trim() + "SIV";
                            rs3 = RPREmaskedTextBox1.Text.Trim() + "SIII";


                            string q = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }
                }
                //now create table for Fall Students
                if (previousRetainerFallradioButton1.Checked == true)
                {

                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "0")
                    {
                        if (newRetainerradioButton2.Checked == true)
                        {
                            fs1 = previousmaskedTextBox1.Text.Trim() + "FI";

                            rs1 = retainerMaskedTextBox2.Text.Trim() + "FI";
                            string q = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Successfully Create Table  ");
                        }
                        if (oldRetainerradioButton1.Checked == true)
                        {
                            MessageBox.Show("Sorry Not Allowed");
                        }
                    }

                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "1")
                    {
                        if (oldRetainerradioButton1.Checked == true)
                        {

                            rs2 = retainerMaskedTextBox2.Text.Trim() + "FII";
                            rs1 = RPREmaskedTextBox1.Text.Trim() + "FI";
                            // previousmaskedTextBox1


                            string q1 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Successfully Create Table  ");


                        }


                        if (newRetainerradioButton2.Checked == true)
                        {
                            rs2 = retainerMaskedTextBox2.Text.Trim() + "FII";

                            fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                            rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";


                            string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            string q = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }


                        MessageBox.Show("Successfully Create Table  ");

                    }
                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "2")
                    {
                        if (newRetainerradioButton2.Checked == true)
                        {

                            rs3 = retainerMaskedTextBox2.Text.Trim() + "FIII";

                            fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                            fs2 = previousmaskedTextBox1.Text.Trim() + "FII";

                            rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";
                            rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "FII";



                            string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q2, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q3, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully Create Table  ");

                        }
                        if (oldRetainerradioButton1.Checked == true)
                        {
                            rs3 = retainerMaskedTextBox2.Text.Trim() + "FIII";
                            rs2 = RPREmaskedTextBox1.Text.Trim() + "FII";


                            string q = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Successfully Create Table  ");

                        }


                    }
                    if (retainerSemestercomboBox1.SelectedIndex.ToString() == "3")
                    {
                        if (newRetainerradioButton2.Checked == true)
                        {
                            rs4 = retainerMaskedTextBox2.Text.Trim() + "FIV";


                            fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                            fs2 = previousmaskedTextBox1.Text.Trim() + "FII";
                            fs3 = previousmaskedTextBox1.Text.Trim() + "FIII";


                            rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";
                            rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "FII";
                            rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "FIII";

                            string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q2, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q3, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q4, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();


                            MessageBox.Show("Successfully Create Table  ");
                        }
                        if (oldRetainerradioButton1.Checked == true)
                        {
                            rs4 = retainerMaskedTextBox2.Text.Trim() + "FIV";
                            rs3 = RPREmaskedTextBox1.Text.Trim() + "FIII";


                            string q = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                            cmd = new SqlCommand(q, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }


                }
                groupBox2.Enabled = true;
            }
        }

        private bool isCheckEmpty1()
        {
            if (previousmaskedTextBox1.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Previous Session TextBox is Empty");
                previousmaskedTextBox1.Focus();
                return false;

            }
            if (oldRetainerradioButton1.Checked == true)
            {
                if (RPREmaskedTextBox1.Text.Trim() == "RMcs  _")
                {
                    InformationAndErrorClass.ErrorMessage("Previous Retainer Session TextBox is Empty");
                    RPREmaskedTextBox1.Focus();
                    return false;

                }
            }
            if (retainerMaskedTextBox2.Text.Trim() == "RMcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Retain Class TextBox is Empty");
                retainerMaskedTextBox2.Focus();
                return false;

            }
            if (previusRetainerSpringradioButton2.Checked == false && previousRetainerFallradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Select Spring or Fall");
                return false;

            }
            if (retainerSemestercomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Select Retainer Semester");
                retainerSemestercomboBox1.Focus();
                return false;

            }

            return true;
        }

        private void showRetainerRecordbutton7_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty2())
            {
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "0")
                {
                    retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);


                }

                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "1")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + M1[0] + "] ,[QP1] ,[" + M1[1] + "] ,[QP2] ,[" + M1[2] + "] ,[QP3] ,[" + M1[3] + "] ,[QP4] ,[" + M1[4] + "] ,[QP5] ,[" + M1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs1 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer1(rs1);


                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer1(rs1);


                    }
                    //if (newRetainerradioButton2.Checked == true)
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "2")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + M1[0] + "] ,[QP1] ,[" + M1[1] + "] ,[QP2] ,[" + M1[2] + "] ,[QP3] ,[" + M1[3] + "] ,[QP4] ,[" + M1[4] + "] ,[QP5] ,[" + M1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + M2[0] + "] ,[QP1] ,[" + M2[1] + "] ,[QP2] ,[" + M2[2] + "] ,[QP3] ,[" + M2[3] + "] ,[QP4] ,[" + M2[4] + "] ,[QP5] ,[" + M2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs2 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs2);


                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs2);

                    }

                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "3")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + M1[0] + "] ,[QP1] ,[" + M1[1] + "] ,[QP2] ,[" + M1[2] + "] ,[QP3] ,[" + M1[3] + "] ,[QP4] ,[" + M1[4] + "] ,[QP5] ,[" + M1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + M2[0] + "] ,[QP1] ,[" + M2[1] + "] ,[QP2] ,[" + M2[2] + "] ,[QP3] ,[" + M2[3] + "] ,[QP4] ,[" + M2[4] + "] ,[QP5] ,[" + M2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs3);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + M3[0] + "] ,[QP1] ,[" + M3[1] + "] ,[QP2] ,[" + M3[2] + "] ,[QP3] ,[" + M3[3] + "] ,[QP4] ,[" + M3[4] + "] ,[QP5] ,[" + M3[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP2],[TM2],[GTM],[GQP] ,[CGPA],[GRADE3],[COPM3] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs3 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs3);



                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs3);

                    }

                }

                SaveRetainerRecordbutton6.Enabled = true;
            }
        }

        private bool isCheckEmpty2()
        {
            if (getRetainerRollnotextBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Search by RollNo TextBox is Empty");
                getRetainerRollnotextBox1.Focus();
                return false;
            }
            return true;
        }

        private DataTable getRetainerRecordForRetainer(string p)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from [dbo]." + p + "  where [RollNo] = '" + getRetainerRollnotextBox1.Text + "'", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }
        private DataTable getRetainerRecordForRetainer1(string p)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select [RollNo] ,[RegdNo],[Name],[FatherName],[TQP1],[TM1] ,[REMARKS] from [dbo]." + p + " ", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }
        private DataTable getRetainerRecordForRetainer2(string p)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select [RollNo] ,[RegdNo],[Name],[FatherName],[GQP],[GTM] ,[REMARKS] from [dbo]." + p + " ", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }



        private void SaveRetainerRecordbutton6_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty2())
            {

                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "0")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + " ([RollNo],[RegdNo],[Name],[FatherName])VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                    retainerDataGridView1.Columns.Clear();
                    getRetainerRollnotextBox1.Clear();
                    getRetainerRollnotextBox1.Focus();
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "1")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP1],[TM1],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                    retainerDataGridView1.Columns.Clear();
                    getRetainerRollnotextBox1.Clear();
                    getRetainerRollnotextBox1.Focus();
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "2")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP2],[TM2],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                    retainerDataGridView1.Columns.Clear();
                    getRetainerRollnotextBox1.Clear();
                    getRetainerRollnotextBox1.Focus();
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "3")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs4 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP3],[TM3],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                    retainerDataGridView1.Columns.Clear();
                    getRetainerRollnotextBox1.Clear();
                    getRetainerRollnotextBox1.Focus();
                }
            }
        }

        private void newRetainerradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RPREmaskedTextBox1.Visible = false;
            label10.Visible = false;
            previousmaskedTextBox1.Visible = true;
            label2.Visible = true;
            groupBox1.Enabled = true;
        }

        private void oldRetainerradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            previousmaskedTextBox1.Visible = false;
            label2.Visible = false;
            RPREmaskedTextBox1.Visible = true;
            label10.Visible = true;
            groupBox1.Enabled = true;
        }
        string tbl;
        private void button6_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty3())
            {
                if (RRSpringradioButton2.Checked == true)
                {
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "0")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "SI";
                    }
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "1")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "SII";
                    }
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "2")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "SIII";
                    }
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "3")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "SIV";
                    }


                }
                if (RRFallradioButton1.Checked == true)
                {
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "0")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "FI";
                    }
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "1")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "FII";
                    }
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "2")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "FIII";
                    }
                    if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "3")
                    {
                        label16.Text = RRRmaskedTextBox1.Text + "FIV";
                    }


                }
                label15.Text = RRetainerScomboBox1.Text;

            }
        }

        private bool isCheckEmpty3()
        {
            if (RRRmaskedTextBox1.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Enter Session");
                RRRmaskedTextBox1.Focus();
                return false;
            }
            if (RRetainerResultcomboBox2.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Semester");
                return false;
            }
            if (RRSpringradioButton2.Checked == false && RRFallradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Semester");
                return false;
            }
            if (RRetainerScomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Subject");
                return false;
            }
            return true;
        }

        private void RetainerResultcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            semeterCountLoad1();

        }
        private void semeterCountLoad1()
        {

            RRetainerScomboBox1.Items.Clear();
            if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "0")
            {
                for (int i = 0; i < 6; i++)
                {
                    RRetainerScomboBox1.Items.Add(M1[i]);
                }
            }
            if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < 6; i++)
                {
                    RRetainerScomboBox1.Items.Add(M2[i]);
                }
            }
            if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "2")
            {
                for (int i = 0; i < 6; i++)
                {
                    RRetainerScomboBox1.Items.Add(M3[i]);
                }
            }
            if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "3")
            {
                for (int i = 0; i < 7; i++)
                {
                    RRetainerScomboBox1.Items.Add(M4[i]);
                }
            }

        }

        SqlCommand cd;
        DataSet dss = new DataSet();


        //method for qp generate


        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void MakeResultofRetainerbutton8_Click(object sender, EventArgs e)
        {
            // ya spring ka ha bas/////////////////////////////////////////////////////////////////////////////////////////////////////// baki karna ha

            if (RetainerSpradioButton2.Checked == true)//for spring
            {
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "0")
                {
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                    resultmaker1(r1);

                    MessageBox.Show("successfully create result");


                }
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "1")
                {
                    string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "SII";
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                    resultmaker1(r1);
                    RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker2(r2);
                    MessageBox.Show("successfully create table");

                }
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "2")
                {
                    string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "SIII";
                    string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "SII";
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                    resultmaker1(r1);

                    RetainergrddataGridView1.DataSource = GetDataSply1(r1);
                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker2(r2);
                    RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }


                    resultmaker3(r3);
                    MessageBox.Show("successfully create table");

                }
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "3")
                {
                    string r4 = RetaierSnmaskedTextBox1.Text.Trim() + "SIV";
                    string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "SIII";
                    string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "SII";
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                    resultmaker1(r1);
                    RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker2(r2);
                    RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    resultmaker3(r3);

                    RetainergrddataGridView1.DataSource = GetDataSply2(r3);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r4 + " set TQP3 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM3 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker4(r4);
                    MessageBox.Show("successfully create table");

                }

            }
            if (RetainerFallradioButton1.Checked == true)//for falll
            {
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "0")
                {
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                    resultmaker1(r1);

                    MessageBox.Show("successfully create result");


                }
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "1")
                {
                    string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "FII";
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                    resultmaker1(r1);
                    RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker2(r2);
                    MessageBox.Show("successfully create table");

                }
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "2")
                {
                    string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "FIII";
                    string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "FII";
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                    resultmaker1(r1);
                    RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker2(r2);
                    RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }


                    resultmaker3(r3);
                    MessageBox.Show("successfully create table");

                }
                if (RetainerKacomboBox1.SelectedIndex.ToString() == "3")
                {
                    string r4 = RetaierSnmaskedTextBox1.Text.Trim() + "FIV";
                    string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "FIII";
                    string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "FII";
                    string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                    resultmaker1(r1);
                    RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker2(r2);
                    RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    resultmaker3(r3);

                    RetainergrddataGridView1.DataSource = GetDataSply2(r3);


                    for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                    {
                        cmd = new SqlCommand(@" Update " + r4 + " set TQP3 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM3 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    resultmaker4(r4);
                    MessageBox.Show("successfully create table");

                }

            }
        }

        private void resultmaker4(string j)
        {
            ResultSemester4(j);

            RetainergrddataGridView1.DataSource = GetDataGrade(j);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(j);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade3(j);
            }

            conn.Close();
        }

        private void resultmaker3(string j)
        {
            ResultSemester3(j);

            RetainergrddataGridView1.DataSource = GetDataGrade(j);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(j);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade2(j);
            }
            conn.Close();
        }

        private void resultmaker2(string r2)
        {
            ResultSemester2(r2);

            RetainergrddataGridView1.DataSource = GetDataGrade(r2);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(r2);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade1(r2);
            }

            conn.Close();
        }

        private void resultmaker1(string r1)
        {
            ResultSemester1(r1);

            RetainergrddataGridView1.DataSource = GetDataGrade(r1);

            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(r1);
            }
            //grade uper set kia ha islye nichy grade set kia for for neeed
            cmd = new SqlCommand(@"update " + r1 + " set [GRADE1]=[GRADE]", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void newsemestergroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void retainerSemestercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (retainerSemestercomboBox1.SelectedIndex.ToString() == "0" || retainerSemestercomboBox1.SelectedIndex.ToString() == "1" || retainerSemestercomboBox1.SelectedIndex.ToString() == "2" || retainerSemestercomboBox1.SelectedIndex.ToString() == "3")
            //{
            //    RPREmaskedTextBox1.Visible = false;
            //    label10.Visible = false;
            //    previousmaskedTextBox1.Visible = true;
            //    label2.Visible = true;
            //}
            //else


            //{

            //}
        }
        string tableresult98 = "";
        string colum98 = "";

        private void QpaMethod98(string qp)
        {
            conn.Open();
            cd = new SqlCommand("Update " + tableresult98 + " set " + qp + " = " + QpaClass.QpaMethod(Convert.ToDouble(markstextBox98.Text)) + " where [RollNo] = '" + Rollno + "'", conn);
            cd.ExecuteNonQuery();
            conn.Close();
        }
        //resultmasktextbox98 k zrye agr rollno tbl ma hoga tw wo ye kam kryga jo hm chahty h wrna wo error dyga
        DataSet ds = new DataSet();
        String Rollno = "";
        private void resultbutton98_Click_1(object sender, EventArgs e)
        {
            if (isCheckEmpty5())
            {
                SqlCommand cm = new SqlCommand("select * from [dbo].[" + resultmaskedTextBox98.Text + "]", conn);
                SqlDataAdapter ad = new SqlDataAdapter(cm);
                ad.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)

                {
                    #region
                    SqlCommand cmd = new SqlCommand(@"Update " + tableresult98 + " set " + colum98 + " = " + markstextBox98.Text + "  where [RollNo] = '" + rollNotextBox98.Text.Trim() + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Rollno = rollNotextBox98.Text.Trim();
                    string o = markstextBox98.Text;
                  
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "0")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                    {
                        QpaMethod98("QP1");
                    }
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "1")            // AGR RetainerScomboBox1 ITEM 2 hwa tab ya ka ho
                    {
                        QpaMethod98("QP2");
                    }
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "2")            // AGR RetainerScomboBox1 ITEM 3 hwa tab ya ka ho
                    {
                        QpaMethod98("QP3");
                    }
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "3")            // AGR RetainerScomboBox1 ITEM 4 hwa tab ya ka ho
                    {
                        QpaMethod98("QP4");
                    }
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "4")            // AGR RetainerScomboBox1 ITEM 5 hwa tab ya ka ho
                    {
                        QpaMethod98("QP5");
                    }
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "5")            // AGR RetainerScomboBox1 ITEM 6 hwa tab ya ka ho
                    {
                        QpaMethod98("QP6");
                    }
                    if (yoursemestercomboBox98.SelectedIndex.ToString() == "6")            // AGR RetainerScomboBox1 ITEM 6 hwa tab ya ka ho
                    {
                        QpaMethod98("QP7");
                    }
                    MessageBox.Show("Test successfully");

                    rollNotextBox98.Clear();
                    rollNotextBox98.Focus();
                    markstextBox98.Clear();
                    #endregion
                }

                else
                {
                    InformationAndErrorClass.ErrorMessage("RollNo is Not Match In this Table");
                }
            }
        } //resutl button is ok

        private bool isCheckEmpty5()
        {
            if (rollNotextBox98.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("RollNo is Required");
                rollNotextBox98.Focus();
                return false;
            }
            if (markstextBox98.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Marks is Required");
                markstextBox98.Focus();
                return false;
            }
            return true;
        }

        private void button98_Click(object sender, EventArgs e) // button is ok
        {
            if (isCheckEmpty4())
            {
                if (resultspringradioButton98.Checked == true)
                {
                    if (radioButton4.Checked == true)
                    {
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "1")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "2")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "3")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SIII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "4")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SIV";
                        }
                    }
                    if (radioButton3.Checked == true)
                    {
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "1")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "SI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "2")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "SII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "3")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "SIII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "4")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "SIV";
                        }

                    }
                    colum98 = "[" + yoursemestercomboBox98.Text + "]";

                }
                if (resultfallradioButton98.Checked == true)
                {
                    if (radioButton4.Checked == true)
                    {
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "1")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FI";

                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "2")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "3")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FIII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "4")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FIV";
                        }
                    }
                    if (radioButton3.Checked == true)
                    {
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "1")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "FI";

                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "2")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "FII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "3")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "FIII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "4")
                        {
                            tableresult98 = RetainermaskedTextBox5.Text + "FIV";
                        }
                    }
                    colum98 = "[" + yoursemestercomboBox98.Text + "]";

                }
                groupBox7.Enabled = true;
            }
        }

        private bool isCheckEmpty4()
        {
            if (radioButton4.Checked == true)
            {
                if (resultmaskedTextBox98.Text.Trim() == string.Empty)
                {
                    InformationAndErrorClass.ErrorMessage("Session is Required");
                    resultmaskedTextBox98.Focus();
                    return false;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (RetainermaskedTextBox5.Text.Trim() == string.Empty)
                {
                    InformationAndErrorClass.ErrorMessage("Session is Required");
                    RetainermaskedTextBox5.Focus();
                    return false;
                }
            }
            if (InresultsemstercomboBox98.Text == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Semester is Required");
                InresultsemstercomboBox98.Focus();
                return false;
            }
            if (resultspringradioButton98.Checked == true && resultfallradioButton98.Checked == true)
            {
                InformationAndErrorClass.ErrorMessage("Spring/Fall is Not Selected");
                resultspringradioButton98.Focus();
                return false;
            }
            if (yoursemestercomboBox98.Text == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Subject is Required");
                yoursemestercomboBox98.Focus();
                return false;
            }
            return true;
        }

        private void InresultsemstercomboBox98_SelectedIndexChanged(object sender, EventArgs e)
        {
            semeterCountLoad98();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }
        private DataTable GetPosition(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select top 4 [SGPA] , [TM] , [RollNo] from [dbo]." + o + " ", conn);

            adapter.Fill(dt);
            return dt;
        }

        private void RMAKERSAVEbutton5_Click_1(object sender, EventArgs e)
        {
            if (isEmpty7())
            {


                if (RMAKERSPRINGradioButton2.Checked == true)//for spring
                {
                    //SqlConnection conn = new SqlConnection(ConfigurationClass.ConfigurationMethod());
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "0")
                    {
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "SI";


                        semester1updateandnew1(s1);



                        //POSITION K LYE YE METHOD YHA FILL KIA HA
                        gradedataGridView11.DataSource = GetPosition(s1);
                        MessageBox.Show("successfully create result");

                        PositionMethod(s1);
                        //  <<<<========



                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "1")
                    {
                        string s2 = RMAKERmaskedTextBox1.Text.Trim() + "SII";
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "SI";
                        semester1updateandnew1(s1);



                        gradedataGridView11.DataSource = GetDataSply1(s1);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s2 + " set TQP1 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }


                        //  update j set tqp1 pichla wala ko isa set kar dana ha or total marks iddrr la ana ha

                        // orignal  cmd = new SqlCommand(@" update " + j + " set [TM] = [" + M2[0] + "] + [" + M2[1] + "] + [" + M2[2] + "] + [" + M2[3] + "] + [" + M2[4] + "] + [" + M2[5] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] " + "," + "[SGPA] = [QP]/18" + "," + "[COPM] =  ([TM]/600)*100 " + "," + "[GQP]=[TQP1]+[QP]" + "," + "[GTM]=[TM]+[TM1]" + "," + "[CGPA]=[GQP]/33" + "," + "[COPM2]=[GTM]/1100 " + "," + " [RESULT]= 'G.S' WHERE  [" + M2[0] + "] >= 60 and[" + M2[1] + "] >= 60 and[" + M2[2] + "] >= 60 and[" + M2[3] + "] >= 60 and[" + M2[4] + "] >= 60 and[" + M2[5] + "] >= 60 ", conn); conn.Open();
                        semester1updateandnew2(s2);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "2")
                    {
                        string s3 = RMAKERmaskedTextBox1.Text + "SIII";
                        string s2 = RMAKERmaskedTextBox1.Text + "SII";
                        string s1 = RMAKERmaskedTextBox1.Text + "SI";

                        //cmd = new SqlCommand(@" update " + RMA set [TM] = [" + M2[0] + "] + [" + M2[1] + "] + [" + M2[2] + "] + [" + M2[3] + "] + [" + M2[4] + "] + [" + M2[5] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] " + "," + "[SGPA] = [QP]/18" + "," + "[COPM] =  ([TM]/600)*100 " + "," + "[GQP]=[TQP1]+[QP]" + "," + "[GTM]=[TM]+[TM1]" + "," + "[CGPA]=[GQP]/33" + "," + "[COPM2]=[GTM]/1100 " + "," + " [RESULT]= 'G.S' WHERE  [" + M2[0] + "] >= 60 and[" + M2[1] + "] >= 60 and[" + M2[2] + "] >= 60 and[" + M2[3] + "] >= 60 and[" + M2[4] + "] >= 60 and[" + M2[5] + "] >= 60 ", conn); conn.Open();
                        semester1updateandnew1(s1);
                        gradedataGridView11.DataSource = GetDataSply1(s1);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {


                            cmd = new SqlCommand(@" Update " + s2 + " set TQP1 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        semester1updateandnew2(s2);

                        gradedataGridView11.DataSource = GetDataSply2(s2); // datasource k sath
                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s3 + " set TQP2 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM2 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        semester1updateandnew3(s3);



                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "3")
                    {
                        string s4 = RMAKERmaskedTextBox1.Text.Trim() + "SIV";
                        string s3 = RMAKERmaskedTextBox1.Text.Trim() + "SIII";
                        string s2 = RMAKERmaskedTextBox1.Text.Trim() + "SII";
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "SI";
                        semester1updateandnew1(s1);
                        gradedataGridView11.DataSource = GetDataSply1(s1);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {


                            cmd = new SqlCommand(@" Update " + s2 + " set TQP1 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        semester1updateandnew2(s2);

                        gradedataGridView11.DataSource = GetDataSply2(s2);
                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s3 + " set TQP2 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM2 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew3(s3);
                        gradedataGridView11.DataSource = GetDataSply2(s3);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s4 + " set TQP3 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM3 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew4(s4);

                        MessageBox.Show("successfully create table");

                    }

                }
                if (RMAKERFALLradioButton1.Checked == true)
                {

                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "0")
                    {
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "FI";


                        semester1updateandnew1(s1);

                        MessageBox.Show("successfully create result");


                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "1")
                    {
                        string s2 = RMAKERmaskedTextBox1.Text.Trim() + "FII";
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "FI";
                        semester1updateandnew1(s1);
                        gradedataGridView11.DataSource = GetDataSply1(s1);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {


                            cmd = new SqlCommand(@" Update " + s2 + " set TQP1 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew2(s2);
                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "2")
                    {
                        string s3 = RMAKERmaskedTextBox1.Text + "FIII";
                        string s2 = RMAKERmaskedTextBox1.Text + "FII";
                        string s1 = RMAKERmaskedTextBox1.Text + "FI";

                        //cmd = new SqlCommand(@" update " + RMA set [TM] = [" + M2[0] + "] + [" + M2[1] + "] + [" + M2[2] + "] + [" + M2[3] + "] + [" + M2[4] + "] + [" + M2[5] + "] " + "," + "  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] " + "," + "[SGPA] = [QP]/18" + "," + "[COPM] =  ([TM]/600)*100 " + "," + "[GQP]=[TQP1]+[QP]" + "," + "[GTM]=[TM]+[TM1]" + "," + "[CGPA]=[GQP]/33" + "," + "[COPM2]=[GTM]/1100 " + "," + " [RESULT]= 'G.S' WHERE  [" + M2[0] + "] >= 60 and[" + M2[1] + "] >= 60 and[" + M2[2] + "] >= 60 and[" + M2[3] + "] >= 60 and[" + M2[4] + "] >= 60 and[" + M2[5] + "] >= 60 ", conn); conn.Open();
                        semester1updateandnew1(s1);
                        gradedataGridView11.DataSource = GetDataSply1(s1);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {


                            cmd = new SqlCommand(@" Update " + s2 + " set TQP1 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        semester1updateandnew2(s2);

                        gradedataGridView11.DataSource = GetDataSply2(s2); // datasource k sath
                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s3 + " set TQP2 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM2 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        semester1updateandnew3(s3);



                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "3")
                    {
                        string s4 = RMAKERmaskedTextBox1.Text.Trim() + "FIV";
                        string s3 = RMAKERmaskedTextBox1.Text.Trim() + "FIII";
                        string s2 = RMAKERmaskedTextBox1.Text.Trim() + "FII";
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "FI";
                        semester1updateandnew1(s1);
                        gradedataGridView11.DataSource = GetDataSply1(s1);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {


                            cmd = new SqlCommand(@" Update " + s2 + " set TQP1 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        semester1updateandnew2(s2);

                        gradedataGridView11.DataSource = GetDataSply2(s2);
                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s3 + " set TQP2 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM2 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew3(s3);
                        gradedataGridView11.DataSource = GetDataSply2(s3);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s4 + " set TQP3 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM3 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew4(s4);

                        MessageBox.Show("successfully create table");


                    }
                }

            }
        }

        private bool isEmpty7()
        {
            if (RMAKERmaskedTextBox1.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Session TextBox is Empty");
                RMAKERmaskedTextBox1.Focus();
                return false;

            }
            if (RMAKERcomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Session Combobox is Empty");
                return false;
            }
            if (RMAKERSPRINGradioButton2.Checked == false && RMAKERFALLradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Select Spring or Fall");
                return false;
            }

            return true;
        }
        private bool isEmpty8()
        {
            if (RetaierSnmaskedTextBox1.Text.Trim() == "RMcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Session TextBox is Empty");
                RetaierSnmaskedTextBox1.Focus();
                return false;

            }
            if (RetainerKacomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Session Combobox is Empty");
                return false;
            }
            if (RetainerSpradioButton2.Checked == false && RetainerFallradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Select Spring or Fall");
                return false;
            }

            return true;
        }


        private void PositionMethod(string s1)
        {
            double sgpa1 = Convert.ToDouble(gradedataGridView11.Rows[0].Cells[0].Value);
            double sgpa2 = Convert.ToDouble(gradedataGridView11.Rows[1].Cells[0].Value);
            double sgpa3 = Convert.ToDouble(gradedataGridView11.Rows[2].Cells[0].Value);
            double sgpa4 = Convert.ToDouble(gradedataGridView11.Rows[3].Cells[0].Value);

            double Marks1 = Convert.ToDouble(gradedataGridView11.Rows[0].Cells[1].Value);
            double Marks2 = Convert.ToDouble(gradedataGridView11.Rows[1].Cells[1].Value);
            double Marks3 = Convert.ToDouble(gradedataGridView11.Rows[2].Cells[1].Value);
            double Marks4 = Convert.ToDouble(gradedataGridView11.Rows[3].Cells[1].Value);

            //double Rol1 = Convert.ToDouble(gradedataGridView11.Rows[1].Cells[2].Value);
            //double Rol2 = Convert.ToDouble(gradedataGridView11.Rows[2].Cells[2].Value);
            //double Rol3 = Convert.ToDouble(gradedataGridView11.Rows[3].Cells[2].Value);
            //double Rol4 = Convert.ToDouble(gradedataGridView11.Rows[4].Cells[2].Value);

            if (sgpa1 > sgpa2)
            {
                conn.Open();
                cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '1st_Position'  where RollNo = '" + gradedataGridView11.Rows[0].Cells[2].Value + "' ", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                if (Marks1 > Marks2)
                {
                    conn.Open();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '1st_Position'  where RollNo = '" + gradedataGridView11.Rows[0].Cells[2].Value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '2nd_Position'  where RollNo = '" + gradedataGridView11.Rows[1].Cells[2].Value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '2nd_Position'  where RollNo = '" + gradedataGridView11.Rows[0].Cells[2].Value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
            }


            if (sgpa2 > sgpa3)
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '2nd_Position'  where RollNo = '" + gradedataGridView11.Rows[1].Cells[2].Value + "' ", conn);
                conn.Close();
            }
            else
            {
                if (Marks2 > Marks3)
                {
                    conn.Open();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '2nd_Position'  where RollNo = '" + gradedataGridView11.Rows[1].Cells[2].Value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '2nd_Position'  where RollNo = '" + gradedataGridView11.Rows[2].Cells[2].Value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '3rd_Position'  where RollNo = '" + gradedataGridView11.Rows[1].Cells[2].Value + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

                if (sgpa3 > sgpa4)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '3rd_Position'  where RollNo = '" + gradedataGridView11.Rows[2].Cells[2].Value + "' ", conn);
                    conn.Close();
                }
                else
                {
                    if (Marks3 > Marks4)
                    {
                        conn.Open();
                        cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '3rd_Position'  where RollNo = '" + gradedataGridView11.Rows[2].Cells[2].Value + "' ", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                    else
                    {
                        conn.Open();
                        cmd = new SqlCommand(@" Update " + s1 + " set REMARKS =  '3rd_Position'  where RollNo = '" + gradedataGridView11.Rows[3].Cells[2].Value + "' ", conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }


                }
            }
        }



        private void MakeResultofRetainerbutton8_Click_1(object sender, EventArgs e)
        {
            if (isEmpty8())
            {
                if (RetainerSpradioButton2.Checked == true)//for spring
                {
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "0")
                    {
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                        resultmaker1(r1);

                        MessageBox.Show("successfully create result");


                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "1")
                    {
                        string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "SII";
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                        resultmaker1(r1);
                        RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker2(r2);
                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "2")
                    {
                        string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "SIII";
                        string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "SII";
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                        resultmaker1(r1);

                        RetainergrddataGridView1.DataSource = GetDataSply1(r1);
                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker2(r2);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }


                        resultmaker3(r3);
                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "3")
                    {
                        string r4 = RetaierSnmaskedTextBox1.Text.Trim() + "SIV";
                        string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "SIII";
                        string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "SII";
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "SI";
                        resultmaker1(r1);
                        RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker2(r2);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        resultmaker3(r3);

                        RetainergrddataGridView1.DataSource = GetDataSply2(r3);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r4 + " set TQP3 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM3 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker4(r4);
                        MessageBox.Show("successfully create table");

                    }

                }
                if (RetainerFallradioButton1.Checked == true)//for falll
                {
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "0")
                    {
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                        resultmaker1(r1);

                        MessageBox.Show("successfully create result");


                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "1")
                    {
                        string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "FII";
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                        resultmaker1(r1);
                        RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker2(r2);
                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "2")
                    {
                        string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "FIII";
                        string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "FII";
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                        resultmaker1(r1);
                        RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker2(r2);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }


                        resultmaker3(r3);
                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "3")
                    {
                        string r4 = RetaierSnmaskedTextBox1.Text.Trim() + "FIV";
                        string r3 = RetaierSnmaskedTextBox1.Text.Trim() + "FIII";
                        string r2 = RetaierSnmaskedTextBox1.Text.Trim() + "FII";
                        string r1 = RetaierSnmaskedTextBox1.Text.Trim() + "FI";
                        resultmaker1(r1);
                        RetainergrddataGridView1.DataSource = GetDataSply1(r1);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r2 + " set TQP1 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM1 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker2(r2);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r2);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r3 + " set TQP2 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM2 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        resultmaker3(r3);

                        RetainergrddataGridView1.DataSource = GetDataSply2(r3);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r4 + " set TQP3 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM3 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker4(r4);
                        MessageBox.Show("successfully create table");

                    }

                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void yoursemestercomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void RMAKERcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void retainerSemestercomboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void previusRetainerSpringradioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void retainerMaskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (isCheckEmpty6())
            {
                if (comboBox1.SelectedItem.ToString() == "1")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SI";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FI";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "2")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "3")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SIII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FIII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "4")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SIV";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FIV";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                groupBox12.Enabled = true;
            }
        }

        private bool isCheckEmpty6()
        {
            if (maskedTextBox1.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Session TextBox is Empty");
                maskedTextBox1.Focus();
                return false;

            }
            if (comboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Session Combobox is Empty");
                comboBox1.Focus();
                return false;
            }
            if (SradioButton2.Checked == false && FradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Select Spring or Fall");
                return false;
            }

            return true;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView4.DataSource == null)
            {

            }
            else
            {
                #region
                DGVPrinter pr = new DGVPrinter();

                if (comboBox2.SelectedItem.ToString() == "1")
                {
                    pr.Title = "Islamia Univerty of Bahawalpur ";
                    pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 1st SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20101 \t\t CSIT20102 \t\t CSIT20103 \t\t CSIT20104 \t\t CSIT20105 \t\t CSIT20106" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     0  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15 \t TOTAL MARKS IN 1ST SEMESTER= 500" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

                }
                if (comboBox2.SelectedItem.ToString() == "2")
                {
                    pr.Title = "Islamia Univerty of Bahawalpur ";
                    pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 2nd SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20201 \t\t CSIT20202 \t\t CSIT20203 \t\t CSIT20204 \t\t CSIT20205 \t\t CSIT20206" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15      TOTAL MARKS IN 1ST SEMESTER= 500       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     Total Cradit Hours = 33   Total Marks = 1100" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

                }
                if (comboBox2.SelectedItem.ToString() == "3")
                {
                    pr.Title = "Islamia Univerty of Bahawalpur ";
                    pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 3rd SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20301 \t\t CSIT20302 \t\t CSIT20303 \t\t CSIT20304 \t\t CSIT20305 \t\t CSIT20306" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15      TOTAL MARKS IN 1ST SEMESTER= 500       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    Total Cradit Hours = 51   Total Marks = 1700" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

                }
                if (comboBox2.SelectedItem.ToString() == "4")
                {
                    pr.Title = "Islamia Univerty of Bahawalpur ";
                    pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 4th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20401 \t\t CSIT20402 \t\t CSIT20403 \t\t CSIT20404 \t\t CSIT20405 \t\t CSIT20406 \t\t CSIT20407" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15      TOTAL MARKS IN 1ST SEMESTER= 500       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 21     TOTAL MARKS IN 4th SEMESTER = 700    Total Cradit Hours = 72   Total Marks = 2400" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

                }

                pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                pr.PageNumbers = true;
                pr.PageNumberInHeader = false;
                pr.PorportionalColumns = true;


                //pr.PageText = RotateFlipType.Rotate180FlipNone.ToString();

                //pr.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;
                pr.HeaderCellAlignment = StringAlignment.Center;

                //footer
                pr.Footer = "Footer k lye";
                pr.FooterSpacing = 15;

                pr.printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 700, 2500);
                pr.printDocument.DefaultPageSettings.Landscape = true;
                pr.PrintDataGridView(dataGridView4);

                #endregion
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (isEmpty9())
            {
                if (comboBox2.SelectedItem.ToString() == "1")
                {
                    if (SradioButton4.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "SI";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                    if (FradioButton3.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "FI";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                }
                if (comboBox2.SelectedItem.ToString() == "2")
                {
                    if (SradioButton4.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "SII";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                    if (FradioButton3.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "FII";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                }
                if (comboBox2.SelectedItem.ToString() == "3")
                {
                    if (SradioButton4.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "SIII";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                    if (FradioButton3.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "FIII";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                }
                if (comboBox2.SelectedItem.ToString() == "4")
                {
                    if (SradioButton4.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "SIV";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                    if (FradioButton3.Checked == true)
                    {
                        string s = maskedTextBox2.Text + "FIV";
                        dataGridView4.DataSource = GetReportData(s);
                    }
                }
            }
        }

        private bool isEmpty9()
        {

            if (maskedTextBox2.Text.Trim() == "Mcs  _")
            {
                InformationAndErrorClass.ErrorMessage("Session TextBox is Empty");
                maskedTextBox2.Focus();
                return false;

            }
            if (comboBox2.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Session Combobox is Empty");
                comboBox2.Focus();
                return false;
            }
            if (SradioButton4.Checked == false && FradioButton3.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Select Spring or Fall");
                return false;
            }

            return true;


        }

        private DataTable GetReportData(string s)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from [dbo]." + s, conn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            return dt;
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            //dataGridView3.ScrollBars = ScrollBars.Horizontal;
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {
            //dataGridView4.ScrollBars = ScrollBars.Horizontal;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();


            //if (comboBox1.SelectedItem.ToString() == "1")
            //{
            //    pr.Title = "Islamia Univerty of Bahawalpur ";
            //    pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 1st SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20101 \t\t CSIT20102 \t\t CSIT20103 \t\t CSIT20104 \t\t CSIT20105 \t\t CSIT20106" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     0  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15 \t TOTAL MARKS IN 1ST SEMESTER= 500" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            //}

            if (comboBox1.SelectedItem.ToString() == "1")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 1st SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20101 \t\t CSIT20102 \t\t CSIT20103 \t\t CSIT20104 \t\t CSIT20105 \t\t CSIT20106" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     0  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15 \t TOTAL MARKS IN 1ST SEMESTER= 500" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "2")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 2nd SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20201 \t\t CSIT20202 \t\t CSIT20203 \t\t CSIT20204 \t\t CSIT20205 \t\t CSIT20206" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15      TOTAL MARKS IN 1ST SEMESTER= 500       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     Total Cradit Hours = 33   Total Marks = 1100" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "3")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 3rd SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20301 \t\t CSIT20302 \t\t CSIT20303 \t\t CSIT20304 \t\t CSIT20305 \t\t CSIT20306" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15      TOTAL MARKS IN 1ST SEMESTER= 500       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    Total Cradit Hours = 51   Total Marks = 1700" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "4")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET MCS [MORNING] 4th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT20401 \t\t CSIT20402 \t\t CSIT20403 \t\t CSIT20404 \t\t CSIT20405 \t\t CSIT20406 \t\t CSIT20407" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 15      TOTAL MARKS IN 1ST SEMESTER= 500       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 21     TOTAL MARKS IN 4th SEMESTER = 700    Total Cradit Hours = 72   Total Marks = 2400" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }



            pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            pr.PageNumbers = true;
            pr.PageNumberInHeader = false;
            pr.PorportionalColumns = true;


            //pr.PageText = RotateFlipType.Rotate180FlipNone.ToString();

            //pr.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;
            pr.HeaderCellAlignment = StringAlignment.Center;

            //footer
            pr.Footer = "Footer k lye";
            pr.FooterSpacing = 15;

            pr.printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 700, 3500);
            pr.printDocument.DefaultPageSettings.Landscape = true;
            pr.PrintDataGridView(dataGridView3);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {

            printDocument1.Print();             // print k lye save kr k print krna
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            //printDocument1.DefaultPageSettings.PaperSize.Height = 100000;
            int maxWidth = Convert.ToInt32(printDocument1.DefaultPageSettings.PrintableArea.Width) - 40;


            Bitmap bmp = Properties.Resources.logo1;
            Image img = bmp;
            e.Graphics.DrawImage(img, 15, 15, img.Width, img.Height);

            e.Graphics.DrawString("MCS Session : 2016-2018 (SPRING)", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(250, 240));

            e.Graphics.DrawString("Serial No: DCS / 1671 / BWN", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 270));

            e.Graphics.DrawString("Date of Issuancet:  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 290));
            e.Graphics.DrawString("Date Declaration of Result:  " + DateTime.Now.Date, new Font("Arial ", 12), Brushes.Black, new Point(550, 290));//25 left sy r 270 right sy

            e.Graphics.DrawString("Roll No:   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 315));
            e.Graphics.DrawString("Registration No:   " + DateTime.Now.Date, new Font("Arial ", 12), Brushes.Black, new Point(550, 315));//25 left sy r 270 right sy

            e.Graphics.DrawString("Name:   ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 340));
            e.Graphics.DrawString("Father's Name:   " + DateTime.Now.Date, new Font("Arial ", 12), Brushes.Black, new Point(550, 340));//25 left sy r 270 right sy


            ///yha sy start hojayga heading wala 
            e.Graphics.DrawString("Semester  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 370));//  40 left sy right krny k lye  or  370 nichy krny k lye
            e.Graphics.DrawString("Course Code  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 370));
            e.Graphics.DrawString("        Course Title  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(240, 370));
            e.Graphics.DrawString("     CH  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(370, 370));

            e.Graphics.DrawString("    Marks  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(440, 370));
            e.Graphics.DrawString("    Obt.  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(430, 390));
            e.Graphics.DrawString("Max.", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 390));


            e.Graphics.DrawString("GPA", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 370));
            e.Graphics.DrawString("Grade", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 370));
            e.Graphics.DrawString("Remarks  ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(770, 370));

            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(40, 400));

            //ab 400 sy nichy ly k jana pryga mjy wnra ye ak dosry k opr  chr jayge  
            //spring 2016 ko ni cherna ab
            e.Graphics.DrawString("Spring \n 2016  ", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(40, 550));//  40 left sy right krny k lye  or  370 nichy krny k lye

            e.Graphics.DrawString("CSIT-21101", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 450));
            e.Graphics.DrawString("Programming \nFundamentals", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 450));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 450));
            e.Graphics.DrawString("81", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 450));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 450));
            e.Graphics.DrawString("3.7", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 450));
            e.Graphics.DrawString("B+", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 450));

            //isko b ni cherna ha ab SGPA ko
            e.Graphics.DrawString("SGPA \n1st \nSemester \n3.54", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(750, 530));
            // second line k lye
            e.Graphics.DrawString("CSIT-21102", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 500));
            e.Graphics.DrawString("Digital Logic \nDesign", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 500));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 500));
            e.Graphics.DrawString("71", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 500));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 500));
            e.Graphics.DrawString("3.1", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 500));
            e.Graphics.DrawString("B", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 500));

            //third line k lye  
            e.Graphics.DrawString("CSIT-21103", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 550));
            e.Graphics.DrawString("Database \nSystem", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 550));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 550));
            e.Graphics.DrawString("89", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 550));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 550));
            e.Graphics.DrawString("4", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 550));
            e.Graphics.DrawString("A", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 550));

            //fourth k lye
            e.Graphics.DrawString("CSIT-21104", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 600));
            e.Graphics.DrawString("Operating \nSystem", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 600));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 600));
            e.Graphics.DrawString("75", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 600));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 600));
            e.Graphics.DrawString("3.3", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 600));
            e.Graphics.DrawString("B", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 600));

            //fifth kk lye 
            e.Graphics.DrawString("CSIT-21105", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 650));
            e.Graphics.DrawString("English \nComprehension \n& Technical \n& Business \nWriting", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 650));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 650));
            e.Graphics.DrawString("89", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 650));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 650));
            e.Graphics.DrawString("3.6", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 650));
            e.Graphics.DrawString("B", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 650));

            //six k lye
            e.Graphics.DrawString("CSIT-21106", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, 750));
            e.Graphics.DrawString("Islamic \nStudies", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 750));
            e.Graphics.DrawString("                        Pass ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 750));
            //e.Graphics.DrawString("89", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(450, 700));
            //e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, 700));
            //e.Graphics.DrawString("3.6", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(600, 700));
            //e.Graphics.DrawString("B", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(670, 700));

            //semester k bad wali line
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(40, 800));

            //1st lines of Second Semester
            e.Graphics.DrawString("CSIT-21201", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 850));
            e.Graphics.DrawString("Data Structure\nand\nAlgorithms", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 850));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 850));
            e.Graphics.DrawString("81", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 850));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 850));
            e.Graphics.DrawString("3.7", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 850));
            e.Graphics.DrawString("B+", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 850));

            //2nd lines of second semester
            e.Graphics.DrawString("CSIT-21202", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 920));
            e.Graphics.DrawString("Data\nCommunication\n& Networking", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 920));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 920));
            e.Graphics.DrawString("81", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 920));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 920));
            e.Graphics.DrawString("3.7", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 920));
            e.Graphics.DrawString("B+", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 920));

            //3rd lines of second semester
            e.Graphics.DrawString("CSIT-21203", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 990));
            e.Graphics.DrawString("Web\nProgramming", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 990));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 990));
            e.Graphics.DrawString("81", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 990));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 990));
            e.Graphics.DrawString("3.7", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 990));
            e.Graphics.DrawString("B+", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 990));

            //4rth lines of second semester
            e.Graphics.DrawString("CSIT-21204", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 1040));
            e.Graphics.DrawString("Object\nOriented\nProgramming", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1040));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 1040));
            e.Graphics.DrawString("81", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 1040));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 1040));
            e.Graphics.DrawString("3.7", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 1040));
            e.Graphics.DrawString("B+", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 1040));

            //5th lines of second semester
            e.Graphics.DrawString("CSIT-21205", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(150, 1100));
            e.Graphics.DrawString("Software\nEngineering–I", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 1100));
            e.Graphics.DrawString("3 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 1100));
            e.Graphics.DrawString("81", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(450, 1100));
            e.Graphics.DrawString("100", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 1100));
            e.Graphics.DrawString("3.7", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 1100));
            e.Graphics.DrawString("B+", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 1100));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(40, 1150));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(40, 1170));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(40, 1190));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(40, 1220));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(40, 1250));
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 100, 2500);


        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();  // print preview k lye
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            rForm rf = new rForm();
            rf.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            resultmaskedTextBox98.Visible = true;
            RetainermaskedTextBox5.Visible = false;
            groupBox8.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            resultmaskedTextBox98.Visible = false;
            RetainermaskedTextBox5.Visible = true;
            groupBox8.Enabled = true;

        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook |*.xls;*.XLS;", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    res = reader.AsDataSet();
                    ChooseShetcomboBox4.Items.Clear();
                    foreach (DataTable dt in res.Tables)
                    {
                        ChooseShetcomboBox4.Items.Add(dt.TableName);
                        reader.Close();
                    }
                }
            }

        }

        private void ChooseShetcomboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            RdataGridView5.DataSource = res.Tables[ChooseShetcomboBox4.SelectedIndex];

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isEmpty6())
            {
                for (int i = 10; i < RdataGridView5.Rows.Count; i++)
                {

                    if (RdataGridView5.Rows[i].Cells[0].Value is DBNull)
                    {
                        break;
                    }
                    else
                    {
                        double s = Convert.ToDouble(RdataGridView5.Rows[i].Cells[5].Value);

                        conn.Open();
                        cmd = new SqlCommand(@"UPDATE " + label16.Text + " Set " + label15.Text + "='" + RdataGridView5.Rows[i].Cells[5].Value + "' WHERE RollNo = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                        //YHA quality points wala colum ko pic krna pryga
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        //////yaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa 
                        //int q =    afterResultdataGridView2.Rows[i].Cells[5].Value  ;





                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "0")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP1 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "1")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP2 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "2")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP3 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "3")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP4 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "4")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP5 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "5")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            // Islamyat k QP ni hota Q k wo non cradit ha .................................................................
                            if (RRetainerResultcomboBox2.SelectedIndex.ToString() == "0")
                            {
                                conn.Open();

                                cd = new SqlCommand("Update " + label16.Text + " set QP6 = 0  ", conn);
                                cd.ExecuteNonQuery();
                                conn.Close();
                            }
                            else
                            {
                                conn.Open();

                                cd = new SqlCommand("Update " + label16.Text + " set QP6 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                                cd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        if (RRetainerScomboBox1.SelectedIndex.ToString() == "6")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP7 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }

                }

                ChooseShetcomboBox4.Items.Clear();
                RdataGridView5.Columns.Clear();
            }
        }

        private bool isEmpty6()
        {
            if (ChooseShetcomboBox4.Text == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Select Sheet");
                ChooseShetcomboBox4.Focus();
                return false;
            }
            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            maskedTextBox1.Clear();
            SradioButton2.Checked = false;
            FradioButton1.Checked = false;
            groupBox12.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            dataGridView4.Columns.Clear();
            maskedTextBox2.Clear();
            SradioButton4.Checked = false;
            FradioButton3.Checked = false;
            groupBox13.Enabled = false;
        }

        private void getRetainerRollnotextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }

        private static void EnterOnlyNumberMethod(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                InformationAndErrorClass.WarningMessage("Enter Only Number");
                e.Handled = true;
            }
        }

        private void rollNotextBox98_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }

        private void markstextBox98_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterOnlyNumberMethod(e);
        }
    }
}
