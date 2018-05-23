using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
            HomeButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logolabel4.Visible = false;
            pictureBox4.Visible = true;

            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;


        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            logolabel4.Visible = false;
            pictureBox5.Visible = true;

            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            logolabel4.Visible = false;
            pictureBox6.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeButton();

        }

        private void HomeButton()
        {
            logolabel4.Visible = true;
            pictureBox7.Visible = true;

            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox8.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeButton();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (marquelabel.Left < 0 && (Math.Abs( marquelabel.Left) > marquelabel.Width))
                marquelabel.Left = panel4.Width;

            marquelabel.Left -= 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
