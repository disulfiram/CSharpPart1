using System;

class GratestOfFive
{
    static void Main()
    {
        Console.Title = "Greatest of five numbers";
        int first;
        int second;
        int third;
        int forth;
        int fifth;
        Console.WriteLine("Input three intigers:");
        while (true)
        {
            Console.Write("1: ");
            string value = Console.ReadLine();
            bool result1 = int.TryParse(value, out first);
            Console.Write("2: ");
            value = Console.ReadLine();
            bool result2 = int.TryParse(value, out second);
            Console.Write("3: ");
            value = Console.ReadLine();
            bool result3 = int.TryParse(value, out third);
            Console.Write("4: ");
            value = Console.ReadLine();
            bool result4 = int.TryParse(value, out forth);
            Console.Write("5: ");
            value = Console.ReadLine();
            bool result5 = int.TryParse(value, out fifth);
            if ((result1 == true) && (result2 == true) && (result3 == true) && (result4 == true) && (result5 == true))
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
            if (fifth > forth)
            {
                int temp = forth;
                forth = fifth;
                fifth = temp;
            }
            if (forth > third)
            {
                int temp = third;
                third = forth;
                forth = temp;
            }
            if (third > second)
            {
                int temp = second;
                second = third;
                third = temp;
            }
            if (second > first)
            {
                int temp = first;
                first = second;
                second = temp;
            }
        }
        Console.WriteLine(first);
    }
}

