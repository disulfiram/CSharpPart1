using System;

class UserInput
{
    static void Main(string[] args)
    {
        Console.Title = "User input";
        Console.WriteLine("Type: I for integer; D for double; S for string");
        string I = "i";
        string D = "d";
        string S = "S";
        string Choice;
        while (true)
        {
            Choice = Console.ReadLine();
            if ((Choice == I) || (Choice == D) || (Choice == S))
            {
                break;
            }
            else
            {
                Console.WriteLine("I, D or S");
            }
        }
        int Digit = 2;
        string DigitString = System.Convert.ToString(Digit);
        switch (Choice)
        {
            case "i":
                int Int;
                while (true)
                {
                    Console.Write("Input integer: ");
                    string Value = Console.ReadLine();
                    bool IntResult = int.TryParse(Value, out Int);
                    if (IntResult == true)
                    {
                        Console.WriteLine(Int);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid numbers. Try again:");
                    }
                }
                break;
            case "d":
                double Double;
                while (true)
                {
                    Console.Write("Input double: ");
                    string Value = Console.ReadLine();
                    bool DoubleResult = double.TryParse(Value, out Double);
                    if (DoubleResult == true)
                    {
                        Console.WriteLine(Double);
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
                string String = Console.ReadLine();
                Console.WriteLine(String);
                break;
        }
    }
}

