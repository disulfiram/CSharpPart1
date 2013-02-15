using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;
using System.Globalization; 

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        decimal N = decimal.Parse(Console.ReadLine());
        BigInteger BigN = 0;
        for (int i = 307; i > 1; i++)
        {
            BigN = N * 10;
        }
        int result = N.ToString().Sum(c => c - '0');
        Console.WriteLine(result);
    }
}