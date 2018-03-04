using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP
{
    public class QpaClass
    {
        private static float q = 0.0f;
        public static  float QpaMethod(float qpa)
        {
            if (q == 85)
            {
                qpa = 12f;
            }
            else if (q == 84)
            {
                qpa = 12f;
            }
            else if (q == 83)
            {
                qpa = 11.7f;
            }
            else if (q == 82)
            {
                qpa = 11.4f;
            }
            else if (q == 81)
            {
                qpa = 11.11f;
            }
            else if (q == 80)
            {
                qpa = 11.11f;
            }
            else if (q == 79)
            {
                qpa = 10.8f;
            }
            else if (q == 78)
            {
                qpa = 10.5f;
            }
            else if (q == 77)
            {
                qpa = 10.5f;
            }
            else if (q == 76)
            {
                qpa = 10.2f;
            }
            else if (q == 75)
            {
                qpa = 9.9f;
            }
            else if (q == 74)
            {
                qpa = 9.9f;
            }
            else if (q == 73)
            {
                qpa = 9.6f;
            }
            else if (q == 72)
            {
                qpa = 9.3f;
            }
            else if (q == 71)
            {
                qpa = 9.3f;
            }
            else if (q == 70)
            {
                qpa = 9f;
            }
            else if (q == 69)
            {
                qpa = 8.7f;
            }
            else if (q == 68)
            {
                qpa = 8.4f;
            }
            else if (q == 67)
            {
                qpa = 8.1f;
            }
            else if (q == 66)
            {
                qpa = 7.8f;
            }
            else if (q == 65)
            {
                qpa = 7.5f;
            }
            else if (q == 64)
            {
                qpa = 7.2f;
            }
            else if (q == 63)
            {
                qpa = 6.9f;
            }
            else if (q == 62)
            {
                qpa = 6.6f;
            }
            else if (q == 61)
            {
                qpa = 6.3f;
            }
            else if (q == 60)
            {
                qpa = 6f;
            }
            else if (q == 59)
            {
                qpa = 5.7f;
            }
            else if (q == 58)
            {
                qpa = 5.4f;
            }
            else if (q == 57)
            {
                qpa = 5.1f;
            }
            else if (q == 56)
            {
                qpa = 4.8f;
            }
            else if (q == 55)
            {
                qpa = 4.5f;
            }
            else if (q == 54)
            {
                qpa = 4.2f;
            }
            else if (q == 53)
            {
                qpa = 3.9f;
            }
            else if (q == 52)
            {
                qpa = 3.6f;
            }
            else if (q == 51)
            {
                qpa = 3.3f;
            }
            else if (q == 50)
            {
                qpa = 3f;
            }
            else if (q == 0)
            {
                qpa = 0f;
            }
            return qpa;
        }
        //public static float qp()
        //{
        //    if (q == 50)
        //    {
        //        return 3f;
        //    }
        //    else if (q == 0)
        //    {
        //        return 0f;
        //    }
        //    return 0f;
        //}

    }
}
