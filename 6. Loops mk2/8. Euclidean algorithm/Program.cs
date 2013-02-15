using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Title = "Eucledean algorithm";
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
        if (N < K)
        {
            int temp = N;
            N = K;
            K = temp;
        }
        int Remainder;
        while (K != 0)
        {
            Remainder = N % K;
            N = K;
            K = Remainder;
        }
        Console.WriteLine("The GCD is: {0}", N);
    }
}