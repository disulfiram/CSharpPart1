using System;
using System.Linq;

class Check3rdDigit
{
    static void Main()
    {
        Console.Title = "Check if third digit is 7";
        Console.Write("Input number: ");
        int randomNumber = int.Parse(Console.ReadLine());
        randomNumber = randomNumber / 100;
        Console.WriteLine(randomNumber % 10 == 7);
    }
}

