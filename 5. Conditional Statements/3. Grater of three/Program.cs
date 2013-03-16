using System;

class GraterOfThree
{
    static void Main()
    {
        Console.Title = "Grater of three numbers";
        int x;
        int y;
        int z;
        Console.WriteLine("Input three intigers:");
        while (true)
        {
            Console.Write("X = ");
            string value = Console.ReadLine();
            bool xResult = int.TryParse(value, out x);
            Console.Write("Y = ");
            value = Console.ReadLine();
            bool yResult = int.TryParse(value, out y);
            Console.Write("Z = ");
            value = Console.ReadLine();
            bool zResult = int.TryParse(value, out z);
            if ((xResult == true) && (yResult == true) && (zResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("X = {0} is the gratest number of the three.", x);
            }
            else
            {
                Console.WriteLine("Z = {0} is the gratest number of the three.", z);
            }
        }
        else
        {
            if (y > z)
            {
                Console.WriteLine("Y = {0} is the gratest number of the three.", y);
            }
            else
            {
                Console.WriteLine("Z = {0} is the gratest number of the three.", z);
            }
        }
    }
}