using System;

class Program
{
    static void Main()
    {
        Console.Title = "3rd bit of number";
        int bitPosition = 3;
        Console.Write("Input Number: ");
        int inputNumber = int.Parse(Console.ReadLine());             
        int mask = 1 << bitPosition;        
        int numberAndMask = inputNumber & mask;  
        int bit = numberAndMask >> bitPosition;  
        bool check = (bit == 0);
        if (check == true)
        {
            Console.WriteLine("3rd bit is 0");
        }
        else
        {
            Console.WriteLine("3rd bit is 1");
        }
    }
}

