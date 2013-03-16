using System;

class Sign
{
    static void Main()
    {
        Console.Title = "Sign of product";
        double x;
        double y;
        double z;
        while (true)
        {
            Console.Write("Input X: ");
            string value = Console.ReadLine();
            bool xResult = double.TryParse(value, out x);
            Console.Write("Input Y: ");
            value = Console.ReadLine();
            bool yResult = double.TryParse(value, out y);
            Console.Write("Input Z: ");
            value = Console.ReadLine();
            bool zResult = double.TryParse(value, out z);
            if ((xResult == true) && (yResult == true) && (zResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        if (x == 0 || y == 0 || z == 0)
        {
            Console.WriteLine("Product is 0");
        }
        else
        {
            if ((x > 0 && y > 0 && z > 0) || (x < 0 && y < 0 && z > 0) || (x > 0 && y < 0 && z < 0) || (x < 0 && y > 0 && z < 0))
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

