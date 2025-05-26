using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChessBoardApp
{
    public partial class Form1 : Form
    {
        private const int GridSize = 8; // Размер шахматной доски
        private const int CellSize = 50; // Размер клетки

        public Form1()
        {
            InitializeComponent();
            CreateChessBoard();
        }

        private void CreateChessBoard()
        {
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    Panel cell = new Panel
                    {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point(j * CellSize, i * CellSize),
                        BackColor = (i + j) % 2 == 0 ? Color.White : Color.Black
                    };

                    this.Controls.Add(cell);
                }
            }
        }
    }
}
