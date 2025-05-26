using System;

namespace FieldExample
{
    class Field
    {
        private string name;
        private double seedWeight; 

        public Field(string name, double seedWeight)
        {
            this.name = name;
            this.seedWeight = seedWeight;
        }

        public string GetName() => name;
        public double GetSeedWeight() => seedWeight;

        public void DisplayFields()
        {
            Console.WriteLine($"Название: {name}, Вес семян на единицу площади: {seedWeight}");
        }

        public double HarvestYield(double k)
        {
            return k * seedWeight;
        }
    }

    class PotatoField : Field
    {
        private double area; 

        public PotatoField(string name, double seedWeight, double area)
            : base(name, seedWeight)
        {
            this.area = area;
        }

        public double GetArea() => area;

        public new void DisplayFields()
        {
            base.DisplayFields();
            Console.WriteLine($"Площадь поля: {area}");
        }

        public double TotalHarvestYield(double k)
        {
            return HarvestYield(k) * area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field("Овсяное поле", 2.5);
            field.DisplayFields();
            Console.WriteLine($"Урожай с единицы площади: {field.HarvestYield(1.2)}\n");

            PotatoField potatoField = new PotatoField("Картофельное поле", 3.0, 10.0);
            potatoField.DisplayFields();
            Console.WriteLine($"Урожай со всего поля: {potatoField.TotalHarvestYield(1.2)}");

            Console.WriteLine("\nПроверка завершена!");
        }
    }
}

