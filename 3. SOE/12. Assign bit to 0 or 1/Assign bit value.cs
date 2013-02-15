using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Asign value to a specific bit.";
        Console.Write("Bit position: ");
        int BitPosition = int.Parse(Console.ReadLine());
        Console.Write("Input number: ");
        int InputNumber = int.Parse(Console.ReadLine());
        Console.Write("Set Value: ");
        int Value;
        bool ValueCheck = true;
        while (true)
        {
            Value = int.Parse(Console.ReadLine());
            if ((Value == 0) || (Value == 1))
            {
                break;
            }
            else
	        {
                Console.Write("Invalid value, please enter 0 or 1: ");
                continue;
	        }
        }
        if (Value == 0)
	    {
            ValueCheck = false;
	    }
        else
	    {
            ValueCheck = true;
	    }
        int NewNumber;
        if (ValueCheck == false)
        {
            int mask = ~(1 << BitPosition);
            NewNumber = InputNumber & mask;
        }
        else
        {
            int mask = 1 << BitPosition;          
            NewNumber = InputNumber | mask;      
        }
        Console.WriteLine("New number is: {0}", NewNumber);
    }
}

