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

            sedepanel3.Height = mcsbutton1.Height;
            sedepanel3.Top = mcsbutton1.Top;
            userControl12.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sedepanel3.Height = mcsbutton1.Height;
            sedepanel3.Top = mcsbutton1.Top;
            userControl12.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sedepanel3.Height = bscsbutton2.Height;
            sedepanel3.Top = bscsbutton2.Top;

            userControl21.BringToFront();
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

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
