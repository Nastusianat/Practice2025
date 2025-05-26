using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите пол (м - мужчина, ж - женщина): ");
        char gender = char.ToLower(Console.ReadKey().KeyChar); //позволяет считать один символ с клавиатуры
        Console.WriteLine(); 

        switch (gender)
        {
            case 'м':
                Console.WriteLine("Возможные мужские имена: Иван, Алексей, Дмитрий, Сергей, Николай.");
                break;
            case 'ж':
                Console.WriteLine("Возможные женские имена: Анна, Ольга, Екатерина, Мария, Татьяна.");
                break;
            default:
                Console.WriteLine("Ошибка: Введите 'м' или 'ж'.");
                break;
        }
    }
}
