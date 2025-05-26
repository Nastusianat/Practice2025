using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    Point[] points = new Point[20]; 
    Pen pen = new Pen(Color.Black, 2); 
    Pen diagonalPen = new Pen(Color.Black, 2); 

    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        int width = this.ClientSize.Width;
        int height = this.ClientSize.Height;

        for (int i = 0; i < points.Length; i++)
        {
            int xPos = (i % 2 == 0) ? 10 : width - 10; 
            int yPos = 10 * i;
            points[i] = new Point(xPos, yPos);
        }
        Invalidate(); 
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        g.DrawLines(pen, points);

        g.DrawLine(diagonalPen, new Point(0, 0), new Point(this.ClientSize.Width, this.ClientSize.Height));
    }
}
