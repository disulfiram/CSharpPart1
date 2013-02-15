using System;

class NullValue
{
    static void Main()
    {
        Console.Title = "Null Values";
        int? NullInteger = null;        //doesn't work without the '?'
        Console.WriteLine("This is integer with Null value -> {0}", NullInteger);
        int ValueInteger = 5;
        Console.WriteLine("This is integer with value 5 -> {0}", ValueInteger);
        double? NullDouble = null;      //doesn't work without the '?'
        Console.WriteLine("This is double with null value -> {0}", NullDouble);
        double ValueDouble = 0.5D;
        Console.WriteLine("This is double with value -> {0}", ValueDouble);
        int? Temporary = NullInteger + NullInteger;     //I don't even know what this ? stands for
        Console.WriteLine("Null + Null = {0}", Temporary);
        Temporary = NullInteger + ValueInteger;
        Console.WriteLine("Null + Value = {0}", Temporary);
    }
}

