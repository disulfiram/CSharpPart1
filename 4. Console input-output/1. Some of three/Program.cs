using System;

class Sum3Int
{
    static void Main()
    {
        Console.Title = "Sum";
        Console.WriteLine("Input three intigers: ");
        int Number1;
        int Number2;
        int Number3;
        string Value = Console.ReadLine();
        int.TryParse(Value, out Number1);
        Value = Console.ReadLine();
        int.TryParse(Value, out Number2);
        Value = Console.ReadLine();
        int.TryParse(Value, out Number3);
        Console.WriteLine("The sum of {0}, {1} & {2} is: {3}",Number1,Number2,Number3,Number1+Number2+Number3);
    }
}

