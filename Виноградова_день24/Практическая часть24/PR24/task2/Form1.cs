using System;
using System.Linq;
using System.Windows.Forms;

namespace ArrayProcessingApp
{
    public partial class Form1 : Form
    {
        private int[] A = new int[30]; // Глобальный массив
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Заполнение массива случайными числами
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxOriginal.Items.Clear();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(-50, 50);
                listBoxOriginal.Items.Add($"A[{i}] = {A[i]}");
            }
        }

        // Замена отрицательных элементов нулями
        private void button2_Click(object sender, EventArgs e)
        {
            listBoxModified.Items.Clear();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                    A[i] = 0;

                listBoxModified.Items.Add($"A[{i}] = {A[i]}");
            }
        }

        // Вычисление суммы элементов, кратных 5
        private void buttonSum_Click(object sender, EventArgs e)
        {
            int sum = A.Where(x => x % 5 == 0).Sum();
            MessageBox.Show($"Сумма элементов, кратных 5: {sum}");
        }
    }
}
