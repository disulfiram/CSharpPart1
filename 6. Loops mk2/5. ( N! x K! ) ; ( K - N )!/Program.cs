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
            if ((ResultN == true) && (ResultK == true) && (K > 1) && (K > N))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        BigInteger Numerator = 1;
        for (int i = 1; i <= N; i++)
        {
            Numerator *= i;
        }
        for (int i = 1; i <= K; i++)
        {
            Numerator *= i;
        }
        BigInteger Denominator = 1;
        for (int i = 1; i <= (K - N); i++)
        {
            Denominator *= i;
        }
        Console.WriteLine("(N!*K!)/(K-N)! = {0}", Numerator/Denominator);
    }
}

