﻿using System;

class Program
{
    static void Main()
    {
        int rows = 23;
        int seatsPerRow = 40;
        int[,] hall = new int[rows, seatsPerRow];

        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < seatsPerRow; j++)
            {
                hall[i, j] = rand.Next(0, 2); 
            }
        }

        bool hasFreeSeats = false;
        for (int j = 0; j < seatsPerRow; j++)
        {
            if (hall[0, j] == 0) 
            {
                hasFreeSeats = true;
                break;
            }
        }

        if (hasFreeSeats)
            Console.WriteLine("В первом ряду есть свободные места.");
        else
            Console.WriteLine("Все места в первом ряду заняты.");
    }
}

