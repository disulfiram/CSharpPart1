using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Title = "Area of trapezoid";
        Console.Write("Input a: ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("Inbut b: ");
        uint b = uint.Parse(Console.ReadLine());
        Console.Write("Input h: ");
        uint h = uint.Parse(Console.ReadLine());
        uint Area = (((a + b) / 2) * h);
        Console.WriteLine("Area of trapezoid: {0}", Area);
    }
}

