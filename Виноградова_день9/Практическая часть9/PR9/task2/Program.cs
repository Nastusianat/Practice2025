using System;

enum Post
{
    Manager = 160,
    Developer = 170,
    Designer = 150,
    Tester = 160,
    Analyst = 165
}

class Accountant
{
    public bool AskForBonus(Post worker, int hours)
    {
        return hours > (int)worker;
    }
}

class Program
{
    static void Main()
    {
        Accountant accountant = new Accountant();

        Console.WriteLine("Введите должность сотрудника (Manager, Developer, Designer, Tester, Analyst):");
        string postInput = Console.ReadLine();
        Post worker = (Post)Enum.Parse(typeof(Post), postInput, true);

        Console.WriteLine("Введите количество отработанных часов:");
        int hours = int.Parse(Console.ReadLine());

        bool bonus = accountant.AskForBonus(worker, hours);

        if (bonus)
        {
            Console.WriteLine("Сотруднику положена премия.");
        }
        else
        {
            Console.WriteLine("Сотруднику не положена премия.");
        }
    }
}
