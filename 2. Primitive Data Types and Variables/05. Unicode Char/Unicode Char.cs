//Declare a character variable and assign it with the symbol that has 
//Unicode code 72. Hint: first use the Windows Calculator to find the 
//hexadecimal representation of 72.

using System;

class UnicodeToSymbol
{
    static void Main()
    {
        Console.Title = "72th Unicode Character";
        char unicode72 = '\u0048';      //char used to declare unicode symbol
        Console.WriteLine("The symbol that has unicode 72 is: {0}", unicode72);
    }
}