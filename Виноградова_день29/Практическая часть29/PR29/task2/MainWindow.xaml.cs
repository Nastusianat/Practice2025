using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShapesDrawingApp
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
                // 1. Рисуем треугольник
                Point[] trianglePoints = new Point[]
                {
                    new Point(50, 150),
                    new Point(100, 50),
                    new Point(150, 150)
                };
                drawingContext.DrawGeometry(Brushes.Blue, null, CreatePolygonGeometry(trianglePoints));

                // 2. Рисуем эллипс
                drawingContext.DrawEllipse(Brushes.Green, null, new Point(250, 75), 50, 25);

                // 3. Рисуем закрашенный круг
                drawingContext.DrawEllipse(Brushes.Red, null, new Point(100, 300), 30, 30);

                // 4. Рисуем закрашенный прямоугольник
                Rect rectangleRect = new Rect(200, 250, 100, 50);
                drawingContext.DrawRectangle(Brushes.Yellow, null, rectangleRect);

                // 5. Рисуем сектор
                Point center = new Point(250, 300);
                double radius = 50;

                StreamGeometry geometry = CreateSectorGeometry(center, radius);
                drawingContext.DrawGeometry(Brushes.Purple, null, geometry);
            }

            // Добавляем визуализацию в Canvas
            DrawingCanvas.Children.Add(CreateDrawingVisual(visual));
        }

        private UIElement CreateDrawingVisual(DrawingVisual visual)
        {
            // Создаем Image для отображения DrawingVisual
            RenderTargetBitmap renderBitmap = new RenderTargetBitmap(400, 400, 96d, 96d, PixelFormats.Pbgra32);
            renderBitmap.Render(visual);

            Image image = new Image
            {
                Source = renderBitmap,
                Width = 400,
                Height = 400
            };
            return image;
        }

        private StreamGeometry CreatePolygonGeometry(Point[] points)
        {
            StreamGeometry geometry = new StreamGeometry();
            using (StreamGeometryContext ctx = geometry.Open())
            {
                ctx.BeginFigure(points[0], true, true);
                for (int i = 1; i < points.Length; i++)
                {
                    ctx.LineTo(points[i], true, false);
                }
            }
            return geometry;
        }

        private StreamGeometry CreateSectorGeometry(Point center, double radius)
        {
            StreamGeometry geometry = new StreamGeometry();
            using (StreamGeometryContext ctx = geometry.Open())
            {
                ctx.BeginFigure(center, true, true);
                ctx.LineTo(new Point(center.X + radius, center.Y), true, false);
                ctx.ArcTo(new Point(center.X, center.Y - radius), new Size(radius, radius), 0,
                          false, SweepDirection.Clockwise, true, false);
            }
            return geometry;
        }
    }
}