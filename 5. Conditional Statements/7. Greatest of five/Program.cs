using System;

class GratestOfFive
{
    static void Main()
    {
        Console.Title = "Greatest of five numbers";
        int First;
        int Second;
        int Third;
        int Forth;
        int Fifth;
        Console.WriteLine("Input three intigers:");
        while (true)
        {
            Console.Write("1: ");
            string Value = Console.ReadLine();
            bool Result1 = int.TryParse(Value, out First);
            Console.Write("2: ");
            Value = Console.ReadLine();
            bool Result2 = int.TryParse(Value, out Second);
            Console.Write("3: ");
            Value = Console.ReadLine();
            bool Result3 = int.TryParse(Value, out Third);
            Console.Write("4: ");
            Value = Console.ReadLine();
            bool Result4 = int.TryParse(Value, out Forth);
            Console.Write("5: ");
            Value = Console.ReadLine();
            bool Result5 = int.TryParse(Value, out Fifth);
            if ((Result1 == true) && (Result2 == true) && (Result3 == true) && (Result4 == true) && (Result5 == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (Fifth > Forth)
            {
                int temp = Forth;
                Forth = Fifth;
                Fifth = temp;
            }
            if (Forth > Third)
            {
                int temp = Third;
                Third = Forth;
                Forth = temp;
            }
            if (Third > Second)
            {
                int temp = Second;
                Second = Third;
                Third = temp;
            }
            if (Second > First)
            {
                int temp = First;
                First = Second;
                Second = temp;
            }
        }
        Console.WriteLine(First);
    }
}

