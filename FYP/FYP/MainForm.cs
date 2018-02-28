using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Project:Result System
/// Programmer: Hassan Arshad & Azmatullah
/// Date: 
/// </summary>

namespace FYP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                if (maskedTextBox1.Text == "2016-18" && springradioButton.Checked == true)
                {

                    spring1618 s = new spring1618();
                    s.Show();
                }
                if (maskedTextBox1.Text == "2016-18" && fallradioButton.Checked == true)
                {
                   fall1618 f = new fall1618();
                    f.Show();
                }
            }
        }

        /// <summary>
        /// its code for check invalid smester or session 
        /// in this, if we cannot check any radio button then error occur 
        /// and if semeter is not valid then error also occur and show
        /// a error message.
        /// this method is call in MCS ok button event.
        /// </summary>
        /// <returns></returns>
        private bool isvalid()
        {
            if(springradioButton.Checked == false && fallradioButton.Checked == false)
            {
                MessageBox.Show("Invalid Semester ","ERROR !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if(maskedTextBox1.Text == "2   -")//its selected from maskedtextbox
            {
                MessageBox.Show("Please Select Session", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox1.Focus();
                return false;
            }
            return true;
        }
    }
}
