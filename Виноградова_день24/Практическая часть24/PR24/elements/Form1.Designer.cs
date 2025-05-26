using System.Drawing;
using System;
using System.Windows.Forms;

partial class Form1
{
    private TextBox txtInput;
    private TextBox txtX;
    private TextBox txtY;
    private Button btnGenerate;
    private Label lblInstruction;

    private void InitializeComponent()
    {
        this.txtInput = new TextBox();
        this.txtX = new TextBox();
        this.txtY = new TextBox();
        this.btnGenerate = new Button();
        this.lblInstruction = new Label();

        // Инструкции
        this.lblInstruction.Text = "Введите К (Кнопка), П (Поле), М (Метка) и координаты:";
        this.lblInstruction.AutoSize = true;
        this.lblInstruction.Location = new Point(10, 10);

        // Поля ввода
        this.txtInput.Location = new Point(10, 40);
        this.txtInput.Width = 100;

        this.txtX.Location = new Point(120, 40);
        this.txtX.Width = 50;

        this.txtY.Location = new Point(180, 40);
        this.txtY.Width = 50;

        // Кнопка
        this.btnGenerate.Text = "Создать элемент";
        this.btnGenerate.Location = new Point(10, 80);
        this.btnGenerate.Click += new EventHandler(this.btnGenerate_Click);

        // Добавление элементов на форму
        this.Controls.Add(this.lblInstruction);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.txtX);
        this.Controls.Add(this.txtY);
        this.Controls.Add(this.btnGenerate);

        this.Text = "Динамическое создание элементов";
        this.ClientSize = new Size(400, 300);
    }
}
