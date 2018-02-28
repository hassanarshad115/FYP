using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP
{
   public class ConfigurationClass
    {
        public static string ConfigurationMethod()
        {
           return ConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
        }
    }
}
