using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCarDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Простая машина";
            this.ClientSize = new Size(400, 300);
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Очищаем фон
            g.Clear(Color.White);

            // Рисуем кузов машины (прямоугольник)
            g.FillRectangle(Brushes.Blue, 100, 150, 200, 50);

            // Рисуем крышу машины (прямоугольник)
            g.FillRectangle(Brushes.Blue, 150, 120, 100, 30);

            // Рисуем колеса (круги)
            g.FillEllipse(Brushes.Black, 120, 190, 40, 40);
            g.FillEllipse(Brushes.Black, 240, 190, 40, 40);

            // Рисуем окна (прямоугольники)
            g.FillRectangle(Brushes.LightBlue, 160, 125, 40, 20);
            g.FillRectangle(Brushes.LightBlue, 200, 125, 40, 20);

            // Рисуем фары (круги)
            g.FillEllipse(Brushes.Yellow, 90, 165, 20, 20);  // Передняя фара
            g.FillEllipse(Brushes.Red, 290, 165, 20, 20);   // Задняя фара
        }
    }
}