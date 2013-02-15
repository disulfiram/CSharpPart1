using System;

class AgePlusTen
{
    static void Main()
    {
        Console.WriteLine("How old are you now?");
        string line = Console.ReadLine(); 
	    int value;
        int.TryParse(line, out value);
	    Console.Write("In ten years you will be: ");
	    Console.WriteLine(value + 10);
    }
}
