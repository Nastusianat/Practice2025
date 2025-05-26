using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ArrayProcessingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxOriginal;
        private ListBox listBoxModified;
        private Button buttonFill;
        private Button buttonReplace;
        private Button buttonSum;
        private Label labelOriginal;
        private Label labelModified;

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
            this.listBoxOriginal = new ListBox();
            this.listBoxModified = new ListBox();
            this.buttonFill = new Button();
            this.buttonReplace = new Button();
            this.buttonSum = new Button();
            this.labelOriginal = new Label();
            this.labelModified = new Label();

            this.SuspendLayout();

            // listBoxOriginal (Исходный массив)
            this.listBoxOriginal.FormattingEnabled = true;
            this.listBoxOriginal.Location = new System.Drawing.Point(12, 50);
            this.listBoxOriginal.Size = new System.Drawing.Size(250, 250);

            // listBoxModified (Полученный массив)
            this.listBoxModified.FormattingEnabled = true;
            this.listBoxModified.Location = new System.Drawing.Point(270, 50);
            this.listBoxModified.Size = new System.Drawing.Size(250, 250);

            // labelOriginal (Заголовок "Исходный массив")
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(12, 30);
            this.labelOriginal.Text = "Исходный массив";

            // labelModified (Заголовок "Полученный массив")
            this.labelModified.AutoSize = true;
            this.labelModified.Location = new System.Drawing.Point(270, 30);
            this.labelModified.Text = "Полученный массив";

            // buttonFill ("Заполнить")
            this.buttonFill.Location = new System.Drawing.Point(12, 310);
            this.buttonFill.Size = new System.Drawing.Size(130, 30);
            this.buttonFill.Text = "Заполнить";
            this.buttonFill.Click += new EventHandler(this.button1_Click);

            // buttonReplace ("Замена")
            this.buttonReplace.Location = new System.Drawing.Point(150, 310);
            this.buttonReplace.Size = new System.Drawing.Size(130, 30);
            this.buttonReplace.Text = "Замена";
            this.buttonReplace.Click += new EventHandler(this.button2_Click);

            // buttonSum ("Сумма кратных 5")
            this.buttonSum.Location = new System.Drawing.Point(290, 310);
            this.buttonSum.Size = new System.Drawing.Size(130, 30);
            this.buttonSum.Text = "Сумма кратных 5";
            this.buttonSum.Click += new EventHandler(this.buttonSum_Click);

            // Form1 (Главная форма)
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.listBoxOriginal);
            this.Controls.Add(this.listBoxModified);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.labelModified);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonSum);
            this.Text = "Одномерные массивы";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
