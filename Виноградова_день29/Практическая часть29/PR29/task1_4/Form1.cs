using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Paint += new PaintEventHandler(this.OnPaint);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        DrawShapes(g);
    }

    private void DrawShapes(Graphics g)
    {
        // Рисуем три концентрических круга
        int centerX = 100, centerY = 100;
        for (int i = 0; i < 3; i++)
        {
            int radius = (i + 1) * 30;
            g.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        // Рисуем шесть квадратов в диагональной цепочке
        int startX = 200, startY = 200;
        int size = 40;
        for (int i = 0; i < 6; i++)
        {
            g.DrawRectangle(Pens.Black, startX, startY, size, size);
            startX += size / 2;
            startY += size / 2;
        }
    }
}
