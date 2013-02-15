using System;

class OneToN
{
    static void Main()
    {
        Console.Title = "Numbers from 1 to N";
        int N;
        Console.Write("Input N: ");
        while (true)
        {
            string Value = Console.ReadLine();
            int.TryParse(Value, out N);
            if (N > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid N. Try again.");
            }   
        }
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}

