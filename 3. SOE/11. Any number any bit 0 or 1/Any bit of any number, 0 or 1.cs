using System;

class Program
{
    static void Main()
    {
        Console.Title = "Any bit, any number.";
        Console.Write("Which bit should be checked if 0? ");
        int BitPosition = int.Parse(Console.ReadLine());
        Console.Write("Input Number: ");
        int InputNumber = int.Parse(Console.ReadLine());
        int mask = 1 << BitPosition;
        int NumberAndMask = InputNumber & mask;
        int bit = NumberAndMask >> BitPosition;
        Console.WriteLine("Bit {0} of the number {1} is: {2}", BitPosition, InputNumber, bit);
    }
}

