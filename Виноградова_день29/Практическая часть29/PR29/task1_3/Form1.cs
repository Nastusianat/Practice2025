using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        Pen pen = new Pen(Color.Black, 2);
        Brush brush = new SolidBrush(Color.Blue);

        // 1. Треугольник
        Point[] trianglePoints = { new Point(50, 50), new Point(100, 150), new Point(150, 50) };
        g.DrawPolygon(pen, trianglePoints);

        // 2. Эллипс
        g.DrawEllipse(pen, 200, 50, 100, 50);

        // 3. Закрашенный круг
        g.FillEllipse(brush, 350, 50, 50, 50);

        // 4. Закрашенный прямоугольник
        g.FillRectangle(brush, 50, 200, 100, 50);

        // 5. Сектор (часть круга)
        g.FillPie(brush, 200, 200, 100, 100, 0, 90);
    }
}
