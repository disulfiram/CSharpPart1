using System;

class Program
{
    static void Main()
    {
        Console.Title = "Digit in words";
        byte Digit;
        while (true)
        {
            Console.Write("Digit (from 0 to 9): ");
            string Value = Console.ReadLine();
            bool DigitResult = byte.TryParse(Value, out Digit);
            if ((DigitResult == true) && (Digit >= 0) && (Digit <= 9))
            {
                break;
            }
            else
            {
                Console.WriteLine("From 0 to 9!");
            }
        }
        string DigitString = System.Convert.ToString(Digit);
        switch (DigitString)
        {
            case "0":
                Console.WriteLine("{0} - Zero", Digit);
                break;
            case "1":
                Console.WriteLine("{0} - One", Digit);
                break;
            case "2":
                Console.WriteLine("{0} - Two", Digit);
                break;
            case "3":
                Console.WriteLine("{0} - Three", Digit);
                break;
            case "4":
                Console.WriteLine("{0} - Four", Digit);
                break;
            case "5":
                Console.WriteLine("{0} - Five", Digit);
                break;
            case "6":
                Console.WriteLine("{0} - Six", Digit);
                break;
            case "7":
                Console.WriteLine("{0} - Seven", Digit);
                break;
            case "8":
                Console.WriteLine("{0} - Eight", Digit);
                break;
            case "9":
                Console.WriteLine("{0} - Nine", Digit);
                break;
        }

    }
}

