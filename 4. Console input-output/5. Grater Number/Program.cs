using System;

class GraterNumber
{
    static void Main()
    {
        Console.Title = "Grater of two numbers";
        int X;
        int Y;
        Console.WriteLine("Input two intigers:");
        while (true)
        {
            string Value = Console.ReadLine();
            bool xResult = int.TryParse(Value, out X);
            Value = Console.ReadLine();
            bool yResult = int.TryParse(Value, out Y);
            if ((xResult == true) && (yResult == true))     //I assumed I can use 'if' here
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        while (X > Y)
	    {
	         Y = X;
	    }
        Console.WriteLine("The grater number is {0}",Y);
    }
}

