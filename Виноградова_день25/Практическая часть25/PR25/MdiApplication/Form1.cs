using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        private ToolStripStatusLabel statuslabel; // Панель состояния

        public ParentForm()
        {
            InitializeComponent();

            // Инициализация панели состояния
            statuslabel = new ToolStripStatusLabel();
            statuslabel.Text = DateTime.Today.ToLongDateString();
            statusStrip1.Items.Add(statuslabel);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            statuslabel.Text = "Windows is cascade"; // Отображение текста
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            statuslabel.Text = "Windows is horizontal"; // Отображение текста
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
            newChild.Text = $"Документ {++openDocuments}";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag?.ToString())
            {
                case "NewDoc":
                    newMenuItem_Click(sender, e);
                    break;
                case "Cascade":
                    WindowCascadeMenuItem_Click(sender, e);
                    break;
                case "Title":
                    WindowTileMenuItem_Click(sender, e);
                    break;
            }
        }
    }
}
