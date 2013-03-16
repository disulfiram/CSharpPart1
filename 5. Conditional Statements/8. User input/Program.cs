using System;

class UserInput
{
    static void Main(string[] args)
    {
        Console.Title = "User input";
        Console.WriteLine("Type: I for integer; D for double; S for string");
        string i = "i";
        string d = "d";
        string s = "S";
        string choice;
        while (true)
        {
            choice = Console.ReadLine();
            if ((choice.ToLower() == i) || (choice.ToLower() == d) || (choice.ToLower() == s))
            {
                break;
            }
            else
            {
                Console.WriteLine("I, D or S");
            }
        }
        int digit = 2;
        string digitString = System.Convert.ToString(digit);
        switch (choice)
        {
            case "i":
                int @int;
                while (true)
                {
                    Console.Write("Input integer: ");
                    string value = Console.ReadLine();
                    bool intResult = int.TryParse(value, out @int);
                    if (intResult == true)
                    {
                        Console.WriteLine(@int);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid numbers. Try again:");
                    }
                }
                break;
            case "d":
                double @double;
                while (true)
                {
                    Console.Write("Input double: ");
                    string value = Console.ReadLine();
                    bool doubleResult = double.TryParse(value, out @double);
                    if (doubleResult == true)
                    {
                        Console.WriteLine(@double);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid numbers. Try again:");
                    }
                }
                break;
            case "s":
                Console.Write("Write a string: ");
                string @string = Console.ReadLine();
                Console.WriteLine(@string);
                break;
        }
    }
}

