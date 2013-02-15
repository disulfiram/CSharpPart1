using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
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
        BigInteger fac = 1;
        for (int i = 1; i <= N; i++)
        {
            fac *= i;
        }
        int Zero = N / 5;
        Console.WriteLine("N! = {0}, has {1} zeros", fac, Zero);
    }
}

