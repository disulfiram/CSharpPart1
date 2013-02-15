using System;
using System.Linq;

class Check3rdDigit
{
    static void Main()
    {
        Console.Title = "Check if third digit is 7";
        Console.Write("Input number: ");
        int RandomNumber = int.Parse(Console.ReadLine());
        RandomNumber = RandomNumber / 100;
        Console.WriteLine(RandomNumber % 10 == 7);
    }
}

