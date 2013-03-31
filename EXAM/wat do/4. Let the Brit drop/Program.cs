using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LetTheBritDrop
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N / 2; i++)
        {
            for (int j = 1; j < N-1; j++)
            {
                if (i == j)
                {
                    Console.Write("\\");
                }
                if (j == N / 2)
                {
                    Console.Write("|");
                }
                if (j == N - i-1)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(".");
                }
                
            }
            Console.WriteLine();
        }
        
        for (int i = 1; i <= N / 2; i++)
        {
            Console.Write("-");
        }
        Console.Write("*");
        for (int i = 1; i <= N / 2; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
       
        for (int i = (N/2)+2 ; i <= N ; i++)
        {
            
            for (int j = 1; j < N-1; j++)
            {
                if (j == N - i + 1)
                {
                    Console.Write("/");
                }
                
                if (j == (N / 2))
                {
                    Console.Write("|");
                }
                if (j == i-2)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

    }
}