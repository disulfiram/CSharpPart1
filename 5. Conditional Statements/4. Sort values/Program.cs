using System;

class SortValues
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
            if (y > z)
            {
                Console.WriteLine("{0}, {1}, {2}", x, y, z);
            }
            else
            {
                if (x > z)
	            {
		            Console.WriteLine("{0}, {2}, {1}", x, y, z);
	            }
                else
	            {
                    Console.WriteLine("{2}, {0}, {1}", x, y, z);
	            }
            }
        }
        else
        {
            if (x > z)
            {
                Console.WriteLine("{1}, {0}, {2}", x, y, z);
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine("{1}, {2}, {0}", x, y, z);
                }
                else
                {
                    Console.WriteLine("{2}, {1}, {0}", x, y, z);
                }
            }
        }
    }
}

