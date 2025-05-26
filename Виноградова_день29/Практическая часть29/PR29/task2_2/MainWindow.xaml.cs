using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace EllipseAndSquaresApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawShapes();
        }

        private void DrawShapes()
        {
            DrawingVisual visual = new DrawingVisual();
            using (DrawingContext drawingContext = visual.RenderOpen())
            {
                // 1. Рисуем концентрические эллипсы
                double centerX = 200;
                double centerY = 100;
                double[] radiiX = { 80, 60, 40, 20 }; // Радиусы по оси X
                double[] radiiY = { 40, 30, 20, 10 }; // Радиусы по оси Y

                for (int i = 0; i < radiiX.Length; i++)
                {
                    drawingContext.DrawEllipse(null, new Pen(Brushes.Black, 2), new Point(centerX, centerY), radiiX[i], radiiY[i]);
                }

                // 2. Рисуем последовательность квадратов
                double startX = 50;
                double startY = 200;
                double squareSize = 30;

                for (int i = 0; i < 5; i++)
                {
                    drawingContext.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(startX, startY, squareSize, squareSize));
                    startX += 10; // Сдвигаем по X
                    startY += 10; // Сдвигаем по Y
                    squareSize += 10; // Увеличиваем размер квадрата
                }
            }

            // Добавляем DrawingVisual на Canvas
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap(400, 400, 96d, 96d, PixelFormats.Pbgra32);
            renderBitmap.Render(visual);

            Image image = new Image
            {
                Source = renderBitmap,
                Width = 400,
                Height = 400
            };
            DrawingCanvas.Children.Add(image);
        }
    }
}