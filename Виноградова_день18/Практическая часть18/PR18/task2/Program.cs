using System;
using System.Numerics;
using GameLibrary;

class Program
{
    static void Main()
    {
        Player player = new Player("Анастасия");
        player.ShowStats();

        Console.WriteLine("\nИгрок получает урон...");
        player.TakeDamage(20);
        player.ShowStats();

        Console.WriteLine("\nИгрок находит предмет...");
        Item potion = new Item("Зелье здоровья", 50);
        potion.UseItem(player);
        player.ShowStats();
    }
}
