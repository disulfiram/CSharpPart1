using System;

class TimeAndDate
{
    static void Main()
    {
        Console.Title = "Time & Date";
        Console.WriteLine("Current time = {0:T}", DateTime.Now);
        Console.WriteLine("Current date = {0:D}", DateTime.Now);
    }
}

