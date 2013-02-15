using System;

class Program
{
    static void Main()
    {
        Console.Title = "3rd bit of number";
        int BitPosition = 3;
        Console.Write("Input Number: ");
        int InputNumber = int.Parse(Console.ReadLine());             
        int mask = 1 << BitPosition;        
        int NumberAndMask = InputNumber & mask;  
        int bit = NumberAndMask >> BitPosition;  
        bool Check = (bit == 0);
        if (Check == true)
        {
            Console.WriteLine("3rd bit is 0");
        }
        else
        {
            Console.WriteLine("3rd bit is 1");
        }
    }
}

