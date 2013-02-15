using System;

class ExchangeGrater
{
    static void Main()
    {
        Console.Title = "Exchange two intigers";
        int X;
        int Y;
        Console.WriteLine("Input two intigers:");
        while (true)
        {
            Console.Write("Input X: ");
            string Value = Console.ReadLine();
            bool xResult = int.TryParse(Value, out X);
            Console.Write("Input Y: ");
            Value = Console.ReadLine();
            bool yResult = int.TryParse(Value, out Y);
            if ((xResult == true) && (yResult == true))
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
            int temp;
            temp = Y;
            Y = X;
            X = temp;
        }
        Console.WriteLine("X = {0} & Y = {1}", X, Y);
    }
}

