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
    public partial class fall1618 : Form
    {
        public fall1618()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Students_RecordForm str = new Show_Students_RecordForm();
            str.ShowDialog();
        }

        private void InsertStudentInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertStudentRecordForm isrf = new InsertStudentRecordForm();
            isrf.ShowDialog();
        }
    }
}
