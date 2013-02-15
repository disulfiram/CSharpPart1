using System;

class NumBetweenXandY
{
    static void Main()
    {
        Console.Title = "Numbers between X and Y that are devided by 5.";
        int X;
        int Y;
        Console.WriteLine("Input two positive intigers. First one should be smaller than second:");
        while (true)
        {
            string Value = Console.ReadLine();
            bool xResult = int.TryParse(Value, out X);
            Value = Console.ReadLine();
            bool yResult = int.TryParse(Value, out Y);
            if ((xResult == true) && (yResult == true) && (X < Y))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        int sum = 0;
        for (int i = X; i <= Y; i++)
        {
            if (i % 5 == 0)
            {
                sum = sum + 1;
            }
        }
        Console.WriteLine("{0} numbers between {1} and {2} can be devided by 5", sum, X, Y);
    }
}

