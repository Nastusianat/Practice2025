using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        double h = 0.1; // Шаг изменения X
        double startX = -Math.PI * 2; // Начало диапазона (чтобы захватить отрицательные значения)
        double endX = Math.PI * 2; // Конец диапазона

        listBox.Items.Clear();
        Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        Graphics g = Graphics.FromImage(bitmap);
        g.Clear(Color.White);

        int centerX = pictureBox.Width / 2;
        int centerY = pictureBox.Height / 2;
        int scaleX = 50; // Масштаб X
        int scaleY = 50; // Масштаб Y
        Pen axisPen = new Pen(Color.Black, 2);
        Pen graphPen = new Pen(Color.Blue, 2);
        Point? previousPoint = null;

        // Рисуем координатные оси
        g.DrawLine(axisPen, new Point(centerX, 0), new Point(centerX, pictureBox.Height)); // Вертикальная ось
        g.DrawLine(axisPen, new Point(0, centerY), new Point(pictureBox.Width, centerY)); // Горизонтальная ось

        for (double x = startX; x <= endX; x += h)
        {
            double tanX = Math.Tan(x);
            if (Math.Abs(tanX) < 1e-3) continue; // Исключаем деление на 0

            double y = 1 / tanX; // ctg(x)
            listBox.Items.Add($"X = {x:F2}, Y = {y:F2}");

            int pixelX = centerX + (int)(x * scaleX);
            int pixelY = centerY - (int)(y * scaleY);

            if (previousPoint.HasValue && pixelY >= 0 && pixelY < pictureBox.Height)
            {
                g.DrawLine(graphPen, previousPoint.Value, new Point(pixelX, pixelY));
            }
            previousPoint = new Point(pixelX, pixelY);
        }

        pictureBox.Image = bitmap;
    }
}
