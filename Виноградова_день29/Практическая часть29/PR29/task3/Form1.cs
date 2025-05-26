using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomButtonsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Custom Buttons";
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Кнопка треугольная
            Button triangleButton = new Button();
            triangleButton.Size = new Size(100, 100);
            triangleButton.Location = new Point(50, 50);
            triangleButton.Paint += new PaintEventHandler(DrawTriangleButton);
            triangleButton.FlatStyle = FlatStyle.Flat;
            triangleButton.FlatAppearance.BorderSize = 0;

            // Кнопка круглая
            Button circleButton = new Button();
            circleButton.Size = new Size(100, 100);
            circleButton.Location = new Point(200, 50);
            circleButton.Paint += new PaintEventHandler(DrawCircleButton);
            circleButton.FlatStyle = FlatStyle.Flat;
            circleButton.FlatAppearance.BorderSize = 0;

            // Кнопка в форме пирамиды
            Button pyramidButton = new Button();
            pyramidButton.Size = new Size(100, 100);
            pyramidButton.Location = new Point(125, 200);
            pyramidButton.Paint += new PaintEventHandler(DrawPyramidButton);
            pyramidButton.FlatStyle = FlatStyle.Flat;
            pyramidButton.FlatAppearance.BorderSize = 0;

            // Добавляем кнопки на форму
            this.Controls.Add(triangleButton);
            this.Controls.Add(circleButton);
            this.Controls.Add(pyramidButton);
        }

        private void DrawTriangleButton(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Graphics g = e.Graphics;
            Point[] points = new Point[]
            {
                new Point(btn.Width / 2, 0),
                new Point(btn.Width, btn.Height),
                new Point(0, btn.Height)
            };
            g.FillPolygon(Brushes.LightBlue, points);
            g.DrawPolygon(Pens.Black, points);
        }

        private void DrawCircleButton(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.LightGreen, 0, 0, btn.Width, btn.Height);
            g.DrawEllipse(Pens.Black, 0, 0, btn.Width, btn.Height);
        }

        private void DrawPyramidButton(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Graphics g = e.Graphics;
            Point[] points = new Point[]
            {
                new Point(btn.Width / 2, 0),
                new Point(btn.Width, btn.Height),
                new Point(0, btn.Height)
            };
            g.FillPolygon(Brushes.LightCoral, points);
            g.DrawPolygon(Pens.Black, points);
        }
    }
}