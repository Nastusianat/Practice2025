using System.Xml.Linq;
using System;

namespace EmployeeDataApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblResidence = new System.Windows.Forms.Label();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblExperience = new System.Windows.Forms.Label();
            this.rbNoExp = new System.Windows.Forms.RadioButton();
            this.rb1to5 = new System.Windows.Forms.RadioButton();
            this.rbLess1 = new System.Windows.Forms.RadioButton();
            this.rb5to9 = new System.Windows.Forms.RadioButton();
            this.lblOther = new System.Windows.Forms.Label();
            this.chkCar = new System.Windows.Forms.CheckBox();
            this.chkLicense = new System.Windows.Forms.CheckBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkD = new System.Windows.Forms.CheckBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.chkSalary700 = new System.Windows.Forms.CheckBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbHome = new System.Windows.Forms.RadioButton();
            this.rbPart = new System.Windows.Forms.RadioButton();
            this.rbShift = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Анкетные данные сотрудника";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(18, 92);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(275, 92);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(363, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 148);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 25);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(275, 148);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(363, 29);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(18, 203);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(104, 25);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(275, 203);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(6);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(363, 29);
            this.txtMiddleName.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(18, 277);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(161, 25);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Дата рождения";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(37, 332);
            this.lblDay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(61, 25);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "День";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(128, 332);
            this.txtDay.Margin = new System.Windows.Forms.Padding(6);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(88, 29);
            this.txtDay.TabIndex = 9;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(275, 332);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(72, 25);
            this.lblMonth.TabIndex = 10;
            this.lblMonth.Text = "Месяц";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.cmbMonth.Location = new System.Drawing.Point(385, 332);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(6);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(180, 32);
            this.cmbMonth.TabIndex = 11;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(605, 332);
            this.lblYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 25);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Год";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(678, 332);
            this.txtYear.Margin = new System.Windows.Forms.Padding(6);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(107, 29);
            this.txtYear.TabIndex = 13;
            // 
            // lblResidence
            // 
            this.lblResidence.AutoSize = true;
            this.lblResidence.Location = new System.Drawing.Point(18, 406);
            this.lblResidence.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResidence.Name = "lblResidence";
            this.lblResidence.Size = new System.Drawing.Size(191, 25);
            this.lblResidence.TabIndex = 14;
            this.lblResidence.Text = "Место проживания";
            // 
            // txtResidence
            // 
            this.txtResidence.Location = new System.Drawing.Point(275, 406);
            this.txtResidence.Margin = new System.Windows.Forms.Padding(6);
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(363, 29);
            this.txtResidence.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 462);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(260, 25);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Адрес электронной почты";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(275, 462);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 29);
            this.txtEmail.TabIndex = 17;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 517);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(211, 25);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Мобильный телефон";
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "MTC",
            "A1",
            "Life"});
            this.cmbOperator.Location = new System.Drawing.Point(275, 517);
            this.cmbOperator.Margin = new System.Windows.Forms.Padding(6);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(143, 32);
            this.cmbOperator.TabIndex = 19;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(440, 517);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 29);
            this.txtPhone.TabIndex = 20;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(18, 591);
            this.lblExperience.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(138, 25);
            this.lblExperience.TabIndex = 21;
            this.lblExperience.Text = "Опыт работы";
            // 
            // rbNoExp
            // 
            this.rbNoExp.AutoSize = true;
            this.rbNoExp.Location = new System.Drawing.Point(37, 646);
            this.rbNoExp.Margin = new System.Windows.Forms.Padding(6);
            this.rbNoExp.Name = "rbNoExp";
            this.rbNoExp.Size = new System.Drawing.Size(222, 29);
            this.rbNoExp.TabIndex = 22;
            this.rbNoExp.TabStop = true;
            this.rbNoExp.Text = "Прежде не работал";
            this.rbNoExp.UseVisualStyleBackColor = true;
            // 
            // rb1to5
            // 
            this.rb1to5.AutoSize = true;
            this.rb1to5.Location = new System.Drawing.Point(293, 646);
            this.rb1to5.Margin = new System.Windows.Forms.Padding(6);
            this.rb1to5.Name = "rb1to5";
            this.rb1to5.Size = new System.Drawing.Size(210, 29);
            this.rb1to5.TabIndex = 23;
            this.rb1to5.TabStop = true;
            this.rb1to5.Text = "От 1 года до 5 лет";
            this.rb1to5.UseVisualStyleBackColor = true;
            // 
            // rbLess1
            // 
            this.rbLess1.AutoSize = true;
            this.rbLess1.Location = new System.Drawing.Point(35, 696);
            this.rbLess1.Margin = new System.Windows.Forms.Padding(6);
            this.rbLess1.Name = "rbLess1";
            this.rbLess1.Size = new System.Drawing.Size(174, 29);
            this.rbLess1.TabIndex = 24;
            this.rbLess1.TabStop = true;
            this.rbLess1.Text = "Меньше 1 года";
            this.rbLess1.UseVisualStyleBackColor = true;
            // 
            // rb5to9
            // 
            this.rb5to9.AutoSize = true;
            this.rb5to9.Location = new System.Drawing.Point(289, 696);
            this.rb5to9.Margin = new System.Windows.Forms.Padding(6);
            this.rb5to9.Name = "rb5to9";
            this.rb5to9.Size = new System.Drawing.Size(164, 29);
            this.rb5to9.TabIndex = 25;
            this.rb5to9.TabStop = true;
            this.rb5to9.Text = "От 5 до 9 лет";
            this.rb5to9.UseVisualStyleBackColor = true;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(15, 759);
            this.lblOther.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(171, 25);
            this.lblOther.TabIndex = 26;
            this.lblOther.Text = "Другие сведения";
            // 
            // chkCar
            // 
            this.chkCar.AutoSize = true;
            this.chkCar.Checked = true;
            this.chkCar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCar.Location = new System.Drawing.Point(33, 817);
            this.chkCar.Margin = new System.Windows.Forms.Padding(6);
            this.chkCar.Name = "chkCar";
            this.chkCar.Size = new System.Drawing.Size(245, 29);
            this.chkCar.TabIndex = 27;
            this.chkCar.Text = "Наличие личного авто";
            this.chkCar.UseVisualStyleBackColor = true;
            // 
            // chkLicense
            // 
            this.chkLicense.AutoSize = true;
            this.chkLicense.Location = new System.Drawing.Point(37, 997);
            this.chkLicense.Margin = new System.Windows.Forms.Padding(6);
            this.chkLicense.Name = "chkLicense";
            this.chkLicense.Size = new System.Drawing.Size(317, 29);
            this.chkLicense.TabIndex = 28;
            this.chkLicense.Text = "Водительское удостоверение";
            this.chkLicense.UseVisualStyleBackColor = true;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(362, 821);
            this.lblCategories.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(156, 25);
            this.lblCategories.TabIndex = 29;
            this.lblCategories.Text = "Категория прав";
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Location = new System.Drawing.Point(367, 997);
            this.chkA.Margin = new System.Windows.Forms.Padding(6);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(52, 29);
            this.chkA.TabIndex = 30;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Location = new System.Drawing.Point(440, 997);
            this.chkB.Margin = new System.Windows.Forms.Padding(6);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(51, 29);
            this.chkB.TabIndex = 31;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(513, 997);
            this.chkC.Margin = new System.Windows.Forms.Padding(6);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(53, 29);
            this.chkC.TabIndex = 32;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkD
            // 
            this.chkD.AutoSize = true;
            this.chkD.Location = new System.Drawing.Point(587, 997);
            this.chkD.Margin = new System.Windows.Forms.Padding(6);
            this.chkD.Name = "chkD";
            this.chkD.Size = new System.Drawing.Size(52, 29);
            this.chkD.TabIndex = 33;
            this.chkD.Text = "D";
            this.chkD.UseVisualStyleBackColor = true;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(18, 1052);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(170, 25);
            this.lblSummary.TabIndex = 34;
            this.lblSummary.Text = "Краткое резюме";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(275, 1052);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(6);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(363, 89);
            this.txtSummary.TabIndex = 35;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(18, 1163);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(256, 25);
            this.lblSalary.TabIndex = 36;
            this.lblSalary.Text = "Объем заработной платы";
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(275, 1163);
            this.numSalary.Margin = new System.Windows.Forms.Padding(6);
            this.numSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSalary.Minimum = new decimal(new int[] {
            523,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(147, 29);
            this.numSalary.TabIndex = 37;
            this.numSalary.Value = new decimal(new int[] {
            523,
            0,
            0,
            0});
            // 
            // chkSalary700
            // 
            this.chkSalary700.AutoSize = true;
            this.chkSalary700.Location = new System.Drawing.Point(440, 1163);
            this.chkSalary700.Margin = new System.Windows.Forms.Padding(6);
            this.chkSalary700.Name = "chkSalary700";
            this.chkSalary700.Size = new System.Drawing.Size(104, 29);
            this.chkSalary700.TabIndex = 38;
            this.chkSalary700.Text = "До 700";
            this.chkSalary700.UseVisualStyleBackColor = true;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(18, 1218);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(327, 25);
            this.lblSchedule.TabIndex = 39;
            this.lblSchedule.Text = "Предпочитаемый график работы";
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(37, 1274);
            this.rbFull.Margin = new System.Windows.Forms.Padding(6);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(206, 29);
            this.rbFull.TabIndex = 40;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "полная занятость";
            this.rbFull.UseVisualStyleBackColor = true;
            // 
            // rbHome
            // 
            this.rbHome.AutoSize = true;
            this.rbHome.Location = new System.Drawing.Point(37, 1329);
            this.rbHome.Margin = new System.Windows.Forms.Padding(6);
            this.rbHome.Name = "rbHome";
            this.rbHome.Size = new System.Drawing.Size(182, 29);
            this.rbHome.TabIndex = 41;
            this.rbHome.TabStop = true;
            this.rbHome.Text = "работа на дому";
            this.rbHome.UseVisualStyleBackColor = true;
            // 
            // rbPart
            // 
            this.rbPart.AutoSize = true;
            this.rbPart.Location = new System.Drawing.Point(37, 1385);
            this.rbPart.Margin = new System.Windows.Forms.Padding(6);
            this.rbPart.Name = "rbPart";
            this.rbPart.Size = new System.Drawing.Size(237, 29);
            this.rbPart.TabIndex = 42;
            this.rbPart.TabStop = true;
            this.rbPart.Text = "частичная занятость";
            this.rbPart.UseVisualStyleBackColor = true;
            // 
            // rbShift
            // 
            this.rbShift.AutoSize = true;
            this.rbShift.Location = new System.Drawing.Point(37, 1440);
            this.rbShift.Margin = new System.Windows.Forms.Padding(6);
            this.rbShift.Name = "rbShift";
            this.rbShift.Size = new System.Drawing.Size(210, 29);
            this.rbShift.TabIndex = 43;
            this.rbShift.TabStop = true;
            this.rbShift.Text = "посменная работа";
            this.rbShift.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(37, 1514);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 55);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 1514);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 55);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 1514);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 55);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 1606);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbShift);
            this.Controls.Add(this.rbPart);
            this.Controls.Add(this.rbHome);
            this.Controls.Add(this.rbFull);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.chkSalary700);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.chkD);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.chkA);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.chkLicense);
            this.Controls.Add(this.chkCar);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.rb5to9);
            this.Controls.Add(this.rbLess1);
            this.Controls.Add(this.rb1to5);
            this.Controls.Add(this.rbNoExp);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtResidence);
            this.Controls.Add(this.lblResidence);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкетные данные сотрудника";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblResidence;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.RadioButton rbNoExp;
        private System.Windows.Forms.RadioButton rb1to5;
        private System.Windows.Forms.RadioButton rbLess1;
        private System.Windows.Forms.RadioButton rb5to9;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.CheckBox chkCar;
        private System.Windows.Forms.CheckBox chkLicense;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkD;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.CheckBox chkSalary700;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.RadioButton rbHome;
        private System.Windows.Forms.RadioButton rbPart;
        private System.Windows.Forms.RadioButton rbShift;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}