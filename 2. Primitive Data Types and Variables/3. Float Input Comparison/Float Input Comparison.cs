using System;

class FloatInputComparison
{
    static void Main()
    {
        Console.Title = "Compare Numbers";
        Console.Write("Input first number:");
        float FirstNumber = float.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        float SecondNumber = float.Parse(Console.ReadLine());
        bool compare = (FirstNumber == SecondNumber);
        Console.Write("Result is: ");
        Console.WriteLine(compare);
    }
}

