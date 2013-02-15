using System;

class Program
{
    static void Main()
    {
        Console.Title = "Apple triangle";
        char copyright = '\u00A9'; 
        Console.WriteLine("  {0}", copyright);
        Console.WriteLine(" {0}{0}{0}", copyright);
        Console.WriteLine("{0}{0}{0}{0}{0}", copyright);
    }
}
