using System;

namespace Task4
{
    public partial class Form1 : Form
    {
        // ������� ������: ���� � �������
        System.Drawing.Bitmap sky, plane;

        Graphics g; // ������� ����������� �����������

        // ���������� ���������� X,
        // ���������� �������� ������
        int dx;

        // �������, � ������� ��������� �������
        Rectangle rct;

        // true - ������� ���������� � �������
        Boolean demo = true;

        // ��������� ��������� �����
        System.Random rnd;

        // ������
        private System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            try
            {
                // �������� ������� ������� �� ������
                sky = new Bitmap(@"D:\!!!!!!!��������\�����������_����30\������������ �����30\source\sky.png");	 // ����
                plane = new Bitmap(@"D:\!!!!!!!��������\�����������_����30\������������ �����30\source\Plane.txt"); // �������

                // ��������� � ������ ������� ������� �����
                this.BackgroundImage = new Bitmap(@"D:\!!!!!!!��������\�����������_����30\������������ �����30\source\sky.png");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(),
                    "�����",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close(); // ������� ����������
                return;
            }

            // ������� ���������� ��� ������ �������
            plane.MakeTransparent();

            // ������ ������ ����� � ������������
            // � �������� �������� �������
            this.ClientSize =
                new System.Drawing.Size(
                    new Point(BackgroundImage.Width,
                    BackgroundImage.Height));

            // ������ ��� ������� ����
            this.FormBorderStyle =
                 System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // g - ����������� �����������, �� �������
            // ����� ����������� �������.
            // � �������� �����������
            // ����� ������������ BackgroundImage �����
            g = Graphics.FromImage(BackgroundImage);

            // ������������� ���������� ����. �����
            rnd = new System.Random();

            // �������� ��������� ��������
            rct.X = -40;
            rct.Y = 20 + rnd.Next(20);

            rct.Width = plane.Width;
            rct.Height = plane.Height;

            /*
            �������� ������ ������������ �������� ����������
            �������� �� ������� (�������� �������� Timer1.Interval)
            � ��������� ���������� ���������� �� X
            */

            dx = 2;     // �������� ������ - 2 �������/���_�������

            timer2.Interval = 20;
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // ������� ����������� �������� ����� �����������
            // ������� ���� �� ������� �����������
            g.DrawImage(sky, new Point(0, 0));

            // �������� ��������� ��������
            if (rct.X < this.ClientRectangle.Width)
                rct.X += dx;
            else
            {
                // ���� �������� �������, ������ ������
                // ��������� ��������
                rct.X = -40;
                rct.Y = 20 +
                    rnd.Next(this.ClientSize.Height - 40 - plane.Height);

                // �������� ������ �� 2 �� 5 ��������/���_�������
                dx = 2 + rnd.Next(4);
            }

            // ������ ������� �� ������� �����������
            // (���������� �� ����������� �����),
            // �� ��� ����, ����� �������� ���������,
            // ���� ������������ ���������� �����
            g.DrawImage(plane, rct.X, rct.Y);


            /*
            ����� Refresh ���������� ����������� ���� �����
            ����� Invalidate ��������� ����������� �����������
            ������ ��� ������� �����, ������� �������
            � �������� ��������� ������.
            */

            if (!demo)
                // �������� ������� �����,
                // � ������� ��������� ������
                this.Invalidate(rct);
            else
            {
                // ���� ������ ��������� ��� �������,
                // ��������� � �������� ��������� ������
                // Invalidate, �� �� �� ����� �����

                Rectangle reg =
                new Rectangle(20, 20,
                      sky.Width - 40, sky.Height - 40);

                // �������� ����������� �������
                g.DrawRectangle(Pens.Black,
                    reg.X, reg.Y, reg.Width - 1, reg.Height - 1);

                this.Invalidate(reg); // �������� �������
            }
        }
    }
}