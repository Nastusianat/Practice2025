using System;
using System.Linq;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        string input = string.Join(" ", listBox.Items.Cast<string>());

        var numbers = input.Split(' ')
                           .Where(s => int.TryParse(s, out _))
                           .Select(int.Parse);

        int evenCount = numbers.Count(n => n % 2 == 0);

        lblResult.Text = $"Четных чисел: {evenCount}";
    }
}
