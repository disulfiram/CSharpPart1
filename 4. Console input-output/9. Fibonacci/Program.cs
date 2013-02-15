using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        Console.Title = "First 100 members of the Fibonacci sequence.";
        BigInteger fib1 = 0;
        BigInteger fib2 = 1;
        BigInteger fib3 = 0;
        Console.WriteLine("0   - {0}", fib1);
        Console.WriteLine("1   - {0}", fib2);
        for (int i = 0; i < 99; i++)
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;
            Console.WriteLine("{0, -3} - {1}", (i+2) , fib3);
        }
    }
}

