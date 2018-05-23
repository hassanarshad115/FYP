
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
    public partial class BSCSUserControl : UserControl
    {
        public BSCSUserControl()
        {
            InitializeComponent();
        }

        //declare subjects
        public static string[] B1 = new string[6] { "Introduction to Coputing", "Financial Accounting", "English Comprehension", "Calculus and Analytical Geometry", "Fundamental's of Algorithm", "Islamiat & Pakistan Studies" };
        public static string[] B2 = new string[6] { "Programming Fundamental's", "Basic Electronics", "Multivarible Calculus", "Technical & Businesss Writing", "Principle's of Management", "Discrete Structure" };
        public static string[] B3 = new string[6] { "Object Oriented Programming", "Theory of Automata Theory and Formal Languages", "Differential Equation", "Communication Skills", "Probability and Statistics", "Data Structures and Algorithms" };
        public static string[] B4 = new string[6] { "Database System", "Software Engineering - I", "Linear Algebra", "Digital Logic Design", "Data Communication", "Web Programming" };
        public static string[] B5 = new string[6] { "Software Engineering - II", "Psychology ", "Computer Organization and Assembly Language", "Numerical Analysis", "Visual Programming", "Computer Networks" };
        public static string[] B6 = new string[6] { "Computer Architecture", "Advance Object Oriented Programming", "Artificial Intelligence", "Computer Graphics", "Operating System Concepts", "Distributed Database Systems" };
        public static string[] B7 = new string[4] { "Compiler Construction", "Design and Analysis of Algorithm", "Elective-I", "Project-1" };
        public static string[] B8 = new string[4] { "Human Resource Management", "Human Computer Interaction", "Elective-II", "Project-II" };

        SqlConnection conn = new SqlConnection("Data Source=HASSAN-MALIK;Initial Catalog=FYPDB;Integrated Security=True");

        private void BSCSUserControl_Load(object sender, EventArgs e)
        {

        }

        private void newSemesterAfterFirstbutton5_Click(object sender, EventArgs e)
        {

        }

        private void insertbutton2_Click(object sender, EventArgs e)
        {

        }

        private void newsemestersheetcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newsemesterchosefilebutton2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void session1comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isCheckEmpty())
            {


                SqlCommand cmd;


                if (springradioButton1.Checked == true)//for spring
                {
                    if (session1comboBox1.SelectedIndex.ToString() == "0")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SIV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
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
                    if (session1comboBox1.SelectedIndex.ToString() == "4")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "SV";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "SIV";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "5")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SVI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "SVI";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "SV";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "6")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SVII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "SVII";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "SVI";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "7")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "SVIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B8[0] + "] float NULL ,[QP1] float NULL ,[" + B8[1] + "] float NULL ,[QP2] float NULL ,[" + B8[2] + "] float NULL ,[QP3] float NULL ,[" + B8[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP7] float NULL,[TM7] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE8] CHAR(10) NULL,[COPM8] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "SVIII";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "SVII";

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

                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
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
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FIII";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "FII";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "3")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FIV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FIV";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "FIII";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "4")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FV" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FV";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "FIV";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "5")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FVI" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FVI";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "FV";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "6")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FVII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FVII";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "FVI";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }
                    if (session1comboBox1.SelectedIndex.ToString() == "7")
                    {
                        string q = "CREATE TABLE [dbo]." + sessionmaskedTextBox1.Text.Trim() + "FVIII" + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B8[0] + "] float NULL ,[QP1] float NULL ,[" + B8[1] + "] float NULL ,[QP2] float NULL ,[" + B8[2] + "] float NULL ,[QP3] float NULL ,[" + B8[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP7] float NULL,[TM7] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE8] CHAR(10) NULL,[COPM8] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                        cmd = new SqlCommand(q, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        toplabel6.Text = sessionmaskedTextBox1.Text + "FVIII";//yha concatinate kia h session ko 
                        string d = sessionmaskedTextBox1.Text + "FVII";

                        newsemesterchosefilebutton2.Visible = false;
                        newsemestersheetcomboBox1.Visible = false;
                        insertbutton2.Visible = false;

                        newsemesterdataGridView1.DataSource = GetData23(d);//previus table ka data show krny k lye
                        MessageBox.Show("successfully create table");
                        newSemesterAfterFirstbutton5.Visible = true;
                    }





                }

                newsemestergroupBox1.Enabled = true;

            }
        }

        private bool isCheckEmpty()
        {
            if (sessionmaskedTextBox1.Text.Trim() == "Bscs  _")
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

        private DataTable GetDataGrade(string V)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [COPM] from " + V, conn);
            adapter.Fill(dt);
            return dt;
        }
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
        private void GetGrade4(string valueOfMaskTextBox3)
        {
            conn.Open();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5]= 'A+' where [COPM5] <= 100 AND [COPM5] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5]= 'A' where [COPM5] < 95 AND [COPM5] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5]= 'B+' WHERE [COPM5] < 85 AND [COPM5] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5]= 'B' where [COPM5] < 80 AND [COPM5] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5] = 'C' where [COPM5]< 70 AND [COPM5] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5] = 'D' where [COPM5]< 60 AND [COPM5] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE5] = 'F' where [COPM5]< 50 AND [COPM5] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetGrade5(string valueOfMaskTextBox3)
        {
            conn.Open();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6]= 'A+' where [COPM6] <= 100 AND [COPM6] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6]= 'A' where [COPM6] < 95 AND [COPM6] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6]= 'B+' WHERE [COPM6] < 85 AND [COPM6] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6]= 'B' where [COPM6] < 80 AND [COPM6] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6] = 'C' where [COPM6]< 70 AND [COPM6] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6] = 'D' where [COPM6]< 60 AND [COPM6] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE6] = 'F' where [COPM6]< 50 AND [COPM6] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetGrade6(string valueOfMaskTextBox3)
        {
            conn.Open();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7]= 'A+' where [COPM7] <= 100 AND [COPM7] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7]= 'A' where [COPM7] < 95 AND [COPM7] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7]= 'B+' WHERE [COPM7] < 85 AND [COPM7] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7]= 'B' where [COPM7] < 80 AND [COPM7] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7] = 'C' where [COPM7]< 70 AND [COPM7] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7] = 'D' where [COPM7]< 60 AND [COPM7] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE7] = 'F' where [COPM7]< 50 AND [COPM7] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetGrade7(string valueOfMaskTextBox3)
        {
            conn.Open();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8]= 'A+' where [COPM8] <= 100 AND [COPM8] >=95  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8]= 'A' where [COPM8] < 95 AND [COPM8] >=85  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8]= 'B+' WHERE [COPM8] < 85 AND [COPM8] >=80 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8]= 'B' where [COPM8] < 80 AND [COPM8] >=70 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8] = 'C' where [COPM8]< 70 AND [COPM8] >=60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8] = 'D' where [COPM8]< 60 AND [COPM8] >=50 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@"update " + valueOfMaskTextBox3 + " set [GRADE8] = 'F' where [COPM8]< 50 AND [COPM8] >=0 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }






        private void semester1updateandnew1(string s1)
        {

            ResultSemester1(s1); // generate result 

            gradedataGridView11.DataSource = GetDataGrade(s1); // for fill copm

            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s1); // make grade 
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

            gradedataGridView11.DataSource = GetDataGrade(s2); // for copm
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s2); // take grade
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade1(s2); // take grade
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
        private void semester1updateandnew5(string s5)
        {

            ResultSemester5(s5);

            gradedataGridView11.DataSource = GetDataGrade(s5);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s5);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade4(s5);
            }

            //conn.Close();
        }
        private void semester1updateandnew6(string s6)
        {

            ResultSemester6(s6);

            gradedataGridView11.DataSource = GetDataGrade(s6);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s6);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade5(s6);
            }

            //conn.Close();
        }
        private void semester1updateandnew7(string s7)
        {
            // string s4 = RMAKERmaskedTextBox1.Text.Trim() + "SIV";

            //conn.Open();

            ResultSemester7(s7);

            gradedataGridView11.DataSource = GetDataGrade(s7);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s7);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade6(s7);
            }

            //conn.Close();
        }
        private void semester1updateandnew8(string s8)
        {
            ResultSemester8(s8);

            gradedataGridView11.DataSource = GetDataGrade(s8);
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade(s8);
            }
            for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
            {
                GetGrade7(s8);
            }

            //conn.Close();
        }


        SqlCommand cmd;

        private void ResultSemester1(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B1[0] + "] + [" + B1[1] + "] + [" + B1[2] + "] + [" + B1[3] + "] + [" + B1[4] + "]+ [" + B1[5] + "] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] =round( [QP]/18 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [TQP1]=[QP] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [TM1]=[TM] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([SGPA],2)  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM1]=round([COPM] ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set   [RESULT] = 'G.S' WHERE [" + B1[0] + "] >= 60 and [" + B1[1] + "] >= 60 and [" + B1[2] + "] >= 60 and [" + B1[3] + "] >= 60 and [" + B1[4] + "] >= 60 and [" + B1[5] + "] >= 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]= '' ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]= 'CSIT01101' WHERE [" + B1[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01102') WHERE [" + B1[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01103') WHERE [" + B1[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01104') WHERE [" + B1[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01105') WHERE [" + B1[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01106') WHERE [" + B1[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void ResultSemester2(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B2[0] + "] + [" + B2[1] + "] + [" + B2[2] + "] + [" + B2[3] + "] + [" + B2[4] + "] + [" + B2[5] + "] ", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round([QP]/18 ,2) ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100 ,2)  ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [GQP]=[TQP1]+[QP] ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM1] ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/36 ,2)", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [COPM2] = round(([GTM] / 1200 )*100 ,2) ", conn); cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B2[0] + "] >= 60 and[" + B2[1] + "] >= 60 and[" + B2[2] + "] >= 60 and[" + B2[3] + "] >= 60 and[" + B2[4] + "] >= 60 and[" + B2[5] + "] >= 60 ", conn);

            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01201') WHERE [" + B2[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01202') WHERE [" + B2[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01203') WHERE [" + B2[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01204') WHERE [" + B2[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01205') WHERE [" + B2[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01206') WHERE [" + B2[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void ResultSemester3(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B3[0] + "] + [" + B3[1] + "] + [" + B3[2] + "] + [" + B3[3] + "] + [" + B3[4] + "]  + [" + B3[5] + "] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] =round( [QP]/18 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP2] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM2] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/54 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM3]= round(( [GTM]/1800 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B3[0] + "] >= 60 and[" + B3[1] + "] >= 60 and[" + B3[2] + "] >= 60 and[" + B3[3] + "] >= 60 and[" + B3[4] + "] >= 60 and[" + B3[5] + "] >= 60 ", conn);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01301') WHERE [" + B3[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01302') WHERE [" + B3[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01303') WHERE [" + B3[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01304') WHERE [" + B3[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01305') WHERE [" + B3[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01306') WHERE [" + B3[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void ResultSemester4(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B4[0] + "] + [" + B4[1] + "] + [" + B4[2] + "] + [" + B4[3] + "] + [" + B4[4] + "] + [" + B4[5] + "]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] =round( [QP]/18,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP3] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM3] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/72 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM4] = round(( [GTM]/2400 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B4[0] + "] >= 60 and[" + B4[1] + "] >= 60 and[" + B4[2] + "] >= 60 and[" + B4[3] + "] >= 60 and[" + B4[4] + "] >= 60 and[" + B4[5] + "] >= 60  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01401') WHERE [" + B4[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01402') WHERE [" + B4[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01403') WHERE [" + B4[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01404') WHERE [" + B4[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01405') WHERE [" + B4[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01406') WHERE [" + B4[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        private void ResultSemester5(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B5[0] + "] + [" + B5[1] + "] + [" + B5[2] + "] + [" + B5[3] + "] + [" + B5[4] + "] + [" + B5[5] + "]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] =round( [QP]/18,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP4] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM4] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/90 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM4] =round( ( [GTM]/3000 )*100 2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B5[0] + "] >= 60 and[" + B5[1] + "] >= 60 and[" + B5[2] + "] >= 60 and[" + B5[3] + "] >= 60 and[" + B5[4] + "] >= 60 and[" + B5[5] + "] >= 60  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01501') WHERE [" + B5[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01502') WHERE [" + B5[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01503') WHERE [" + B5[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01504') WHERE [" + B5[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01505') WHERE [" + B5[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01506') WHERE [" + B5[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        private void ResultSemester6(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B6[0] + "] + [" + B6[1] + "] + [" + B6[2] + "] + [" + B6[3] + "] + [" + B6[4] + "] + [" + B6[5] + "]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4]+[QP5]+[QP6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] =round( [QP]/18 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/600)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP5] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM5] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/108 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM4] =round( ( [GTM]/3600 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B6[0] + "] >= 60 and[" + B6[1] + "] >= 60 and[" + B6[2] + "] >= 60 and[" + B6[3] + "] >= 60 and[" + B6[4] + "] >= 60 and[" + B6[5] + "] >= 60  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01601') WHERE [" + B6[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01602') WHERE [" + B6[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01603') WHERE [" + B6[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01604') WHERE [" + B6[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01605') WHERE [" + B6[4] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01606') WHERE [" + B6[5] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();


            conn.Close();

        }
        private void ResultSemester7(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B7[0] + "] + [" + B7[1] + "] + [" + B7[2] + "] + [" + B7[3] + "]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round( [QP]/12 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/400)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM6] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/120 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM4] =round( ( [GTM]/4000 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B7[0] + "] >= 60 and[" + B7[1] + "] >= 60 and[" + B7[2] + "] >= 60 and[" + B7[3] + "] >= 60   ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01701') WHERE [" + B7[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01702') WHERE [" + B7[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01703') WHERE [" + B7[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01704') WHERE [" + B7[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void ResultSemester8(string j)
        {
            conn.Open();
            cmd = new SqlCommand(@" update " + j + " set [TM] = [" + B8[0] + "] + [" + B8[1] + "] + [" + B8[2] + "] + [" + B8[3] + "]  ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set  [QP] = [QP1]+[QP2]+[QP3]+[QP4] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [SGPA] = round([QP]/12 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM] = round( ([TM]/400)*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GQP]=[QP]+[TQP7] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [GTM]=[TM]+[TM7] ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [CGPA]=round([GQP]/132 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [COPM4] =round( ( [GTM]/4400 )*100 ,2) ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [RESULT]= 'G.S' WHERE  [" + B8[0] + "] >= 60 and[" + B8[1] + "] >= 60 and[" + B8[2] + "] >= 60 and[" + B8[3] + "] >= 60   ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01801') WHERE [" + B8[0] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01802') WHERE [" + B8[1] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01803') WHERE [" + B8[2] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(@" update " + j + " set [REMARKS]=  CONCAT([REMARKS],' ','CSIT01804') WHERE [" + B8[3] + "] < 60 ", conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }


        private DataTable GetDataSply1(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] , [TQP1] , [TM1],[REMARKS] from [dbo]." + o + " ", conn);

            adapter.Fill(dt);
            return dt;
        }
        private DataTable GetDataSply2(string o)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select [RollNo] , [GQP] , [GTM],[REMARKS] from [dbo]." + o + " ", conn);
            adapter.Fill(dt);
            //ya tqp2 and tm2 man ani cahya
            return dt;
        }

        private void RMAKERSAVEbutton5_Click(object sender, EventArgs e)
        {
            if (isEmpty7())
            {
                if (RMAKERSPRINGradioButton2.Checked == true)//for spring
                {
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "0")
                    {
                        string s1 = RMAKERmaskedTextBox1.Text.Trim() + "SI";


                        semester1updateandnew1(s1);

                        MessageBox.Show("successfully create result");


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
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "4")
                    {
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "SV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "5")
                    {
                        string s6 = RMAKERmaskedTextBox1.Text.Trim() + "SVI";
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "SV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);
                        gradedataGridView11.DataSource = GetDataSply2(s5);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s6 + " set TQP5 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM5 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew6(s6);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "6")
                    {
                        string s7 = RMAKERmaskedTextBox1.Text.Trim() + "SVII";
                        string s6 = RMAKERmaskedTextBox1.Text.Trim() + "SVI";
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "SV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);
                        gradedataGridView11.DataSource = GetDataSply2(s5);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s6 + " set TQP5 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM5 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew6(s6);
                        gradedataGridView11.DataSource = GetDataSply2(s6);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s7 + " set TQP6 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM6 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew7(s7);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "7")
                    {
                        string s8 = RMAKERmaskedTextBox1.Text.Trim() + "SVIII";
                        string s7 = RMAKERmaskedTextBox1.Text.Trim() + "SVII";
                        string s6 = RMAKERmaskedTextBox1.Text.Trim() + "SVI";
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "SV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);
                        gradedataGridView11.DataSource = GetDataSply2(s5);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s6 + " set TQP5 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM5 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew6(s6);
                        gradedataGridView11.DataSource = GetDataSply2(s6);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s7 + " set TQP6 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM6 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew7(s7);
                        gradedataGridView11.DataSource = GetDataSply2(s7);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s8 + " set TQP7 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM7 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew8(s8);


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
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "4")
                    {
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "FV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "5")
                    {
                        string s6 = RMAKERmaskedTextBox1.Text.Trim() + "FVI";
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "FV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);
                        gradedataGridView11.DataSource = GetDataSply2(s5);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s6 + " set TQP5 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM5 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew6(s6);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "6")
                    {
                        string s7 = RMAKERmaskedTextBox1.Text.Trim() + "FVII";
                        string s6 = RMAKERmaskedTextBox1.Text.Trim() + "FVI";
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "FV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);
                        gradedataGridView11.DataSource = GetDataSply2(s5);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s6 + " set TQP5 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM5 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew6(s6);
                        gradedataGridView11.DataSource = GetDataSply2(s6);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s7 + " set TQP6 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM6 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew7(s7);


                        MessageBox.Show("successfully create table");

                    }
                    if (RMAKERcomboBox1.SelectedIndex.ToString() == "7")
                    {
                        string s8 = RMAKERmaskedTextBox1.Text.Trim() + "FVIII";
                        string s7 = RMAKERmaskedTextBox1.Text.Trim() + "FVII";
                        string s6 = RMAKERmaskedTextBox1.Text.Trim() + "FVI";
                        string s5 = RMAKERmaskedTextBox1.Text.Trim() + "FV";
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
                        gradedataGridView11.DataSource = GetDataSply2(s4);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s5 + " set TQP4 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM4 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew5(s5);
                        gradedataGridView11.DataSource = GetDataSply2(s5);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s6 + " set TQP5 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM5 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew6(s6);
                        gradedataGridView11.DataSource = GetDataSply2(s6);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s7 + " set TQP6 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM6 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew7(s7);
                        gradedataGridView11.DataSource = GetDataSply2(s7);

                        for (int i = 0; i < gradedataGridView11.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + s8 + " set TQP7 = '" + gradedataGridView11.Rows[i].Cells[1].Value + "' , " + " TM7 = '" + gradedataGridView11.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + gradedataGridView11.Rows[i].Cells[3].Value + "' where RollNo = '" + gradedataGridView11.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        semester1updateandnew8(s8);


                        MessageBox.Show("successfully create table");

                    }




                }
            }
        }
        private bool isEmpty7()
        {
            if (RMAKERmaskedTextBox1.Text.Trim() == "Bscs  _")
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

        DataSet res = new DataSet();

        private void newsemesterchosefilebutton2_Click_1(object sender, EventArgs e)
        {
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

        private void newsemestersheetcomboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            newsemesterdataGridView1.DataSource = res.Tables[newsemestersheetcomboBox1.SelectedIndex];

        }

        private void insertbutton2_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("insert data successfully");

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

        private void newSemesterAfterFirstbutton5_Click_1(object sender, EventArgs e)
        {
            if (isEmpty5())
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
                else
            if (session1comboBox1.SelectedIndex.ToString() == "4")
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

                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[QP4],[TM4])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }
                }
                else
            if (session1comboBox1.SelectedIndex.ToString() == "5")
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

                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[QP5],[TM5])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }
                }
                else
            if (session1comboBox1.SelectedIndex.ToString() == "6")
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

                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[QP6],[TM6])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }
                }
                else
            if (session1comboBox1.SelectedIndex.ToString() == "7")
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

                                SqlCommand cm = new SqlCommand(@"INSERT INTO " + toplabel6.Text.Trim() + "([RollNo],[RegdNo],[Name],[FatherName],[QP7],[TM7])VALUES('" + newsemesterdataGridView1.Rows[i].Cells[0].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[1].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[2].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[3].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[4].Value + "','" + newsemesterdataGridView1.Rows[i].Cells[5].Value + "')", conn);
                                conn.Open();
                                cm.ExecuteNonQuery();
                                conn.Close();
                            }

                        }
                    }
                }



                MessageBox.Show("insert data successfully");

            }

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
                    yoursemestercomboBox2.Items.Add(B1[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(B2[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "2")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(B3[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "3")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(B4[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "4")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(B5[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "5")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox2.Items.Add(B6[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "6")
            {
                for (int i = 0; i < 4; i++)
                {
                    yoursemestercomboBox2.Items.Add(B7[i]);
                }
            }
            if (InresultsemestercomboBox1.SelectedIndex.ToString() == "7")
            {
                for (int i = 0; i < 4; i++)
                {
                    yoursemestercomboBox2.Items.Add(B8[i]);
                }
            }

        }
        private bool isCheckEmpty20()
        {

            if (resultmaskedTextBox1.Text.Trim() == "Bscs  _")
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty20())
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
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "5")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SV";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "6")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SVI";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "7")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SVII";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "8")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "SVIII";
            }
            topAfterResultlabel2.Text = "[" + yoursemestercomboBox2.Text + "]";
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
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "5")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FV";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "6")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FVI";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "7")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FVII";
            }
            if (InresultsemestercomboBox1.SelectedItem.ToString() == "8")
            {
                topAfterResultlabel1.Text = resultmaskedTextBox1.Text + "FVIII";
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (isSheetEmpty())
            {
                SqlCommand cmd, cd;
                for (int i = 10; i < afterResultdataGridView2.Rows.Count; i++)
                {

                    if (afterResultdataGridView2.Rows[i].Cells[0].Value is DBNull)
                    {
                        break;
                    }
                    else
                    {
                        double s = Convert.ToDouble(afterResultdataGridView2.Rows[i].Cells[5].Value);

                        conn.Open();
                        cmd = new SqlCommand(@"UPDATE " + topAfterResultlabel1.Text + " Set " + topAfterResultlabel2.Text + "='" + afterResultdataGridView2.Rows[i].Cells[5].Value + "' WHERE RollNo = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                        //YHA quality points wala colum ko pic krna pryga
                        cmd.ExecuteNonQuery();
                        conn.Close();



                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "0")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP1 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "1")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP2 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "2")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP3 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "3")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP4 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "4")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP5 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (yoursemestercomboBox2.SelectedIndex.ToString() == "5")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + topAfterResultlabel1.Text + " set QP6 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + afterResultdataGridView2.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();

                        }

                    }

                }
                MessageBox.Show("successfully");

            }
        }

        private bool isSheetEmpty()
        {
            if (afterResultcomboBox.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Please Select Sheet");
                return false;
            }
            return true;
        }

        private void RMAKERmaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        string rs8 = "";
        string rs7 = "";
        string rs6 = "";
        string rs5 = "";
        string rs4 = "";
        string rs3 = "";
        string rs2 = "";
        string rs1 = "";
        string fs7 = "";
        string fs6 = "";
        string fs5 = "";
        string fs4 = "";
        string fs3 = "";
        string fs2 = "";
        string fs1 = "";

        private void button5_Click(object sender, EventArgs e)
        {

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
                                // string q = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";
                                string q = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                cmd = new SqlCommand(q, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
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

                                rs2 = retainerMaskedTextBox2.Text.Trim() + "SII";
                                rs1 = RPREmaskedTextBox1.Text.Trim() + "SI";
                                // previousmaskedTextBox1


                                //string q1 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";
                                string q1 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");


                            }


                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs2 = retainerMaskedTextBox2.Text.Trim() + "SII";

                                fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";

                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                // string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //   string q = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }


                            MessageBox.Show("successfully create table");

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

                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";



                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";


                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("successfully create table");

                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs3 = retainerMaskedTextBox2.Text.Trim() + "SIII";
                                rs2 = RPREmaskedTextBox1.Text.Trim() + "SII";

                                string q = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //string q = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("successfully create table");

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
                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                // string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //    string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs4 = retainerMaskedTextBox2.Text.Trim() + "SIV";
                                rs3 = RPREmaskedTextBox1.Text.Trim() + "SIII";

                                string q = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "4")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs5 = retainerMaskedTextBox2.Text.Trim() + "SV";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "SII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "SIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "SIV";



                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "SII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "SIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "SIV";

                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs5 = retainerMaskedTextBox2.Text.Trim() + "SV";
                                rs4 = RPREmaskedTextBox1.Text.Trim() + "SIV";

                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "5")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs6 = retainerMaskedTextBox2.Text.Trim() + "SVI";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "SII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "SIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "SIV";
                                fs5 = previousmaskedTextBox1.Text.Trim() + "SV";




                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "SII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "SIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "SIV";
                                rs5 = "R" + previousmaskedTextBox1.Text.Trim() + "SV";


                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs6 = retainerMaskedTextBox2.Text.Trim() + "SVI";
                                rs5 = RPREmaskedTextBox1.Text.Trim() + "SV";

                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "6")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs7 = retainerMaskedTextBox2.Text.Trim() + "SVII";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "SII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "SIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "SIV";
                                fs5 = previousmaskedTextBox1.Text.Trim() + "SV";
                                fs6 = previousmaskedTextBox1.Text.Trim() + "SVI";





                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "SII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "SIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "SIV";
                                rs5 = "R" + previousmaskedTextBox1.Text.Trim() + "SV";
                                rs6 = "R" + previousmaskedTextBox1.Text.Trim() + "SVI";



                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q7 = "CREATE TABLE [dbo]." + rs7 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q7, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs7 = retainerMaskedTextBox2.Text.Trim() + "SVII";
                                rs6 = RPREmaskedTextBox1.Text.Trim() + "SVI";

                                string q7 = "CREATE TABLE [dbo]." + rs7 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q7, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "7")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs8 = retainerMaskedTextBox2.Text.Trim() + "SVIII";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "SI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "SII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "SIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "SIV";
                                fs5 = previousmaskedTextBox1.Text.Trim() + "SV";
                                fs6 = previousmaskedTextBox1.Text.Trim() + "SVI";
                                fs7 = previousmaskedTextBox1.Text.Trim() + "SVII";






                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "SI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "SII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "SIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "SIV";
                                rs5 = "R" + previousmaskedTextBox1.Text.Trim() + "SV";
                                rs6 = "R" + previousmaskedTextBox1.Text.Trim() + "SVI";
                                rs7 = "R" + previousmaskedTextBox1.Text.Trim() + "SVII";




                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q7 = "CREATE TABLE [dbo]." + rs7 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q7, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q8 = "CREATE TABLE [dbo]." + rs8 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B8[0] + "] float NULL ,[QP1] float NULL ,[" + B8[1] + "] float NULL ,[QP2] float NULL ,[" + B8[2] + "] float NULL ,[QP3] float NULL ,[" + B8[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP7] float NULL,[TM7] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE8] CHAR(10) NULL,[COPM8] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q8, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs8 = retainerMaskedTextBox2.Text.Trim() + "SVIII";
                                rs7 = RPREmaskedTextBox1.Text.Trim() + "SVII";

                                string q8 = "CREATE TABLE [dbo]." + rs8 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B8[0] + "] float NULL ,[QP1] float NULL ,[" + B8[1] + "] float NULL ,[QP2] float NULL ,[" + B8[2] + "] float NULL ,[QP3] float NULL ,[" + B8[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP7] float NULL,[TM7] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE8] CHAR(10) NULL,[COPM8] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q8, conn);
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
                                // string q = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";
                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("successfully create table");
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


                                //string q1 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");


                            }


                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs2 = retainerMaskedTextBox2.Text.Trim() + "FII";

                                fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";

                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                // string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //   string q = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }


                            MessageBox.Show("successfully create table");

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

                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";



                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";


                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("successfully create table");

                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs3 = retainerMaskedTextBox2.Text.Trim() + "FIII";
                                rs2 = RPREmaskedTextBox1.Text.Trim() + "FII";

                                string q = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //string q = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("successfully create table");

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
                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                // string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M1[0] + "] float NULL ,[QP1] float NULL ,[" + M1[1] + "] float NULL ,[QP2] float NULL ,[" + M1[2] + "] float NULL ,[QP3] float NULL ,[" + M1[3] + "] float NULL,[QP4] float NULL ,[" + M1[4] + "] float Null,[QP5] float NULL ,[" + M1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M2[0] + "] float NULL ,[QP1] float NULL ,[" + M2[1] + "] float NULL ,[QP2] float NULL ,[" + M2[2] + "] float NULL ,[QP3] float NULL ,[" + M2[3] + "] float NULL,[QP4] float NULL ,[" + M2[4] + "] float Null,[QP5] float NULL ,[" + M2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M3[0] + "] float NULL ,[QP1] float NULL ,[" + M3[1] + "] float NULL ,[QP2] float NULL ,[" + M3[2] + "] float NULL ,[QP3] float NULL ,[" + M3[3] + "] float NULL,[QP4] float NULL ,[" + M3[4] + "] float Null,[QP5] float NULL ,[" + M3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //    string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs4 = retainerMaskedTextBox2.Text.Trim() + "FIV";
                                rs3 = RPREmaskedTextBox1.Text.Trim() + "FIII";

                                string q = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";

                                //       string q = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + M4[0] + "] float NULL ,[QP1] float NULL ,[" + M4[1] + "] float NULL ,[QP2] float NULL ,[" + M4[2] + "] float NULL ,[QP3] float NULL ,[" + M4[3] + "] float NULL,[QP4] float NULL ,[" + M4[4] + "] float Null,[QP5] float NULL ,[" + M4[5] + "] float Null,[QP6] float NULL,[" + M4[6] + "] float Null,[QP7] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(50) NULL)";

                                cmd = new SqlCommand(q, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "4")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs5 = retainerMaskedTextBox2.Text.Trim() + "FV";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "FII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "FIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "FIV";



                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "FII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "FIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "FIV";

                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs5 = retainerMaskedTextBox2.Text.Trim() + "FV";
                                rs4 = RPREmaskedTextBox1.Text.Trim() + "FIV";

                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "5")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs6 = retainerMaskedTextBox2.Text.Trim() + "FVI";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "FII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "FIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "FIV";
                                fs5 = previousmaskedTextBox1.Text.Trim() + "FV";




                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "FII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "FIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "FIV";
                                rs5 = "R" + previousmaskedTextBox1.Text.Trim() + "FV";


                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs6 = retainerMaskedTextBox2.Text.Trim() + "FVI";
                                rs5 = RPREmaskedTextBox1.Text.Trim() + "FV";

                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "6")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {

                                rs7 = retainerMaskedTextBox2.Text.Trim() + "FVII";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "FII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "FIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "FIV";
                                fs5 = previousmaskedTextBox1.Text.Trim() + "FV";
                                fs6 = previousmaskedTextBox1.Text.Trim() + "FVI";





                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "FII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "FIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "FIV";
                                rs5 = "R" + previousmaskedTextBox1.Text.Trim() + "FV";
                                rs6 = "R" + previousmaskedTextBox1.Text.Trim() + "FVI";



                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q7 = "CREATE TABLE [dbo]." + rs7 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q7, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs7 = retainerMaskedTextBox2.Text.Trim() + "FVII";
                                rs6 = RPREmaskedTextBox1.Text.Trim() + "FVI";

                                string q7 = "CREATE TABLE [dbo]." + rs7 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q7, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }
                        if (retainerSemestercomboBox1.SelectedIndex.ToString() == "7")
                        {
                            if (newRetainerradioButton2.Checked == true)
                            {
                                rs8 = retainerMaskedTextBox2.Text.Trim() + "FVIII";


                                fs1 = previousmaskedTextBox1.Text.Trim() + "FI";
                                fs2 = previousmaskedTextBox1.Text.Trim() + "FII";
                                fs3 = previousmaskedTextBox1.Text.Trim() + "FIII";
                                fs4 = previousmaskedTextBox1.Text.Trim() + "FIV";
                                fs5 = previousmaskedTextBox1.Text.Trim() + "FV";
                                fs6 = previousmaskedTextBox1.Text.Trim() + "FVI";
                                fs7 = previousmaskedTextBox1.Text.Trim() + "FVII";


                                rs1 = "R" + previousmaskedTextBox1.Text.Trim() + "FI";
                                rs2 = "R" + previousmaskedTextBox1.Text.Trim() + "FII";
                                rs3 = "R" + previousmaskedTextBox1.Text.Trim() + "FIII";
                                rs4 = "R" + previousmaskedTextBox1.Text.Trim() + "FIV";
                                rs5 = "R" + previousmaskedTextBox1.Text.Trim() + "FV";
                                rs6 = "R" + previousmaskedTextBox1.Text.Trim() + "FVI";
                                rs7 = "R" + previousmaskedTextBox1.Text.Trim() + "FVII";




                                string q1 = "CREATE TABLE [dbo]." + rs1 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B1[0] + "] float NULL ,[QP1] float NULL ,[" + B1[1] + "] float NULL ,[QP2] float NULL ,[" + B1[2] + "] float NULL ,[QP3] float NULL ,[" + B1[3] + "] float NULL,[QP4] float NULL ,[" + B1[4] + "] float Null,[QP5] float NULL ,[" + B1[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[CGPA] float NULL,[GRADE1] CHAR(10) NULL,[COPM1] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q1, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q2 = "CREATE TABLE [dbo]." + rs2 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B2[0] + "] float NULL ,[QP1] float NULL ,[" + B2[1] + "] float NULL ,[QP2] float NULL ,[" + B2[2] + "] float NULL ,[QP3] float NULL ,[" + B2[3] + "] float NULL,[QP4] float NULL ,[" + B2[4] + "] float Null,[QP5] float NULL ,[" + B2[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[COPM] float NULL,[GRADE] CHAR(10) NULL,[TQP1] float NULL,[TM1] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE2] CHAR(10) NULL,[COPM2] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q2, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q3 = "CREATE TABLE [dbo]." + rs3 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B3[0] + "] float NULL ,[QP1] float NULL ,[" + B3[1] + "] float NULL ,[QP2] float NULL ,[" + B3[2] + "] float NULL ,[QP3] float NULL ,[" + B3[3] + "] float NULL,[QP4] float NULL ,[" + B3[4] + "] float Null,[QP5] float NULL ,[" + B3[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP2] float NULL,[TM2] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE3] CHAR(10) NULL,[COPM3] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q3, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q4 = "CREATE TABLE [dbo]." + rs4 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B4[0] + "] float NULL ,[QP1] float NULL ,[" + B4[1] + "] float NULL ,[QP2] float NULL ,[" + B4[2] + "] float NULL ,[QP3] float NULL ,[" + B4[3] + "] float NULL,[QP4] float NULL ,[" + B4[4] + "] float Null,[QP5] float NULL ,[" + B4[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP3] float NULL,[TM3] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE4] CHAR(10) NULL,[COPM4] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q4, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q5 = "CREATE TABLE [dbo]." + rs5 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B5[0] + "] float NULL ,[QP1] float NULL ,[" + B5[1] + "] float NULL ,[QP2] float NULL ,[" + B5[2] + "] float NULL ,[QP3] float NULL ,[" + B5[3] + "] float NULL,[QP4] float NULL ,[" + B5[4] + "] float Null,[QP5] float NULL ,[" + B5[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP4] float NULL,[TM4] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE5] CHAR(10) NULL,[COPM5] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(200) NULL)";
                                cmd = new SqlCommand(q5, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q6 = "CREATE TABLE [dbo]." + rs6 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B6[0] + "] float NULL ,[QP1] float NULL ,[" + B6[1] + "] float NULL ,[QP2] float NULL ,[" + B6[2] + "] float NULL ,[QP3] float NULL ,[" + B6[3] + "] float NULL,[QP4] float NULL ,[" + B6[4] + "] float Null,[QP5] float NULL ,[" + B6[5] + "] float Null,[QP6] float NULL,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP5] float NULL,[TM5] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE6] CHAR(10) NULL,[COPM6] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q6, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q7 = "CREATE TABLE [dbo]." + rs7 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B7[0] + "] float NULL ,[QP1] float NULL ,[" + B7[1] + "] float NULL ,[QP2] float NULL ,[" + B7[2] + "] float NULL ,[QP3] float NULL ,[" + B7[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP6] float NULL,[TM6] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE7] CHAR(10) NULL,[COPM7] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q7, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                string q8 = "CREATE TABLE [dbo]." + rs8 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B8[0] + "] float NULL ,[QP1] float NULL ,[" + B8[1] + "] float NULL ,[QP2] float NULL ,[" + B8[2] + "] float NULL ,[QP3] float NULL ,[" + B8[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP7] float NULL,[TM7] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE8] CHAR(10) NULL,[COPM8] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q8, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                MessageBox.Show("successfully create table");
                            }
                            if (oldRetainerradioButton1.Checked == true)
                            {
                                rs8 = retainerMaskedTextBox2.Text.Trim() + "FVIII";
                                rs7 = RPREmaskedTextBox1.Text.Trim() + "FVII";

                                string q8 = "CREATE TABLE [dbo]." + rs8 + "([SRNo] int NOT NULL identity(1,1),[RollNo] NVARCHAR(50)  NOT NULL PRIMARY KEY,[RegdNo] NVARCHAR(50) NULL ,[Name] NVARCHAR(50) NULL ,[FatherName] NVARCHAR(50) NULL ,[" + B8[0] + "] float NULL ,[QP1] float NULL ,[" + B8[1] + "] float NULL ,[QP2] float NULL ,[" + B8[2] + "] float NULL ,[QP3] float NULL ,[" + B8[3] + "] float NULL,[QP4] float NULL ,[QP] float NULL,[TM] float NULL,[SGPA] float NULL,[GRADE] CHAR(10) NULL,[COPM] float NULL,[TQP7] float NULL,[TM7] float NULL,[GTM] float NULL,[GQP] float NULL,[CGPA] float NULL,[GRADE8] CHAR(10) NULL,[COPM8] float NULL,[RESULT] NVARCHAR(50) NULL,[REMARKS] NVARCHAR(500) NULL)";
                                cmd = new SqlCommand(q8, conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                            }
                        }

                    }
                    groupBox2.Enabled = true;


                }
            }


        }

        private bool isCheckEmpty1()
        {

            {
                if (previousmaskedTextBox1.Text.Trim() == "Bscs  _")
                {
                    InformationAndErrorClass.ErrorMessage("Previous Session TextBox is Empty");
                    previousmaskedTextBox1.Focus();
                    return false;

                }
                if (oldRetainerradioButton1.Checked == true)
                {
                    if (RPREmaskedTextBox1.Text.Trim() == "RBscs  _")
                    {
                        InformationAndErrorClass.ErrorMessage("Previous Retainer Session TextBox is Empty");
                        RPREmaskedTextBox1.Focus();
                        return false;

                    }
                }
                if (retainerMaskedTextBox2.Text.Trim() == "RBscs  _")
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
        }

        private void retainerSemestercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

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

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B2[0] + "] ,[QP1] ,[" + B2[1] + "] ,[QP2] ,[" + B2[2] + "] ,[QP3] ,[" + B2[3] + "] ,[QP4] ,[" + B2[4] + "] ,[QP5] ,[" + B2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


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

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B2[0] + "] ,[QP1] ,[" + B2[1] + "] ,[QP2] ,[" + B2[2] + "] ,[QP3] ,[" + B2[3] + "] ,[QP4] ,[" + B2[4] + "] ,[QP5] ,[" + B2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs3);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B3[0] + "] ,[QP1] ,[" + B3[1] + "] ,[QP2] ,[" + B3[2] + "] ,[QP3] ,[" + B3[3] + "] ,[QP4] ,[" + B3[4] + "] ,[QP5] ,[" + B3[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP2],[TM2],[GTM],[GQP] ,[CGPA],[GRADE3],[COPM3] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


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
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "4")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B2[0] + "] ,[QP1] ,[" + B2[1] + "] ,[QP2] ,[" + B2[2] + "] ,[QP3] ,[" + B2[3] + "] ,[QP4] ,[" + B2[4] + "] ,[QP5] ,[" + B2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs3);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B3[0] + "] ,[QP1] ,[" + B3[1] + "] ,[QP2] ,[" + B3[2] + "] ,[QP3] ,[" + B3[3] + "] ,[QP4] ,[" + B3[4] + "] ,[QP5] ,[" + B3[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP2],[TM2],[GTM],[GQP] ,[CGPA],[GRADE3],[COPM3] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs4);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs4 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B4[0] + "] ,[QP1] ,[" + B4[1] + "] ,[QP2] ,[" + B4[2] + "] ,[QP3] ,[" + B4[3] + "] ,[QP4] ,[" + B4[4] + "] ,[QP5] ,[" + B4[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP3],[TM3],[GTM],[GQP] ,[CGPA],[GRADE4],[COPM4] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs4 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs4);



                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs4);

                    }


                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "5")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B2[0] + "] ,[QP1] ,[" + B2[1] + "] ,[QP2] ,[" + B2[2] + "] ,[QP3] ,[" + B2[3] + "] ,[QP4] ,[" + B2[4] + "] ,[QP5] ,[" + B2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs3);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B3[0] + "] ,[QP1] ,[" + B3[1] + "] ,[QP2] ,[" + B3[2] + "] ,[QP3] ,[" + B3[3] + "] ,[QP4] ,[" + B3[4] + "] ,[QP5] ,[" + B3[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP2],[TM2],[GTM],[GQP] ,[CGPA],[GRADE3],[COPM3] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs4);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs4 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B4[0] + "] ,[QP1] ,[" + B4[1] + "] ,[QP2] ,[" + B4[2] + "] ,[QP3] ,[" + B4[3] + "] ,[QP4] ,[" + B4[4] + "] ,[QP5] ,[" + B4[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP3],[TM3],[GTM],[GQP] ,[CGPA],[GRADE4],[COPM4] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs5);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {
                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs5 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B5[0] + "] ,[QP1] ,[" + B5[1] + "] ,[QP2] ,[" + B5[2] + "] ,[QP3] ,[" + B5[3] + "] ,[QP4] ,[" + B5[4] + "] ,[QP5] ,[" + B5[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP4],[TM4],[GTM],[GQP] ,[CGPA],[GRADE5],[COPM5] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);
                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs5 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs5);




                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs5);

                    }


                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "6")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B2[0] + "] ,[QP1] ,[" + B2[1] + "] ,[QP2] ,[" + B2[2] + "] ,[QP3] ,[" + B2[3] + "] ,[QP4] ,[" + B2[4] + "] ,[QP5] ,[" + B2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs3);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B3[0] + "] ,[QP1] ,[" + B3[1] + "] ,[QP2] ,[" + B3[2] + "] ,[QP3] ,[" + B3[3] + "] ,[QP4] ,[" + B3[4] + "] ,[QP5] ,[" + B3[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP2],[TM2],[GTM],[GQP] ,[CGPA],[GRADE3],[COPM3] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs4);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs4 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B4[0] + "] ,[QP1] ,[" + B4[1] + "] ,[QP2] ,[" + B4[2] + "] ,[QP3] ,[" + B4[3] + "] ,[QP4] ,[" + B4[4] + "] ,[QP5] ,[" + B4[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP3],[TM3],[GTM],[GQP] ,[CGPA],[GRADE4],[COPM4] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs5);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs5 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B5[0] + "] ,[QP1] ,[" + B5[1] + "] ,[QP2] ,[" + B5[2] + "] ,[QP3] ,[" + B5[3] + "] ,[QP4] ,[" + B5[4] + "] ,[QP5] ,[" + B5[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP4],[TM4],[GTM],[GQP] ,[CGPA],[GRADE5],[COPM5] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs6);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs6 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B6[0] + "] ,[QP1] ,[" + B6[1] + "] ,[QP2] ,[" + B6[2] + "] ,[QP3] ,[" + B6[3] + "] ,[QP4] ,[" + B6[4] + "] ,[QP5] ,[" + B6[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP5],[TM5],[GTM],[GQP] ,[CGPA],[GRADE6],[COPM6] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs6 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs6);





                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs6);

                    }


                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "7")
                {
                    if (newRetainerradioButton2.Checked == true)
                    {

                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs1);

                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs1 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B1[0] + "] ,[QP1] ,[" + B1[1] + "] ,[QP2] ,[" + B1[2] + "] ,[QP3] ,[" + B1[3] + "] ,[QP4] ,[" + B1[4] + "] ,[QP5] ,[" + B1[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1] ,[CGPA],[GRADE1],[COPM1] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "')", conn);

                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs2);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs2 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B2[0] + "] ,[QP1] ,[" + B2[1] + "] ,[QP2] ,[" + B2[2] + "] ,[QP3] ,[" + B2[3] + "] ,[QP4] ,[" + B2[4] + "] ,[QP5] ,[" + B2[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP1],[TM1],[GTM],[GQP] ,[CGPA],[GRADE2],[COPM2] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs3);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs3 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B3[0] + "] ,[QP1] ,[" + B3[1] + "] ,[QP2] ,[" + B3[2] + "] ,[QP3] ,[" + B3[3] + "] ,[QP4] ,[" + B3[4] + "] ,[QP5] ,[" + B3[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP2],[TM2],[GTM],[GQP] ,[CGPA],[GRADE3],[COPM3] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs4);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs4 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B4[0] + "] ,[QP1] ,[" + B4[1] + "] ,[QP2] ,[" + B4[2] + "] ,[QP3] ,[" + B4[3] + "] ,[QP4] ,[" + B4[4] + "] ,[QP5] ,[" + B4[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP3],[TM3],[GTM],[GQP] ,[CGPA],[GRADE4],[COPM4] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs5);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs5 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B5[0] + "] ,[QP1] ,[" + B5[1] + "] ,[QP2] ,[" + B5[2] + "] ,[QP3] ,[" + B5[3] + "] ,[QP4] ,[" + B5[4] + "] ,[QP5] ,[" + B5[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP4],[TM4],[GTM],[GQP] ,[CGPA],[GRADE5],[COPM5] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs6);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs6 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B6[0] + "] ,[QP1] ,[" + B6[1] + "] ,[QP2] ,[" + B6[2] + "] ,[QP3] ,[" + B6[3] + "] ,[QP4] ,[" + B6[4] + "] ,[QP5] ,[" + B6[5] + "] ,[QP6] ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP5],[TM5],[GTM],[GQP] ,[CGPA],[GRADE6],[COPM6] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "','" + retainerDataGridView1.Rows[i].Cells[27].Value + "','" + retainerDataGridView1.Rows[i].Cells[28].Value + "','" + retainerDataGridView1.Rows[i].Cells[29].Value + "','" + retainerDataGridView1.Rows[i].Cells[30].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer(fs7);
                        for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                        {

                            SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs7 + "([RollNo] ,[RegdNo] ,[Name] ,[FatherName] ,[" + B7[0] + "] ,[QP1] ,[" + B7[1] + "] ,[QP2] ,[" + B7[2] + "] ,[QP3] ,[" + B7[3] + "] ,[QP4]  ,[QP] ,[TM],[SGPA],[COPM] ,[GRADE],[TQP6],[TM6],[GTM],[GQP] ,[CGPA],[GRADE7],[COPM7] ,[RESULT] ,[REMARKS] ) VALUES('" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "','" + retainerDataGridView1.Rows[i].Cells[7].Value + "','" + retainerDataGridView1.Rows[i].Cells[8].Value + "','" + retainerDataGridView1.Rows[i].Cells[9].Value + "','" + retainerDataGridView1.Rows[i].Cells[10].Value + "','" + retainerDataGridView1.Rows[i].Cells[11].Value + "','" + retainerDataGridView1.Rows[i].Cells[12].Value + "','" + retainerDataGridView1.Rows[i].Cells[13].Value + "','" + retainerDataGridView1.Rows[i].Cells[14].Value + "','" + retainerDataGridView1.Rows[i].Cells[15].Value + "','" + retainerDataGridView1.Rows[i].Cells[16].Value + "','" + retainerDataGridView1.Rows[i].Cells[17].Value + "','" + retainerDataGridView1.Rows[i].Cells[18].Value + "','" + retainerDataGridView1.Rows[i].Cells[19].Value + "','" + retainerDataGridView1.Rows[i].Cells[20].Value + "','" + retainerDataGridView1.Rows[i].Cells[21].Value + "','" + retainerDataGridView1.Rows[i].Cells[22].Value + "','" + retainerDataGridView1.Rows[i].Cells[23].Value + "','" + retainerDataGridView1.Rows[i].Cells[24].Value + "','" + retainerDataGridView1.Rows[i].Cells[25].Value + "','" + retainerDataGridView1.Rows[i].Cells[26].Value + "')", conn);


                            conn.Open();
                            cm.ExecuteNonQuery();
                            conn.Close();

                        }
                        SqlCommand cm1 = new SqlCommand(@"delete from " + fs7 + "where RollNo = '" + getRetainerRollnotextBox1.Text.Trim() + "'", conn);
                        conn.Open();
                        cm1.ExecuteNonQuery();
                        conn.Close();
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs7);
                    }
                    if (oldRetainerradioButton1.Checked == true)
                    {
                        retainerDataGridView1.DataSource = getRetainerRecordForRetainer2(rs7);

                    }


                }
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
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "4")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs5 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP4],[TM4],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "5")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs6 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP5],[TM5],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "6")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs7 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP6],[TM6],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                }
                if (retainerSemestercomboBox1.SelectedIndex.ToString() == "7")
                {
                    for (int i = 0; i < retainerDataGridView1.Rows.Count; i++)
                    {


                        SqlCommand cm = new SqlCommand(@"INSERT INTO " + rs8 + " ([RollNo],[RegdNo],[Name],[FatherName],[TQP7],[TM7],[REMARKS])VALUES('" + retainerDataGridView1.Rows[i].Cells[0].Value + "','" + retainerDataGridView1.Rows[i].Cells[1].Value + "','" + retainerDataGridView1.Rows[i].Cells[2].Value + "','" + retainerDataGridView1.Rows[i].Cells[3].Value + "','" + retainerDataGridView1.Rows[i].Cells[4].Value + "','" + retainerDataGridView1.Rows[i].Cells[5].Value + "','" + retainerDataGridView1.Rows[i].Cells[6].Value + "')", conn);
                        conn.Open();
                        cm.ExecuteNonQuery();
                        conn.Close();

                    }
                    MessageBox.Show("insert data successfully");
                }
            }
        }
        private DataTable getRetainerRecordForRetainer2(string p)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select [RollNo] ,[RegdNo],[Name],[FatherName],[GQP],[GTM] ,[REMARKS] from [dbo]." + p + " ", conn);

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
        private DataTable getRetainerRecordForRetainer(string p)
        {
            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from [dbo]." + p + "  where [RollNo] = '" + getRetainerRollnotextBox1.Text + "'", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }

        private void RetainerResultcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            semeterCountLoad1();

        }
        private void semeterCountLoad1()
        {

            RetainerScomboBox1.Items.Clear();
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "0")
            {
                for (int i = 0; i < 6; i++)
                {
                    RetainerScomboBox1.Items.Add(B1[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < 6; i++)
                {
                    RetainerScomboBox1.Items.Add(B2[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "2")
            {
                for (int i = 0; i < 6; i++)
                {
                    RetainerScomboBox1.Items.Add(B3[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "3")
            {
                for (int i = 0; i < 6; i++)
                {
                    RetainerScomboBox1.Items.Add(B4[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "4")
            {
                for (int i = 0; i < 6; i++)
                {
                    RetainerScomboBox1.Items.Add(B5[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "5")
            {
                for (int i = 0; i < 6; i++)
                {
                    RetainerScomboBox1.Items.Add(B6[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "6")
            {
                for (int i = 0; i < 4; i++)
                {
                    RetainerScomboBox1.Items.Add(B7[i]);
                }
            }
            if (RetainerResultcomboBox2.SelectedIndex.ToString() == "7")
            {
                for (int i = 0; i < 4; i++)
                {
                    RetainerScomboBox1.Items.Add(B8[i]);
                }
            }

        }

        private void RetainerScomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string tbl;

       
        SqlCommand cd;


        private void InresultsemstercomboBox98_SelectedIndexChanged(object sender, EventArgs e)
        {
            semeterCountLoad98();

        }
        private void semeterCountLoad98()
        {

            yoursemestercomboBox98.Items.Clear();
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "0")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(B1[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(B2[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "2")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(B3[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "3")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(B4[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "4")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(B5[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "5")
            {
                for (int i = 0; i < 6; i++)
                {
                    yoursemestercomboBox98.Items.Add(B6[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "6")
            {
                for (int i = 0; i < 4; i++)
                {
                    yoursemestercomboBox98.Items.Add(B7[i]);
                }
            }
            if (InresultsemstercomboBox98.SelectedIndex.ToString() == "7")
            {
                for (int i = 0; i < 4; i++)
                {
                    yoursemestercomboBox98.Items.Add(B8[i]);
                }
            }

        }
        string tableresult98 = "";
        string colum98 = "";

        private void QpaMethod98(string qp)
        {
            conn.Open();
            cd = new SqlCommand("Update " + tableresult98 + " set " + qp + " = " + QpaClass.QpaMethod(Convert.ToDouble(markstextBox98.Text)) + " where [RollNo] = '" + rollNotextBox98.Text.Trim() + "'", conn);
            cd.ExecuteNonQuery();
            conn.Close();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty4())
            {
                if (resultspringradioButton98.Checked == true)
                {
                    if (RegularradioButton4.Visible == true)
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
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "5")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SV";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "6")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SVI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "7")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SVII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "8")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "SVIII";
                        }
                    }
                    if (RetainerradioButton3.Visible == true)
                    {
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "1")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "2")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "3")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SIII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "4")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SIV";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "5")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SV";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "6")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SVI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "7")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SVII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "8")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "SVIII";
                        }
                    }
                    colum98 = "[" + yoursemestercomboBox98.Text + "]";

                }
                if (resultfallradioButton98.Checked == true)
                {
                    if (RegularradioButton4.Visible == true)
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
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "5")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FV";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "6")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FVI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "7")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FVII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "8")
                        {
                            tableresult98 = resultmaskedTextBox98.Text + "FVIII";
                        }
                    }
                    if (RetainerradioButton3.Visible == true)
                    {

                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "1")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FI";

                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "2")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "3")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FIII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "4")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FIV";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "5")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FV";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "6")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FVI";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "7")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FVII";
                        }
                        if (InresultsemstercomboBox98.SelectedItem.ToString() == "8")
                        {
                            tableresult98 = R3maskedTextBox1.Text + "FVIII";
                        }
                    }
                    colum98 = "[" + yoursemestercomboBox98.Text + "]";


                }
                groupBox7.Enabled = true;
            }
        }
        private bool isCheckEmpty4()
        {
            if (RegularradioButton4.Checked == true)
            {
                if (resultmaskedTextBox98.Text.Trim() == "Bscs  _")
                {
                    InformationAndErrorClass.ErrorMessage("Session is Required");
                    resultmaskedTextBox98.Focus();
                    return false;
                }
            }
            if (RetainerradioButton3.Checked == true)
            {
                if (R3maskedTextBox1.Text.Trim() == "RBscs  _")
                {
                    InformationAndErrorClass.ErrorMessage("Session is Required");
                    R3maskedTextBox1.Focus();
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

        private void resultbutton98_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty5())
            {
                SqlCommand cmd = new SqlCommand(@"Update " + tableresult98 + " set " + colum98 + " = " + markstextBox98.Text + "  where [RollNo] = '" + rollNotextBox98.Text.Trim() + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
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

                MessageBox.Show("Test successfully");
            }
        }
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

        private void MakeResultofRetainerbutton8_Click(object sender, EventArgs e)
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
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "4")
                    {
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "SV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);

                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "5")
                    {
                        string r6 = RetaierSnmaskedTextBox1.Text.Trim() + "SVI";
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "SV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r5);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r6 + " set TQP5 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM5 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker6(r6);



                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "6")
                    {
                        string r7 = RetaierSnmaskedTextBox1.Text.Trim() + "SVII";
                        string r6 = RetaierSnmaskedTextBox1.Text.Trim() + "SVI";
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "SV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r5);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r6 + " set TQP5 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM5 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker6(r6);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r6);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r7 + " set TQP6 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM6 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker7(r7);



                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "7")
                    {
                        string r8 = RetaierSnmaskedTextBox1.Text.Trim() + "SVIII";
                        string r7 = RetaierSnmaskedTextBox1.Text.Trim() + "SVII";
                        string r6 = RetaierSnmaskedTextBox1.Text.Trim() + "SVI";
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "SV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r5);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r6 + " set TQP5 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM5 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker6(r6);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r6);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r7 + " set TQP6 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM6 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker7(r7);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r7);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r8 + " set TQP7 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM7 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker8(r8);



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
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "4")
                    {
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "FV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);

                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "5")
                    {
                        string r6 = RetaierSnmaskedTextBox1.Text.Trim() + "FVI";
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "FV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r5);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r6 + " set TQP5 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM5 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker6(r6);



                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "6")
                    {
                        string r7 = RetaierSnmaskedTextBox1.Text.Trim() + "FVII";
                        string r6 = RetaierSnmaskedTextBox1.Text.Trim() + "FVI";
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "FV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r5);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r6 + " set TQP5 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM5 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker6(r6);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r6);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r7 + " set TQP6 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM6 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker7(r7);



                        MessageBox.Show("successfully create table");

                    }
                    if (RetainerKacomboBox1.SelectedIndex.ToString() == "7")
                    {
                        string r8 = RetaierSnmaskedTextBox1.Text.Trim() + "FVIII";
                        string r7 = RetaierSnmaskedTextBox1.Text.Trim() + "FVII";
                        string r6 = RetaierSnmaskedTextBox1.Text.Trim() + "FVI";
                        string r5 = RetaierSnmaskedTextBox1.Text.Trim() + "FV";
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
                        RetainergrddataGridView1.DataSource = GetDataSply2(r4);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r5 + " set TQP4 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM4 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker5(r5);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r5);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r6 + " set TQP5 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM5 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker6(r6);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r6);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r7 + " set TQP6 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM6 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker7(r7);
                        RetainergrddataGridView1.DataSource = GetDataSply2(r7);


                        for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
                        {
                            cmd = new SqlCommand(@" Update " + r8 + " set TQP7 = '" + RetainergrddataGridView1.Rows[i].Cells[1].Value + "' , " + "   TM7 = '" + RetainergrddataGridView1.Rows[i].Cells[2].Value + "' , " + "   REMARKS = '" + RetainergrddataGridView1.Rows[i].Cells[3].Value + "' where RollNo = '" + RetainergrddataGridView1.Rows[i].Cells[0].Value + "' ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }

                        resultmaker8(r8);



                        MessageBox.Show("successfully create table");

                    }
                }
            }
        }
        private bool isEmpty8()
        {
            if (RetaierSnmaskedTextBox1.Text.Trim() == "RBscs  _")
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

        private void resultmaker8(string j)
        {
            ResultSemester8(j);

            RetainergrddataGridView1.DataSource = GetDataGrade(j);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(j);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade7(j);
            }

            conn.Close();
        }

        private void resultmaker7(string j)
        {
            ResultSemester7(j);

            RetainergrddataGridView1.DataSource = GetDataGrade(j);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(j);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade6(j);
            }

            conn.Close();
        }

        private void resultmaker6(string j)
        {
            ResultSemester6(j);

            RetainergrddataGridView1.DataSource = GetDataGrade(j);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(j);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade5(j);
            }

            conn.Close();
        }

        private void resultmaker5(string j)
        {
            ResultSemester5(j);

            RetainergrddataGridView1.DataSource = GetDataGrade(j);
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade(j);
            }
            for (int i = 0; i < RetainergrddataGridView1.Rows.Count; i++)
            {
                GetGrade4(j);
            }

            conn.Close();
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

        private void button12_Click(object sender, EventArgs e)
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

        private void button7_Click_1(object sender, EventArgs e)
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





                        if (RetainerScomboBox1.SelectedIndex.ToString() == "0")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP1 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RetainerScomboBox1.SelectedIndex.ToString() == "1")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP2 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RetainerScomboBox1.SelectedIndex.ToString() == "2")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP3 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RetainerScomboBox1.SelectedIndex.ToString() == "3")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP4 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RetainerScomboBox1.SelectedIndex.ToString() == "4")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {
                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP5 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();
                        }
                        if (RetainerScomboBox1.SelectedIndex.ToString() == "5")            // AGR RetainerScomboBox1 ITEM 1 hwa tab ya ka ho
                        {

                            conn.Open();

                            cd = new SqlCommand("Update " + label16.Text + " set QP6 = " + QpaClass.QpaMethod(s) + " where [RollNo] = '" + RdataGridView5.Rows[i].Cells[0].Value + "'", conn);
                            cd.ExecuteNonQuery();
                            conn.Close();

                        }

                    }

                }
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

        private void RegularradioButton4_CheckedChanged(object sender, EventArgs e)
        {
            markstextBox98.Visible = true;
            R3maskedTextBox1.Visible = false;
            groupBox8.Enabled = true;
        }

        private void RetainerradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            markstextBox98.Visible = false;
            R3maskedTextBox1.Visible = true;
            groupBox8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isCheckEmpty3())
            {
                if (RSpringradioButton2.Checked == true)
                {
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "0")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SI";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "1")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SII";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "2")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SIII";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "3")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SIV";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "4")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SV";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "5")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SVI";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "6")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SVII";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "7")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "SVIII";
                    }

                }
                if (RFallradioButton1.Checked == true)
                {
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "0")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FI";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "1")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FII";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "2")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FIII";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "3")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FIV";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "4")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FV";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "5")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FVI";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "6")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FVII";
                    }
                    if (RetainerResultcomboBox2.SelectedIndex.ToString() == "7")
                    {
                        label16.Text = RRmaskedTextBox1.Text + "FVIII";
                    }

                }
                label15.Text = RetainerScomboBox1.Text;

            }
        }
        private bool isCheckEmpty3()
        {
            if (RRmaskedTextBox1.Text.Trim() == "RBscs  _")
            {
                InformationAndErrorClass.ErrorMessage("Enter Session");
                RRmaskedTextBox1.Focus();
                return false;
            }
            if (RetainerResultcomboBox2.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Semester");
                return false;
            }
            if (RSpringradioButton2.Checked == false && RFallradioButton1.Checked == false)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Spring/Fall");
                return false;
            }
            if (RetainerScomboBox1.Text.Trim() == string.Empty)
            {
                InformationAndErrorClass.ErrorMessage("Choose the Subject");
                return false;
            }
            return true;
        }


        private void oKbutton_Click(object sender, EventArgs e)
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
                if (comboBox1.SelectedItem.ToString() == "5")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SV";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FV";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "6")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SVI";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FVI";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "7")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SVII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FVII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
                if (comboBox1.SelectedItem.ToString() == "8")
                {
                    if (SradioButton2.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "SVIII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                    if (FradioButton1.Checked == true)
                    {
                        string s = maskedTextBox1.Text + "FVIII";
                        dataGridView3.DataSource = GetReportData(s);
                    }
                }
            }
            groupBox12.Enabled = true;


        }
        private bool isCheckEmpty6()
        {
            if (maskedTextBox1.Text.Trim() == "Bscs  _")
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

        private DataTable GetReportData(string s)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from [dbo]." + s, conn);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            return dt;
        }










        private void button10_Click(object sender, EventArgs e)
        {
            DGVPrinter pr = new DGVPrinter();


         

            if (comboBox1.SelectedItem.ToString() == "1")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 1st SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01101 \t\t CSIT01102 \t\t CSIT01103 \t\t CSIT01104 \t\t CSIT01105 \t\t CSIT01106" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18 \t TOTAL MARKS IN 1ST SEMESTER= 600" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "2")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 2nd SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01201 \t\t CSIT01202 \t\t CSIT01203 \t\t CSIT01204 \t\t CSIT01205 \t\t CSIT01206" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     Total Cradit Hours = 36   Total Marks = 1200" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "3")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 3rd SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01301 \t\t CSIT01302 \t\t CSIT01303 \t\t CSIT01304 \t\t CSIT01305 \t\t CSIT01306" + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    Total Cradit Hours = 54   Total Marks = 1800" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "4")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 4th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01401 \t\t CSIT01402 \t\t CSIT01403 \t\t CSIT01404 \t\t CSIT01405 \t\t CSIT01406 " + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 18     TOTAL MARKS IN 4th SEMESTER = 600" + Environment.NewLine + "Total Cradit Hours = 72   Total Marks = 2400" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "5")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 5th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01501 \t\t CSIT01502 \t\t CSIT01503 \t\t CSIT01504 \t\t CSIT01505 \t\t CSIT01506 " + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 18     TOTAL MARKS IN 4th SEMESTER = 600" + Environment.NewLine + "TOTAL CRADIT HOURS IN 5th SEMESTER = 18     TOTAL MARKS IN 5th SEMESTER = 600    Total Cradit Hours = 90   Total Marks = 3000" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "6")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 6th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01601 \t\t CSIT01602 \t\t CSIT01603 \t\t CSIT01604 \t\t CSIT01605 \t\t CSIT01606 " + Environment.NewLine + "Cradit Hours                3                       3                      3                    3                       3                     3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 18     TOTAL MARKS IN 4th SEMESTER = 600" + Environment.NewLine + "    TOTAL CRADIT HOURS IN 5th SEMESTER = 18     TOTAL MARKS IN 5th SEMESTER = 600    TOTAL CRADIT HOURS IN 6th SEMESTER = 18     TOTAL MARKS IN 6th SEMESTER = 600    Total Cradit Hours = 108   Total Marks = 3600" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "7")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 7th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01701 \t\t CSIT01702 \t\t CSIT01703 \t\t CSIT01704 " + Environment.NewLine + "Cradit Hours                3                       3                      3                    3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 18     TOTAL MARKS IN 4th SEMESTER = 600" + Environment.NewLine + "    TOTAL CRADIT HOURS IN 5th SEMESTER = 18     TOTAL MARKS IN 5th SEMESTER = 600    TOTAL CRADIT HOURS IN 6th SEMESTER = 18     TOTAL MARKS IN 6th SEMESTER = 600    TOTAL CRADIT HOURS IN 7th SEMESTER = 12     TOTAL MARKS IN 5th SEMESTER = 400    Total Cradit Hours = 112   Total Marks = 4000" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }
            if (comboBox1.SelectedItem.ToString() == "8")
            {
                pr.Title = "Islamia Univerty of Bahawalpur ";
                pr.SubTitle = "DEPARTMENT OF COMPUTER SCIENCE & IT ,BAHAWALNAGAR CAMPUS" + Environment.NewLine + "RESULT SHEET BSCS [MORNING] 8th SEMESTER SESSION " + maskedTextBox1.Text.Trim() + Environment.NewLine + "Course Code \t\t CSIT01801 \t\t CSIT01802 \t\t CSIT01803 \t\t CSIT01804 " + Environment.NewLine + "Cradit Hours                3                       3                      3                    3  " + Environment.NewLine + "TOTAL CRADIT HOURS IN 1ST SEMESTER = 18      TOTAL MARKS IN 1ST SEMESTER= 600       TOTAL CRADIT HOURS IN 2nd SEMESTER = 18     TOTAL MARKS IN 2nd SEMESTER = 600     TOTAL CRADIT HOURS IN 3rd SEMESTER = 18     TOTAL MARKS IN 3rd SEMESTER = 600    TOTAL CRADIT HOURS IN 4th SEMESTER = 18     TOTAL MARKS IN 4th SEMESTER = 600" + Environment.NewLine + "    TOTAL CRADIT HOURS IN 5th SEMESTER = 18     TOTAL MARKS IN 5th SEMESTER = 600    TOTAL CRADIT HOURS IN 6th SEMESTER = 18     TOTAL MARKS IN 6th SEMESTER = 600    TOTAL CRADIT HOURS IN 7th SEMESTER = 12     TOTAL MARKS IN 5th SEMESTER = 400    TOTAL CRADIT HOURS IN 8th SEMESTER = 12     TOTAL MARKS IN 5th SEMESTER = 400" + Environment.NewLine + "Total Cradit Hours = 116   Total Marks = 4400" + Environment.NewLine + string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yy"));

            }


            pr.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            pr.PageNumbers = true;
            pr.PageNumberInHeader = false;
            pr.PorportionalColumns = true;


          
            pr.HeaderCellAlignment = StringAlignment.Center;

      
            pr.Footer = "INCHARGE EXAMINATIONS                                  HEAD OF DEPARTMENT                                  NOMINEE CONTROLLER OF EXAMINATION                              DIRECTOR                              CONTROLLER OF EXAMINATIONS" + Environment.NewLine + "Deptt. of CS & IT, IUB, BWN                     Deptt. of CS & IT, IUB, BWN                        The Islamia University of Bahawalpur                               Bahawalnagar Campus, IUB                            The Islamia University of Bahawalpur";
            pr.FooterSpacing = 2;


            pr.printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 700, 3500);
            pr.printDocument.DefaultPageSettings.Landscape = true;
            pr.PrintDataGridView(dataGridView3);



        }

        private void markstextBox98_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                InformationAndErrorClass.WarningMessage("You can Enter Only Number");
                e.Handled = true;
            }
        }
    }


}



