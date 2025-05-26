using System;

namespace ConsoleApp
{
    class A
    {
        private int a;
        private int b;

        public int C => a + b;

        public A()
        {
            a = 5;
            b = 10;
        }

        public void Display()
        {
            Console.WriteLine($"Класс A: a = {a}, b = {b}, C = {C}");
        }
    }

    class B : A
    {
        private int d;

        public int C2
        {
            get
            {
                int result = 0;
                int counter = d;
                do
                {
                    result += counter;
                    counter--;
                } while (counter > 0);

                return C + result;
            }
        }

        public B(int d)
        {
            this.d = d;
        }

        public B() : base()
        {
            d = 15; 
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine($"Класс B: d = {d}, C2 = {C2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A aObject = new A();
            aObject.Display();
            Console.WriteLine();

            B bObject1 = new B(10);
            bObject1.Display();
            Console.WriteLine();

            B bObject2 = new B();
            bObject2.Display();
        }
    }
}

