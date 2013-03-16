using System;

class ExchangeGrater
{
    static void Main()
    {
        Console.Title = "Exchange two intigers";
        int x;
        int y;
        Console.WriteLine("Input two intigers:");
        while (true)
        {
            Console.Write("Input X: ");
            string value = Console.ReadLine();
            bool xResult = int.TryParse(value, out x);
            Console.Write("Input Y: ");
            value = Console.ReadLine();
            bool yResult = int.TryParse(value, out y);
            if ((xResult == true) && (yResult == true))
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
            int temp;
            temp = y;
            y = x;
            x = temp;
        }
        Console.WriteLine("X = {0} & Y = {1}", x, y);
    }
}

