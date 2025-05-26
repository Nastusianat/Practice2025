partial class Form1
{
    /// <summary>
    /// Объявление компонентов формы
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освобождаем ресурсы
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    /// <summary>
    /// Инициализация формы
    /// </summary>
    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Name = "Form1";
        this.Text = "Геометрические фигуры";
        this.ResumeLayout(false);
    }
}
