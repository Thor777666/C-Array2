﻿int[,] table = new int[3, 5];

Random rnd = new Random();

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        table[i, j] = rnd.Next(0, 11);
    }
}

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write(table[i, j] + " ");
    }
    Console.WriteLine();
}