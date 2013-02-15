using System;

class RecArea
{
    static void Main()
    {
        Console.Title = "Area of Rectangle";
        Console.Write("Height = ");
        uint Height = uint.Parse(Console.ReadLine());
        Console.Write("Width = ");
        uint Width = uint.Parse(Console.ReadLine());
        uint Area = Height * Width;
        Console.WriteLine("Area of the rectangle is: {0}", Area);
    }
}

