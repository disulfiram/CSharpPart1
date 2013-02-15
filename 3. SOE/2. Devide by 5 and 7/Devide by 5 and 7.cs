using System;

class DivideBy5abd7
{
    static void Main()
    {
        Console.Title = "Devide by 5 and 7 at the same time.";
        Console.Write("Input an integer: ");
        int InputInt = int.Parse(Console.ReadLine());
        bool check5 = (InputInt % 5 == 0);
        bool check7 = (InputInt % 7 == 0);
        if (check5 == true && check7 == true)
        {
            Console.WriteLine("{0} can be devided by 5 and 7 at the same time.", InputInt);
        }
        else
        {
            Console.WriteLine("{0} cannot be devided by 5 and 7 at the same time.", InputInt);
        }
    }
}

