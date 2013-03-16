using System;

class CheckIfOddOrEven
{
    static void Main()
    {
        Console.Title = "Odd or Even";
        Console.Write("Input an integer number to check if Odd or Even: ");
        int inputInt = int.Parse(Console.ReadLine());
        if (inputInt % 2 == 0)
        {
            Console.WriteLine("{0} is Even", inputInt);
        }
        else
        {
            Console.WriteLine("{0} is Odd", inputInt);
        }
    }
}