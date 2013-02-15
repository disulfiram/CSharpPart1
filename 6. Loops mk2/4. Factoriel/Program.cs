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
        Console.Title = "N!/K!";
        int N;
        int K;
        while (true)
        {
            Console.Write("N = ");
            string Value = Console.ReadLine();
            bool ResultN = int.TryParse(Value, out N);
            Console.Write("K = ");
            Value = Console.ReadLine();
            bool ResultK = int.TryParse(Value, out K);
            if ((ResultN == true) && (ResultK == true) && (K > 1) && (N > K))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        BigInteger Fac = 1;
        for (int i = K+1; i <= N; i++)
        {
            Fac *= i;
        }
        Console.WriteLine("N!/K! = {0}", Fac);
    }
}

