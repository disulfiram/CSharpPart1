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
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < N-(i+1); j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        for (int i = N-1; i > 0; i--)
        {
            for (int j = 0; j < i-1; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < N - (i); j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

