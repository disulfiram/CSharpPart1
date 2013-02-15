using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Title = "The Nth Catalan number";
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
        BigInteger numerator = 1;
        for (int i = (N + 1); i <= (2 * N); i++)
        {
            numerator *= i;
        }
        BigInteger denominator= 1;
        for (int i = 1; i <= (N +1); i++)
        {
            denominator *= i;
        }
        BigInteger CN = numerator / denominator;
        Console.WriteLine("The Nth Catalan Numer is : {0}", CN);
    }
}