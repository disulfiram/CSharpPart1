﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < (N/2)+1; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(".");
            }
            for (int j = 0; j <= ((N/2)-1)-(i-1); j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j <= ((N / 2) - 1) - (i); j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = (N/2)-1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(".");
            }
            for (int j = 0; j < ((N / 2) - 1) - (i-2); j++)
            {
                Console.Write("*");
            }
            for (int j = 0; j < ((N / 2) - 1) - (i-1); j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}