using System;

namespace GameLibrary
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; private set; }
        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Score = 0;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public void EarnPoints(int points)
        {
            Score += points;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Игрок: {Name} | Здоровье: {Health} | Очки: {Score}");
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public void UseItem(Player player)
        {
            Console.WriteLine($"{player.Name} использует {Name} и получает {Value} очков!");
            player.EarnPoints(Value);
        }
    }
}
