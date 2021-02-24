using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class Tasks
    {
        public static double Task1(double x)
        {
            double z;
            double e = 2.71828182846;
            z = Math.Pow(Math.Abs(x * x + 4), 7) + Math.Sqrt(x * x + 4) - Math.Log10(x * x + 4);
            return z;
        }

        public static double Task2(double x)
        {
            double z;
            double y = 1.2;
            z = Math.Sqrt(x * x * x * x - 64) * Math.Pow(Math.Abs((Math.Log10(y) + Math.Cos(x * x)) / (4 * x + 5)),1/3);
            return z;
        }
        public static double Task3(int n)
        {
            double summ = 0;
            double a = 1;
            double b = 2;
            for(int i = 0; i < n; i++)
            {
                a += 2;
                b += 2;
                summ += a / b;
            }
            return summ;
        }
    }
}
