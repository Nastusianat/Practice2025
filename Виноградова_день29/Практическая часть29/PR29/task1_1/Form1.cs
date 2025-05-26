using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawLinesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawLines(e.Graphics);
        }

        private void DrawLines(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 2); // Черная ручка с шириной 2 пикселя
            int lineSpacing = 10; // Расстояние между линиями
            int startY = 0; // Начальная позиция по Y

            // Рисуем горизонтальные линии
            for (int i = 0; i < this.ClientSize.Height / lineSpacing; i++)
            {
                g.DrawLine(blackPen, 0, startY + (i * lineSpacing), this.ClientSize.Width, startY + (i * lineSpacing));
            }
        }
    }
}