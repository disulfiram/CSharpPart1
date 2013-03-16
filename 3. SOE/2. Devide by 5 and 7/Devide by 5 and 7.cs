using System;

class DivideBy5abd7
{
    static void Main()
    {
        Console.Title = "Devide by 5 and 7 at the same time.";
        Console.Write("Input an integer: ");
        int inputInt = int.Parse(Console.ReadLine());
        bool check5 = (inputInt % 5 == 0);
        bool check7 = (inputInt % 7 == 0);
        if (check5 == true && check7 == true)
        {
            Console.WriteLine("{0} can be devided by 5 and 7 at the same time.", inputInt);
        }
        else
        {
            Console.WriteLine("{0} cannot be devided by 5 and 7 at the same time.", inputInt);
        }
    }
}

