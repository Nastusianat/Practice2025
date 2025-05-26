using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private int[,] matrix = new int[4, 3];

    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        // Заполнение массива из DataGridView
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = Convert.ToInt32(dataGridView[j, i].Value);
            }
        }

        // Поиск максимального элемента
        int maxElement = matrix[0, 0];
        foreach (int value in matrix)
        {
            if (value > maxElement)
            {
                maxElement = value;
            }
        }

        // Вывод результата
        txtResult.Text = maxElement.ToString();
    }
}
