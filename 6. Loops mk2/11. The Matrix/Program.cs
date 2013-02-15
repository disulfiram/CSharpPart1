using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Matrix
{
    static void Main()
    {
        Console.Title = "Matrix NxN";
        int N;
        while (true)
        {
            Console.Write("N = ");
            string Value = Console.ReadLine();
            bool ResultN = int.TryParse(Value, out N);
            if (ResultN == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        for (int j = 0; j < N; j++)
        {
            for (int i = 1; i <= N; i++)
            {
                if (i-j > 0)
                {
                    Console.Write("{0,3}", i - j);
                }
                else
                {
                    Console.Write("{0,3}", Math.Abs(j-i+2));
                }
            }
            Console.WriteLine();
        }
        
    }
}