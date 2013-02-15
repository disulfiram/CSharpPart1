using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintNumbers
{
    static void Main()
    {
        Console.Title = "Print the numbers from 1 to N";
        int N = 0;
        while (true)
        {
            Console.Write("Input N: ");
            string Value = Console.ReadLine();
            bool Result = int.TryParse(Value, out N);
            if (Result == true)
            {
                break;
            }
        }
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}

