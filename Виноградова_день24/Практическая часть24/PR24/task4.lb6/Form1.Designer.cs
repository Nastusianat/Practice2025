partial class Form1
{
    private System.Windows.Forms.ListBox listBox;
    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Label lblResult;

    private void InitializeComponent()
    {
        this.listBox = new System.Windows.Forms.ListBox();
        this.btnCalculate = new System.Windows.Forms.Button();
        this.lblResult = new System.Windows.Forms.Label();

        // Настройка ListBox
        this.listBox.Items.AddRange(new object[] { "12", "5", "8", "19", "22", "7", "16", "3", "0", "10" });
        this.listBox.Dock = System.Windows.Forms.DockStyle.Top;

        // Настройка кнопки
        this.btnCalculate.Text = "ПУСК";
        this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

        // Метка результата
        this.lblResult.Text = "Четных чисел: ";
        this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;

        // Добавление элементов в форму
        this.Controls.Add(this.listBox);
        this.Controls.Add(this.btnCalculate);
        this.Controls.Add(this.lblResult);

        this.Text = "Подсчет четных чисел";
        this.ClientSize = new System.Drawing.Size(400, 300);
    }
}
