using System;

class RecArea
{
    static void Main()
    {
        Console.Title = "Area of Rectangle";
        Console.Write("Height = ");
        uint height = uint.Parse(Console.ReadLine());
        Console.Write("Width = ");
        uint width = uint.Parse(Console.ReadLine());
        uint area = height * width;
        Console.WriteLine("Area of the rectangle is: {0}", area);
    }
}

