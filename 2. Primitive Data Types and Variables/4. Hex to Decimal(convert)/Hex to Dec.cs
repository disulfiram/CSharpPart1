using System;

class HexToDec
{
    static void Main()
    {
        Console.Title = "Hex to Decimal";
        string hexValue = "FE";
        int decValue = Convert.ToInt32(hexValue, 16);
        Console.WriteLine("{0}", decValue);
    }
}

