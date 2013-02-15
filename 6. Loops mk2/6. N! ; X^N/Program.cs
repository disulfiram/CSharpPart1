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
        Console.Title = "N!/K^N";
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
            if ((ResultN == true) && (ResultK == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        double S = 1;
        double Numerator = 1;
        double Denominator = 1;
        for (int i = 1; i <= N; i++)
        {       
            Numerator *= i;
            Denominator = Math.Pow(K, i);
            S += Numerator / Denominator;
        }
        Console.WriteLine("N!/K^N = {0}", S);
    }
}

