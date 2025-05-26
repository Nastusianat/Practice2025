using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int i;
            double x;

            if (int.TryParse(textBox1.Text, out i) && double.TryParse(textBox2.Text, out x))
            {
                double result = CalculateE(i, x);
                textBox3.Text = $"Результат: e = {result}";
            }
            else
            {
                MessageBox.Show("Введите корректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = "Результат:";
        }

        private double CalculateE(int i, double x)
        {
            double f(double val) => Math.Pow(val, 2) + 1;

            if (i % 2 != 0 && x > 0)
            {
                return i * Math.Sqrt(f(x));
            }
            else if (i % 2 == 0 && x < 0)
            {
                return (i / 2.0) * Math.Sqrt(f(x));
            }
            else
            {
                return Math.Sqrt(Math.Abs(f(x)));
            }
        }
    }
}
