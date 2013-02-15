using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Title = "Read N numbers and print min and max";
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
        int[] Integer = new int[N];
        for (int i = 1; i < N; i++)
        {
            while (true)
            {
                string[] Values = new string[N];
                Values[i] = Console.ReadLine();
                bool IntResult = int.TryParse(Values[i], out Integer[i]);
                if (IntResult == true)
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid integer.");
                }
            }
        }
        int Min = Integer[0];
        int Max = Integer[0];
        for (int i = 0; i < N; i++)
        {
            if (Min < Integer[i])
            {
                Min = Integer[i];
            }
            if (Max < Integer[i])
            {
                Max = Integer[i];
            }
        }
        Console.WriteLine("Greatest number is: {0}. Smallest number is: {1}", Max, Min);
    }
}

