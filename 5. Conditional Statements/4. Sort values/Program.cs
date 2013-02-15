using System;

class SortValues
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
            if (Y > Z)
            {
                Console.WriteLine("{0}, {1}, {2}", X, Y, Z);
            }
            else
            {
                if (X > Z)
	            {
		            Console.WriteLine("{0}, {2}, {1}", X, Y, Z);
	            }
                else
	            {
                    Console.WriteLine("{2}, {0}, {1}", X, Y, Z);
	            }
            }
        }
        else
        {
            if (X > Z)
            {
                Console.WriteLine("{1}, {0}, {2}", X, Y, Z);
            }
            else
            {
                if (Y > Z)
                {
                    Console.WriteLine("{1}, {2}, {0}", X, Y, Z);
                }
                else
                {
                    Console.WriteLine("{2}, {1}, {0}", X, Y, Z);
                }
            }
        }
    }
}

