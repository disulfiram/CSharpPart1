using System;
using System.Text;

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
        for (byte UnicodeNumber = min; UnicodeNumber < max ; UnicodeNumber++)
        {
            char TableSymbol = (char)UnicodeNumber;
            string Symbol = TableSymbol.ToString();
            string HexDec = UnicodeNumber.ToString("X");
            string Dec = UnicodeNumber.ToString();
            Console.Write("{0}", Dec.PadRight(10));
	        Console.Write("{0}", Symbol.PadRight(10));
            Console.Write("{0}", HexDec.PadRight(10));
            Console.WriteLine();
        }
    }
}

