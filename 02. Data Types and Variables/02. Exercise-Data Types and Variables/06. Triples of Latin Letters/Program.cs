﻿// See https://aka.ms/new-console-template for more information
int number=int.Parse(Console.ReadLine());
for(int i=0; i<number;i++)
{
    for (int j = 0; j < number; j++)
    {
        for (int k = 0; k < number; k++)
        {
            char first = (char)('a' + i);
            char second = (char)('a' + j);
            char third = (char)('a' + k);
            Console.WriteLine($"{first}{second}{third}");
        }
    }

}