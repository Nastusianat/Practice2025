using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        private const string ConnStr = "Data Source=D:\\!!!!!!!��������\\�����������_����31\\������������ �����31\\DBTur_firm.sqlite";
        private readonly DataSet dataSet = new DataSet();
        private readonly DataTable tours = new DataTable("����"), tourists = new DataTable("�������");

        public Form1()
        {
            InitializeComponent();
            InitDataTables();
            InitControls();
        }

        private void InitDataTables()
        {
            tours.Columns.AddRange(new[] {
                new DataColumn("���_����", typeof(int)),
                new DataColumn("��������", typeof(string)),
                new DataColumn("����_������", typeof(DateTime)),
                new DataColumn("����_���������", typeof(DateTime)),
                new DataColumn("����", typeof(decimal))
            });
            tourists.Columns.AddRange(new[] {
                new DataColumn("���_�������", typeof(int)),
                new DataColumn("�������", typeof(string)),
                new DataColumn("���", typeof(string)),
                new DataColumn("��������", typeof(string)),
                new DataColumn("���_����", typeof(int))
            });

            tours.PrimaryKey = new[] { tours.Columns["���_����"] };
            tourists.PrimaryKey = new[] { tourists.Columns["���_�������"] };

            dataSet.Tables.AddRange(new[] { tours, tourists });
        }

        private void InitControls()
        {
            var dgvTours = new DataGridView { Left = 200, Top = 10, Width = 620, Height = 300, DataSource = tours };
            var dgvTourists = new DataGridView { Left = 200, Top = 320, Width = 620, Height = 150, DataSource = tourists };

            string[] btnTexts = { "��������� ����", "������� ���", "�������� �������",
                                "�������� �������", "��������� ��������", "������� �������", "��������� ���������" };
            int[] tops = { 10, 50, 90, 130, 370, 410, 450 };

            for (int i = 0; i < btnTexts.Length; i++)
            {
                var btn = new Button { Text = btnTexts[i], Left = 10, Top = tops[i], Width = 170, Height = 30 };
                btn.Click += (s, e) => HandleButtonClick(btn.Text);
                Controls.Add(btn);
            }

            string[] placeholders = { "������� id ����", "������� �������", "������� ���",
                                    "������� ��������", "������� id �������" };
            int[] textBoxTops = { 170, 210, 250, 290, 330 };

            for (int i = 0; i < placeholders.Length; i++)
            {
                var tb = new TextBox { Text = placeholders[i], Left = 10, Top = textBoxTops[i], Width = 170, Height = 30 };
                tb.GotFocus += (s, e) => { if (tb.Text == placeholders[i]) tb.Text = ""; };
                tb.LostFocus += (s, e) => { if (string.IsNullOrEmpty(tb.Text)) tb.Text = placeholders[i]; };
                Controls.Add(tb);
            }

            Controls.AddRange(new Control[] { dgvTours, dgvTourists });
        }

        private void HandleButtonClick(string action)
        {
            var tbs = Controls.OfType<TextBox>().ToArray();
            try
            {
                using (var conn = new SQLiteConnection(ConnStr))
                {
                    conn.Open();
                    switch (action)
                    {
                        case "��������� ����":
                            new SQLiteDataAdapter("SELECT * FROM ����", conn).Fill(tours);
                            break;
                        case "��������� ��������":
                            new SQLiteDataAdapter("SELECT * FROM �������", conn).Fill(tourists);
                            break;
                        case "������� ���":
                            if (int.TryParse(tbs[0].Text, out int tourId))
                                new SQLiteCommand("DELETE FROM ���� WHERE ���_���� = @id", conn)
                                    .AddParam("@id", tourId).ExecuteNonQuery();
                            break;
                        case "������� �������":
                            if (int.TryParse(tbs[4].Text, out int touristId))
                                new SQLiteCommand("DELETE FROM ������� WHERE ���_������� = @id", conn)
                                    .AddParam("@id", touristId).ExecuteNonQuery();
                            break;
                        case "�������� �������":
                            if (int.TryParse(tbs[0].Text, out int tId))
                                new SQLiteCommand("INSERT INTO ������� (�������, ���, ��������, ���_����) VALUES (@l,@f,@m,@t)", conn)
                                    .AddParams(tbs[1].Text, tbs[2].Text, tbs[3].Text, tId).ExecuteNonQuery();
                            break;
                        case "�������� �������":
                            if (int.TryParse(tbs[4].Text, out int tid) && int.TryParse(tbs[0].Text, out int ttid))
                                new SQLiteCommand("UPDATE ������� SET �������=@l,���=@f,��������=@m,���_����=@t WHERE ���_�������=@id", conn)
                                    .AddParams(tbs[1].Text, tbs[2].Text, tbs[3].Text, ttid).AddParam("@id", tid).ExecuteNonQuery();
                            break;
                        case "��������� ���������":
                            new SQLiteDataAdapter("SELECT * FROM ����", conn).Update(tours);
                            new SQLiteDataAdapter("SELECT * FROM �������", conn).Update(tourists);
                            MessageBox.Show("������ ���������!");
                            break;
                    }
                }
                if (action.StartsWith("�������") || action.StartsWith("��������") || action.StartsWith("��������"))
                    HandleButtonClick(action.Contains("���") ? "��������� ����" : "��������� ��������");
            }
            catch (Exception ex) { MessageBox.Show($"������: {ex.Message}"); }
        }
    }

    static class Extensions
    {
        public static SQLiteCommand AddParam(this SQLiteCommand cmd, string name, object value)
        {
            cmd.Parameters.AddWithValue(name, value);
            return cmd;
        }

        public static SQLiteCommand AddParams(this SQLiteCommand cmd, params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
                cmd.Parameters.AddWithValue($"@{Convert.ToChar(108 + i)}", values[i]);
            return cmd;
        }
    }
}