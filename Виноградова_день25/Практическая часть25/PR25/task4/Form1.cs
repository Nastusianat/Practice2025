using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeDataApp
{
    public partial class MainForm : Form
    {
        private List<Employee> employees = new List<Employee>();
        private ToolTip toolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Text = "Анкетные данные сотрудника";
            this.ClientSize = new System.Drawing.Size(500, 650);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            InitializeControls();
        }

        private void InitializeControls()
        {
            var lblTitle = new Label
            {
                Text = "Анкетные данные сотрудника",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };

            // ФИО
            var lblLastName = new Label { Text = "Фамилия", Location = new System.Drawing.Point(10, 50) };
            var txtLastName = new TextBox { Location = new System.Drawing.Point(150, 50), Width = 200 };

            var lblFirstName = new Label { Text = "Имя", Location = new System.Drawing.Point(10, 80) };
            var txtFirstName = new TextBox { Location = new System.Drawing.Point(150, 80), Width = 200 };

            var lblMiddleName = new Label { Text = "Отчество", Location = new System.Drawing.Point(10, 110) };
            var txtMiddleName = new TextBox { Location = new System.Drawing.Point(150, 110), Width = 200 };

            // Дата рождения
            var lblBirthDate = new Label { Text = "Дата рождения", Location = new System.Drawing.Point(10, 150) };
            var lblDay = new Label { Text = "День", Location = new System.Drawing.Point(20, 180) };
            var txtDay = new TextBox { Location = new System.Drawing.Point(70, 180), Width = 50 };
            var lblMonth = new Label { Text = "Месяц", Location = new System.Drawing.Point(150, 180) };
            var cmbMonth = new ComboBox
            {
                Location = new System.Drawing.Point(210, 180),
                Width = 100,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbMonth.Items.AddRange(new[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" });
            var lblYear = new Label { Text = "Год", Location = new System.Drawing.Point(330, 180) };
            var txtYear = new TextBox { Location = new System.Drawing.Point(370, 180), Width = 60 };

            // Место проживания
            var lblResidence = new Label { Text = "Место проживания", Location = new System.Drawing.Point(10, 220) };
            var txtResidence = new TextBox { Location = new System.Drawing.Point(150, 220), Width = 200 };

            // Контакты
            var lblEmail = new Label { Text = "Адрес электронной почты", Location = new System.Drawing.Point(10, 250) };
            var txtEmail = new TextBox { Location = new System.Drawing.Point(150, 250), Width = 200 };
            var lblPhone = new Label { Text = "Мобильный телефон", Location = new System.Drawing.Point(10, 280) };
            var cmbOperator = new ComboBox
            {
                Location = new System.Drawing.Point(150, 280),
                Width = 80,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbOperator.Items.AddRange(new[] { "MTC", "A1", "Life" });
            var txtPhone = new TextBox { Location = new System.Drawing.Point(240, 280), Width = 120 };

            // Опыт работы
            var lblExperience = new Label { Text = "Опыт работы", Location = new System.Drawing.Point(10, 320) };
            var rbNoExp = new RadioButton { Text = "Прежде не работал", Location = new System.Drawing.Point(20, 350) };
            var rb1to5 = new RadioButton { Text = "От 1 года до 5 лет", Location = new System.Drawing.Point(20, 380) };
            var rbLess1 = new RadioButton { Text = "Меньше 1 года", Location = new System.Drawing.Point(20, 410) };
            var rb5to9 = new RadioButton { Text = "От 5 до 9 лет", Location = new System.Drawing.Point(20, 440) };

            // Дополнительные сведения
            var lblOther = new Label { Text = "Другие сведения", Location = new System.Drawing.Point(10, 480) };
            var chkCar = new CheckBox { Text = "Наличие личного авто", Location = new System.Drawing.Point(20, 510), Checked = true };
            var chkLicense = new CheckBox { Text = "Водительское удостоверение", Location = new System.Drawing.Point(20, 540) };

            var lblCategories = new Label { Text = "Категория прав", Location = new System.Drawing.Point(200, 510) };
            var chkA = new CheckBox { Text = "A", Location = new System.Drawing.Point(200, 540) };
            var chkB = new CheckBox { Text = "B", Location = new System.Drawing.Point(240, 540) };
            var chkC = new CheckBox { Text = "C", Location = new System.Drawing.Point(280, 540) };
            var chkD = new CheckBox { Text = "D", Location = new System.Drawing.Point(320, 540) };

            // Резюме и зарплата
            var lblSummary = new Label { Text = "Краткое резюме", Location = new System.Drawing.Point(10, 570) };
            var txtSummary = new TextBox { Location = new System.Drawing.Point(150, 570), Width = 200, Height = 50, Multiline = true };
            var lblSalary = new Label { Text = "Объем заработной платы", Location = new System.Drawing.Point(10, 630) };
            var numSalary = new NumericUpDown { Location = new System.Drawing.Point(150, 630), Width = 80, Minimum = 523 };
            var chkSalary700 = new CheckBox { Text = "До 700", Location = new System.Drawing.Point(240, 630) };

            // График работы
            var lblSchedule = new Label { Text = "Предпочитаемый график работы", Location = new System.Drawing.Point(10, 660) };
            var rbFull = new RadioButton { Text = "полная занятость", Location = new System.Drawing.Point(20, 690) };
            var rbHome = new RadioButton { Text = "работа на дому", Location = new System.Drawing.Point(20, 720) };
            var rbPart = new RadioButton { Text = "частичная занятость", Location = new System.Drawing.Point(20, 750) };
            var rbShift = new RadioButton { Text = "посменная работа", Location = new System.Drawing.Point(20, 780) };

            // Кнопки
            var btnSave = new Button { Text = "Сохранить данные", Location = new System.Drawing.Point(20, 820), Width = 120 };
            var btnClear = new Button { Text = "Очистить форму", Location = new System.Drawing.Point(160, 820), Width = 120 };
            var btnCancel = new Button { Text = "Отмена", Location = new System.Drawing.Point(300, 820), Width = 80 };

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
                lblTitle,
                lblLastName, txtLastName,
                lblFirstName, txtFirstName,
                lblMiddleName, txtMiddleName,
                lblBirthDate,
                lblDay, txtDay,
                lblMonth, cmbMonth,
                lblYear, txtYear,
                lblResidence, txtResidence,
                lblEmail, txtEmail,
                lblPhone, cmbOperator, txtPhone,
                lblExperience, rbNoExp, rb1to5, rbLess1, rb5to9,
                lblOther, chkCar, chkLicense,
                lblCategories, chkA, chkB, chkC, chkD,
                lblSummary, txtSummary,
                lblSalary, numSalary, chkSalary700,
                lblSchedule, rbFull, rbHome, rbPart, rbShift,
                btnSave, btnClear, btnCancel
            });

            // Всплывающие подсказки
            toolTip.SetToolTip(txtLastName, "Введите фамилию сотрудника.");
            toolTip.SetToolTip(txtFirstName, "Введите имя сотрудника.");
            toolTip.SetToolTip(txtMiddleName, "Введите отчество сотрудника.");
            toolTip.SetToolTip(txtDay, "Введите день рождения.");
            toolTip.SetToolTip(cmbMonth, "Выберите месяц рождения.");
            toolTip.SetToolTip(txtYear, "Введите год рождения.");
            toolTip.SetToolTip(txtResidence, "Введите место проживания.");
            toolTip.SetToolTip(txtEmail, "Введите адрес электронной почты.");
            toolTip.SetToolTip(txtPhone, "Введите номер мобильного телефона.");
            toolTip.SetToolTip(btnSave, "Сохранить данные сотрудника.");
            toolTip.SetToolTip(btnClear, "Очистить все поля формы.");
            toolTip.SetToolTip(btnCancel, "Закрыть форму.");

            // Обработчики событий
            btnSave.Click += (s, e) => SaveEmployee();
            btnClear.Click += (s, e) => ClearForm();
            btnCancel.Click += (s, e) => this.Close();
        }

        private void SaveEmployee()
        {
            // Реализация сохранения данных
            MessageBox.Show("Данные сотрудника сохранены!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            // Очистка всех полей формы
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                    textBox.Clear();
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is NumericUpDown numericUpDown)
                    numericUpDown.Value = numericUpDown.Minimum;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Можно добавить код для инициализации при загрузке формы
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }

    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string BirthDay { get; set; }
        public string BirthMonth { get; set; }
        public string BirthYear { get; set; }
        public string Residence { get; set; }
        public string Email { get; set; }
        public string PhoneOperator { get; set; }
        public string PhoneNumber { get; set; }
        public string Experience { get; set; }
        public bool HasCar { get; set; }
        public bool HasLicense { get; set; }
        public string LicenseCategories { get; set; }
        public string Summary { get; set; }
        public decimal Salary { get; set; }
        public bool SalaryUpTo700 { get; set; }
        public string WorkSchedule { get; set; }
    }
}