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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (IsValidated()) //ye if k sath valid ha ye khali block k lye ha k koi blok empty to ni
            {
               try
                {
                    bool usernamecorrect, passwordcorrect;

                    GetUserLogin(out usernamecorrect, out passwordcorrect);//ye just method ha if k sath ni
                    {

                        if (usernamecorrect && passwordcorrect)
                        {
                            //this.Hide();

                           // rememberme k lye ye sb must ha
                            if (remembermecheckBox.Checked)
                            {
                                Properties.Settings.Default.UserName = usernametextBox.Text;
                                Properties.Settings.Default.Save();
                            }


                            MessageBox.Show("successfully login");
                            this.Hide();
                            MainForm mf = new MainForm();
                            mf.ShowDialog();


                        }
                        else
                        {


                            if (!usernamecorrect)
                            {
                                MessageBox.Show("Username is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                usernametextBox.Clear();
                                passwordtextBox.Clear();
                                usernametextBox.Focus();
                            }
                            else
                            {

                                MessageBox.Show("Password is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                passwordtextBox.Clear();
                                passwordtextBox.Focus();
                            }
                        }
                    }
                }

                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error in coding of login form" + ex.Message);

                }

            }
        }


        //validation check kra ha ye r sath he spaces ko trim k function k sath remove kra ha
        private bool IsValidated() // ye khud always true return kryga 
        {
            if (usernametextBox.Text.Trim() == string.Empty) // ye always false return kryga
                                                             // q k isny error btana h k block khali ha
            {
                MessageBox.Show("Username is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametextBox.Clear();
                usernametextBox.Focus();
                return false;

            }
            if (passwordtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextBox.Focus();
                passwordtextBox.Clear();
                return false;
            }



            return true;
        }



        private void GetUserLogin(out bool usernamecorrect, out bool passwordcorrect)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("loginklye", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            cmd.Parameters.Add("@Isusername", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@Ispassword", SqlDbType.Bit).Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@username", usernametextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordtextBox.Text);

            //Encrypt class bnae ha ak usmy encrypt krny k lye coding ki ha
            //cmd.Parameters.AddWithValue("@password",EncryptClass.encrypt(passwordtextBox.Text));//passwored encrypt hojayga ta k hacking na ho

            cmd.ExecuteNonQuery();

            //agr ye na kia to GetUserLogin red hojayga error ayga
            usernamecorrect = (bool)cmd.Parameters["@Isusername"].Value;
            passwordcorrect = (bool)cmd.Parameters["@Ispassword"].Value;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkboxklye();
        }

        private void checkboxklye()
        {

            if (passwordcheckBox.Checked)
            {
                passwordtextBox.PasswordChar = default(Char);
            }
            if (!passwordcheckBox.Checked)
            {
                passwordtextBox.PasswordChar = Convert.ToChar("*");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernametextBox.Focus();
        }
    }
}

