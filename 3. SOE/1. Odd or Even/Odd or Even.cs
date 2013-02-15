using System;

class CheckIfOddOrEven
{
    static void Main()
    {
        Console.Title = "Odd or Even";
        Console.Write("Input an integer number to check if Odd or Even: ");
        int InputInt = int.Parse(Console.ReadLine());
        if (InputInt % 2 == 0)
        {
            Console.WriteLine("{0} is Even", InputInt);
        }
        else
        {
            Console.WriteLine("{0} is Odd", InputInt);
        }
    }
}