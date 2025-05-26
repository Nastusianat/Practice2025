using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                double alpha = CalculateAlpha(x, y, z);

                textBox4.Text = $"α = {alpha:F5}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private double CalculateAlpha(double x, double y, double z)
        {
            return Math.Log(y * Math.Sqrt(Math.Abs(x))) * (x - (y / 2)) + Math.Pow(Math.Sin(Math.Atan(z)), 2);
        }

        private void task1_Load(object sender, EventArgs e)
        {

        }
    }
}

