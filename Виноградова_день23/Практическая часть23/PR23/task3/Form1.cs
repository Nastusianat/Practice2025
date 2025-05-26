using System;
using System.Windows.Forms;

namespace TabulationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля содержат числа
            if (string.IsNullOrWhiteSpace(txtX0.Text) || string.IsNullOrWhiteSpace(txtXk.Text) ||
                string.IsNullOrWhiteSpace(txtDx.Text) || string.IsNullOrWhiteSpace(txtA.Text))
            {
                MessageBox.Show("Ошибка ввода! Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtX0.Text.Replace(',', '.'), out double x0) ||
                !double.TryParse(txtXk.Text.Replace(',', '.'), out double xk) ||
                !double.TryParse(txtDx.Text.Replace(',', '.'), out double dx) ||
                !double.TryParse(txtA.Text.Replace(',', '.'), out double a))
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем диапазоны
            if (dx <= 0 || x0 > xk)
            {
                MessageBox.Show("Ошибка: Проверьте диапазон значений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Очищаем поле вывода
            txtResults.Clear();

            // Вычисления
            for (double x = x0; x <= xk; x += dx)
            {
                double y = Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - a);
                txtResults.AppendText($"x = {x:F2}; y = {y:F4}{Environment.NewLine}");
            }
        }
    }
}
