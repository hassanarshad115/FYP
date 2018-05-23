using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP
{
    public class QpaClass
    {
        private static double qpa = 0.0;

        

        public static double QpaMethod(double q)
        {
            if (q < 100 && q > 85)
            {
                qpa = 12;
            }
            if (q == 85)
            {
                qpa = 12;
            }
            else if (q == 84 || q == 83.5)
            {
                qpa = 11.7;
            }
            else if (q == 83 || q == 82.5)
            {
                qpa = 11.7;
            }
            else if (q == 82 || q == 81.5)
            {
                qpa = 11.4;
            }
            else if (q == 81 || q == 80.5)
            {
                qpa = 11.1;
            }
            else if (q == 80 || q == 79.5)
            {
                qpa = 11.1;
            }
            else if (q == 79 || q == 78.5)
            {
                qpa = 10.8;
            }
            else if (q == 78 || q == 77.5)
            {
                qpa = 10.5;
            }
            else if (q == 77 || q == 76.5)
            {
                qpa = 10.5;
            }
            else if (q == 76 || q == 75.5)
            {
                qpa = 10.2;
            }
            else if (q == 75 || q == 74.5)
            {
                qpa = 9.9;
            }
            else if (q == 74 || q == 73.5)
            {
                qpa = 9.9;
            }
            else if (q == 73 || q == 72.5)
            {
                qpa = 9.6;
            }
            else if (q == 72 || q == 71.5)
            {
                qpa = 9.3;
            }
            else if (q == 71 || q == 70.5)
            {
                qpa = 9.3;
            }
            else if (q == 70 || q == 69.5)
            {
                qpa = 9;
            }
            else if (q == 69 || q == 68.5)
            {
                qpa = 8.7;
            }
            else if (q == 68 || q == 67.5)
            {
                qpa = 8.4;
            }
            else if (q == 67 || q == 66.5)
            {
                qpa = 8.1;
            }
            else if (q == 66 || q == 65.5)
            {
                qpa = 7.8;
            }
            else if (q == 65 || q == 64.5)
            {
                qpa = 7.5;
            }
            else if (q == 64 || q == 63.5)
            {
                qpa = 7.2;
            }
            else if (q == 63 || q == 62.5)
            {
                qpa = 6.9;
            }
            else if (q == 62 || q == 61.5)
            {
                qpa = 6.6;
            }
            else if (q == 61 || q == 60.5)
            {
                qpa = 6.3;
            }
            else if (q == 60 || q == 59.5)
            {
                qpa = 6;
            }
            else if (q == 59 || q == 58.5)
            {
                qpa = 5.7;
            }
            else if (q == 58 || q == 57.5)
            {
                qpa = 5.4;
            }
            else if (q == 57 || q == 56.5)
            {
                qpa = 5.1;
            }
            else if (q == 56 || q == 55.5)
            {
                qpa = 4.8;
            }
            else if (q == 55 || q == 54.5)
            {
                qpa = 4.5;
            }
            else if (q == 54 || q == 53.5)
            {
                qpa = 4.2;
            }
            else if (q == 53 || q == 52.5)
            {
                qpa = 3.9;
            }
            else if (q == 52 || q == 51.5)
            {
                qpa = 3.6;
            }
            else if (q == 51 || q == 49.5)
            {
                qpa = 3.3;
            }
            else if (q == 50)
            {
                qpa = 3;
            }
            else if (q < 50)
            {
                qpa = 0;
            }
            return qpa;
        }


    }
}
