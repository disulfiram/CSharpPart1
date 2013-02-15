using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrimeNumbers
{
    static void Main()
    {
        Console.Title = "Prime or not?";
        Console.Write("Enter number: ");
        int i = int.Parse(Console.ReadLine());
        int j;
        bool isPrime = true;
        for (j = 2; j < i; j++)
        {
            if (i != j && i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
	    {
            Console.WriteLine("{0} is prime", i);
	    }
        else
        {
            Console.WriteLine("{0} is not prime", i);
        }
    }
}

