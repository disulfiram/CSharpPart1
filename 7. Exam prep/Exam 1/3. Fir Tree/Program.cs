using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i < N; i++)
        {
            for (int j = 1; j < (N-(i)); j++)
            {
                Console.Write(".");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j <= i-1; j++)
            {
                Console.Write("*");
            }
            for (int j = 1; j < (N-(i)); j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = 1; i <= N-2; i++)
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int i = 1; i <= N-2; i++)
        {
            Console.Write(".");
        }
    }
}

