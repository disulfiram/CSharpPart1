using System;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        Console.Title = "Prime or not?";
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        for (int divisor = 2; divisor < number; divisor++)
        {
            if (number != divisor && number % divisor == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            Console.WriteLine("{0} is prime", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime", number);
        }
    }
}