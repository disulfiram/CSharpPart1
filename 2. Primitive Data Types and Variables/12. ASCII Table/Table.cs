//Find online more information about ASCII (American Standard Code for 
//Information Interchange) and write a program that prints the entire 
//ASCII table of characters on the console.

using System;

class ASCIItable
{
    static void Main()
    {
        Console.Title = "ASCII Table";
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.WriteLine("Hex".PadRight(10));
        byte min = 0;
        byte max = 127;     //Table limits
        for (byte unicodeNumber = min; unicodeNumber < max; unicodeNumber++)
        {
            char tableSymbol = (char)unicodeNumber;
            string symbol = tableSymbol.ToString();
            string hexDec = unicodeNumber.ToString("X");
            string dec = unicodeNumber.ToString();
            Console.Write("{0}", dec.PadRight(10));
            Console.Write("{0}", symbol.PadRight(10));
            Console.Write("{0}", hexDec.PadRight(10));
            Console.WriteLine();
        }
    }
}