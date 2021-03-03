using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tasks;

namespace program_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк ИСП-31, вариант 10", "О программе");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAnswerTask1_Click(object sender, EventArgs e)
        {
            try
            {
                answerTask1.Text = Convert.ToString(Tasks.Task1(Convert.ToDouble(task1X.Text)));
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка");
            }
            
        }

        private void GetAnswerTask2_Click(object sender, EventArgs e)
        {
            try
            {
                answerTask2.Text = Convert.ToString(Tasks.Task2(Convert.ToDouble(task2X.Text)));
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка");
            }
            
        }

        private void GetAnswerTask3_Click(object sender, EventArgs e)
        {
            try
            {
                answerTask3.Text = Convert.ToString(Tasks.Task3(Convert.ToInt32(task3X.Text)));
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка");
            }
            
        }

        private void GenerateMassTask4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double[] b = new double[random.Next(3, 6)];            
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = random.Next(-5, 5);
                massTask4.Text += Convert.ToString(b[i]) + " ";
                answerTask4.Text += Convert.ToString(Tasks.Task4(b)[i]) + " ";
            }            
            
        }

        private void GetMatrixTask5_Click(object sender, EventArgs e)
        {
            matrixTask5.Clear();
            double[,] matr1;
            double[] massMax;
            double[,] changeMatr;
            Tasks.Task5(out matr1, out massMax, out changeMatr);
            matrixTask5.Text += "Исходная матрица" + "\n";
            for(int i = 0; i < matr1.GetLength(0); i++)
            {
                for(int j = 0; j < matr1.GetLength(1); j++)
                {
                    matrixTask5.Text += matr1[i, j] + " ";
                }
                matrixTask5.Text += "\n";
            }
            matrixTask5.Text += "Максимальные значения в каждом столбце" + "\n";
            for (int i = 0; i < massMax.Length; i++)
            {
                matrixTask5.Text += massMax[i] + " ";
            }
            matrixTask5.Text += "\n";
            matrixTask5.Text += "Измененная матрица" + "\n";
            for (int i = 0; i < changeMatr.GetLength(0); i++)
            {
                for (int j = 0; j < changeMatr.GetLength(1); j++)
                {
                    matrixTask5.Text += changeMatr[i, j] + " ";
                }
                matrixTask5.Text += "\n";
            }
        }
    }
}
