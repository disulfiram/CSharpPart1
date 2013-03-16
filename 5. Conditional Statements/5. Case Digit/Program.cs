using System;

class Program
{
    static void Main()
    {
        Console.Title = "Digit in words";
        byte digit;
        while (true)
        {
            Console.Write("Digit (from 0 to 9): ");
            string value = Console.ReadLine();
            bool digitResult = byte.TryParse(value, out digit);
            if ((digitResult == true) && (digit >= 0) && (digit <= 9))
            {
                break;
            }
            else
            {
                Console.WriteLine("From 0 to 9!");
            }
        }
        string digitString = System.Convert.ToString(digit);
        switch (digitString)
        {
            case "0":
                Console.WriteLine("{0} - Zero", digit);
                break;
            case "1":
                Console.WriteLine("{0} - One", digit);
                break;
            case "2":
                Console.WriteLine("{0} - Two", digit);
                break;
            case "3":
                Console.WriteLine("{0} - Three", digit);
                break;
            case "4":
                Console.WriteLine("{0} - Four", digit);
                break;
            case "5":
                Console.WriteLine("{0} - Five", digit);
                break;
            case "6":
                Console.WriteLine("{0} - Six", digit);
                break;
            case "7":
                Console.WriteLine("{0} - Seven", digit);
                break;
            case "8":
                Console.WriteLine("{0} - Eight", digit);
                break;
            case "9":
                Console.WriteLine("{0} - Nine", digit);
                break;
        }

    }
}

