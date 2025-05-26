using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ChessBoardApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawChessBoard();
        }

        private void DrawChessBoard()
        {
            double squareSize = 50; // Размер каждой клетки
            int gridSize = 8; // Размер шахматной доски

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    // Определяем цвет клетки
                    Brush color = (row + col) % 2 == 0 ? Brushes.White : Brushes.Black;

                    // Рисуем клетку
                    Rectangle rectangle = new Rectangle
                    {
                        Fill = color,
                        Width = squareSize,
                        Height = squareSize
                    };

                    // Устанавливаем положение клетки
                    Canvas.SetLeft(rectangle, col * squareSize);
                    Canvas.SetTop(rectangle, row * squareSize);

                    // Добавляем клетку на Canvas
                    DrawingCanvas.Children.Add(rectangle);
                }
            }
        }
    }
}