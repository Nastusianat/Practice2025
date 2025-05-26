using System;

namespace EventExample
{
    public class MyInfo
    {
        private string name;

        public event EventHandler NameChanged;

        public string Name
        {
            get => name;
            set
            {
                if (name != value) 
                {
                    name = value;
                    OnNameChanged(); 
                }
            }
        }

        protected virtual void OnNameChanged()
        {
            if (NameChanged != null)
            {
                NameChanged(this, EventArgs.Empty);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyInfo myInfo = new MyInfo();

            myInfo.NameChanged += MyInfo_NameChanged;

            myInfo.Name = "Анастасия";
            myInfo.Name = "Екатерина"; 
        }

        private static void MyInfo_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Значение поля name было изменено!");
        }
    }
}

