using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP
{
    public class InformationAndErrorClass
    {
        public static void ErrorMessage(string MSG)
        {
            MessageBox.Show(MSG,"ERROR !!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void InformationMessage(string MSG)
        {
            MessageBox.Show(MSG, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void aboutUsMessage(string MSG,string msg)
        {
            MessageBox.Show(MSG, msg, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void WarningMessage(string MSG)
        {
            MessageBox.Show(MSG, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
