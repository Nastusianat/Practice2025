using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();
        string pattern = @"<html>|<form>|<h1>";

        if (Regex.IsMatch(text, pattern))
        {
            Console.WriteLine("Текст содержит HTML теги <html>, <form> или <h1>.");
        }
        else
        {
            Console.WriteLine("Текст не содержит HTML теги <html>, <form> или <h1>.");
        }
    }
}
