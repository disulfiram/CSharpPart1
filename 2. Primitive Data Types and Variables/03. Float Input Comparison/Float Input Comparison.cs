//Write a program that safely compares floating-point numbers with 
//precision of 0.000001. Examples:
//(5.3 ; 6.01)  false;  
//(5.00000001 ; 5.00000003)  true

using System;

class FloatInputComparison
{
    static void Main()
    {
        Console.Title = "Compare Numbers";
        Console.Write("Input first number:");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Input second number:");
        float secondNumber = float.Parse(Console.ReadLine());
        bool compare = (firstNumber == secondNumber);
        Console.Write("Result is: ");
        Console.WriteLine(compare);
    }
}