using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            sedepanel3.Height = Homebutton1.Height;
            sedepanel3.Top = Homebutton1.Top;

            homeUserControl1.Visible = true;

            mcsUserControl1.Visible = false;
            bscsUserControl1.Visible = false;
            //sedepanel3.Height = mcsbutton1.Height;
            //sedepanel3.Top = mcsbutton1.Top;
            //userControl11.BringToFront();
            //mcsUserControl1.Top = mcsbutton1.Top;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sedepanel3.Height = Homebutton1.Height;
            sedepanel3.Top = Homebutton1.Top;

            homeUserControl1.Visible = true;

            mcsUserControl1.Visible = false;
            bscsUserControl1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mcsUserControl1.Visible = true;

            sedepanel3.Height = mcsbutton2.Height;
            sedepanel3.Top = mcsbutton2.Top;
            mcsUserControl1.BringToFront();
        }

        private void McsButton_Click(object sender, EventArgs e)
        {
            bscsUserControl1.Visible = true;

            sedepanel3.Height = bscsButton.Height;
            sedepanel3.Top = bscsButton.Top;
            bscsUserControl1.BringToFront();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/iub.mcs.bwn/");
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //timer2.Enabled = true;
            //timer2.Interval = 50;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelabel1.Text = DateTime.Now.ToLongDateString();

            timelabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            InformationAndErrorClass.aboutUsMessage("Developer Hassan Arshad & Azmatullah & Fatima \nFrom Islamia University Bahawalpur BWN Campus", "AboutUs");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("http://www.iub.edu.pk/");
        }

        private static void LinkWebsitesMethod(string msg)
        {
            System.Diagnostics.Process.Start(msg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("https://twitter.com/allice9554?lang=en");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("http://www.iub.edu.pk/contact.php");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //if (marquelabel1.Left < 0 && (Math.Abs(marquelabel1.Left) > marquelabel1.Width))
            //    marquelabel1.Left = panel1.Width;

            //marquelabel1.Left -= 1;

            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("http://www.iub.edu.pk/hechelpdesk.php");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("http://lmshost.pern.edu.pk/iub/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("http://www.peef.org.pk/");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LinkWebsitesMethod("http://punjabhec.gov.pk/complaint_cell");
        }

        private void DashboardForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Text = "Your Application has been Minimized";
                notifyIcon1.BalloonTipText = "Your Application has been Minimized";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else
            if (WindowState == FormWindowState.Maximized)
            {
                notifyIcon1.Text = "Your Application is back";
                notifyIcon1.BalloonTipText = "CS Result Management System";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void DashboardForm_DoubleClick(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }
    }
}
