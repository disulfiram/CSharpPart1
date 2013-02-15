using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        Console.Title = "First N members of the Fibonacci sequence.";
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
        BigInteger fib1 = 0;
        BigInteger fib2 = 1;
        BigInteger fib3 = 0;
        BigInteger Sum = 1;
        Console.WriteLine("0   - {0}", fib1);
        Console.WriteLine("1   - {0}", fib2);
        for (int i = 0; i < N-1; i++)
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
            Console.WriteLine("{0, -3} - {1}", (i + 2), fib3);
            Sum += fib3;
        }
        Console.WriteLine("{0} is the sum",Sum);
    }
}