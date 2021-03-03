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
            z = Math.Sqrt(Math.Pow(x,4) - 64) * Math.Pow(Math.Abs((Math.Log10(y) + Math.Cos(x * x)) / (4 * x + 5)),1/3);
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
        public static double[] Task4(double[] b)
        {
            double[] a = new double[b.Length];
            int j = b.Length - 1;
            for(int i = 0; i < j + 1; i++)
            {
                a[i] = b[i] / (j + 1);
            }
            return a;
        }

        public static void Task5(out double[,] matr1, out double[] massMax, out double[,] changeMatr)
        {
            Random random = new Random();
            int row = random.Next(2, 6);
            int column = random.Next(2, 6);            
            matr1 = new double[row, column];
            //Генерируем матрицу
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matr1[i, j] = random.Next(-5, 5);
                }
            }
            massMax = new double[column];
            for(int j = 0; j < column; j++)
            {
                double current = matr1[0, j];
                for(int i = 1; i < row; i++)
                {
                    if(matr1[i,j] > current)
                    {
                        current = matr1[i, j];
                    }
                }
                massMax[j] = current;
            }
            changeMatr = new double[row, column];
            int position1 = 0;
            int position2 = 0;
            int position3 = 0;
            int position4 = 0;
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    if(matr1[i,j] < 0)
                    {
                        position1 = i;
                        position2 = j;
                        break;
                    }
                }
                for (int j = 0; j < column; j++)
                {
                    if (matr1[i, j] > 0)
                    {
                        position3 = i;
                        position4 = j;                        
                    }
                }
            }
            changeMatr = matr1;
            double glass = changeMatr[position1, position2];
            changeMatr[position1, position2] = changeMatr[position3, position4];
            changeMatr[position3, position4] = glass;            
        }
    }
}
