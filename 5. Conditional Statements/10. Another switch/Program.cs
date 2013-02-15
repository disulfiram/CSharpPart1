using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SwitchFrom1to9
{
    static void Main()
    {
        Console.Title = "Switch practice";
        Console.Write("Input a digit from 1 to 9: ");
        string Value = Console.ReadLine();
        int n;
        int.TryParse(Value, out n);
        switch (Value)
        {
            default:
                Console.WriteLine("I report error");
                break;
            case "1":
            case "2":
            case "3":
                n = n * 10;
                break;
            case "4":
            case "5":
            case "6":
                n = n * 100;
                break;
            case "7":
            case "8":
            case "9":
                n = n * 1000;
                break;
        }
        Console.WriteLine(n);
    }
}

