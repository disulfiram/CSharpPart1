using System;

class GraterOfThree
{
    static void Main()
    {
        Console.Title = "Grater of three numbers";
        int X;
        int Y;
        int Z;
        Console.WriteLine("Input three intigers:");
        while (true)
        {
            Console.Write("X = ");
            string Value = Console.ReadLine();
            bool xResult = int.TryParse(Value, out X);
            Console.Write("Y = ");
            Value = Console.ReadLine();
            bool yResult = int.TryParse(Value, out Y);
            Console.Write("Z = ");
            Value = Console.ReadLine();
            bool zResult = int.TryParse(Value, out Z);
            if ((xResult == true) && (yResult == true) && (zResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        if (X > Y)
        {
            if (X > Z)
            {
                Console.WriteLine("X = {0} is the gratest number of the three.", X);
            }
            else
            {
                Console.WriteLine("Z = {0} is the gratest number of the three.", Z);
            }
        }
        else
        {
            if (Y > Z)
            {
                Console.WriteLine("Y = {0} is the gratest number of the three.", Y);
            }
            else
            {
                Console.WriteLine("Z = {0} is the gratest number of the three.", Z);
            }
        }
    }
}