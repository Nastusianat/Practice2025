using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        string input = txtInput.Text.ToUpper();
        int x, y;

        // Проверяем ввод координат
        if (!int.TryParse(txtX.Text, out x) || !int.TryParse(txtY.Text, out y))
        {
            MessageBox.Show("Введите корректные координаты!");
            return;
        }

        Control newControl = null;

        // Определяем, какой элемент создать
        if (input.Contains("К"))
            newControl = new Button { Text = "Новая кнопка", BackColor = Color.LightBlue, Size = new Size(100, 40) };
        else if (input.Contains("П"))
            newControl = new TextBox { BackColor = Color.LightGreen, Size = new Size(120, 30) };
        else if (input.Contains("М"))
            newControl = new Label { Text = "Новая метка", BackColor = Color.LightCoral, AutoSize = true };

        if (newControl != null)
        {
            newControl.Location = new Point(x, y);
            newControl.MouseEnter += (s, ev) => Controls.Remove((Control)s); // Удаление элемента при наведении курсора
            Controls.Add(newControl);
        }
        else
        {
            MessageBox.Show("Введите К, П или М для создания элемента!");
        }
    }
}
