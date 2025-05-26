using System.Windows.Forms;

namespace TabulationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtX0, txtXk, txtDx, txtA, txtResults;
        private System.Windows.Forms.Label lblX0, lblXk, lblDx, lblA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtXk = new System.Windows.Forms.TextBox();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblXk = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Метки
            this.lblX0.Location = new System.Drawing.Point(20, 20);
            this.lblX0.Size = new System.Drawing.Size(40, 20);
            this.lblX0.Text = "X0 =";

            this.lblXk.Location = new System.Drawing.Point(20, 50);
            this.lblXk.Size = new System.Drawing.Size(40, 20);
            this.lblXk.Text = "Xk =";

            this.lblDx.Location = new System.Drawing.Point(140, 20);
            this.lblDx.Size = new System.Drawing.Size(40, 20);
            this.lblDx.Text = "Dx =";

            this.lblA.Location = new System.Drawing.Point(140, 50);
            this.lblA.Size = new System.Drawing.Size(40, 20);
            this.lblA.Text = "A =";

            // Поля ввода
            this.txtX0.Location = new System.Drawing.Point(60, 20);
            this.txtX0.Size = new System.Drawing.Size(60, 20);

            this.txtXk.Location = new System.Drawing.Point(60, 50);
            this.txtXk.Size = new System.Drawing.Size(60, 20);

            this.txtDx.Location = new System.Drawing.Point(180, 20);
            this.txtDx.Size = new System.Drawing.Size(60, 20);

            this.txtA.Location = new System.Drawing.Point(180, 50);
            this.txtA.Size = new System.Drawing.Size(60, 20);

            // Поле результатов
            this.txtResults.Location = new System.Drawing.Point(20, 90);
            this.txtResults.Size = new System.Drawing.Size(340, 150);
            this.txtResults.Multiline = true;
            this.txtResults.ScrollBars = ScrollBars.Vertical;
            this.txtResults.ReadOnly = true;

            // Кнопка "Вычислить" (внизу)
            this.btnCalculate.Location = new System.Drawing.Point(20, 250);
            this.btnCalculate.Size = new System.Drawing.Size(340, 30);
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Формирование формы
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.lblXk);
            this.Controls.Add(this.txtXk);
            this.Controls.Add(this.lblDx);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Табуляция функции";

            this.ResumeLayout(false);
        }
    }
}
