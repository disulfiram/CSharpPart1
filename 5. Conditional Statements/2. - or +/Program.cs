using System;

class Sign
{
    static void Main()
    {
        Console.Title = "Sign of product";
        double X;
        double Y;
        double Z;
        while (true)
        {
            Console.Write("Input X: ");
            string Value = Console.ReadLine();
            bool xResult = double.TryParse(Value, out X);
            Console.Write("Input Y: ");
            Value = Console.ReadLine();
            bool yResult = double.TryParse(Value, out Y);
            Console.Write("Input Z: ");
            Value = Console.ReadLine();
            bool zResult = double.TryParse(Value, out Z);
            if ((xResult == true) && (yResult == true) && (zResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        if (X == 0 || Y == 0 || Z == 0)
        {
            Console.WriteLine("Product is 0");
        }
        else
        {
            if ((X > 0 && Y > 0 && Z > 0) || (X < 0 && Y < 0 && Z > 0) || (X > 0 && Y < 0 && Z < 0) || (X < 0 && Y > 0 && Z < 0))
            {
                Console.WriteLine("Sign is '+'");
            }
            else
            {
                Console.WriteLine("Sign is '-'");
            }
        }
    }
}

