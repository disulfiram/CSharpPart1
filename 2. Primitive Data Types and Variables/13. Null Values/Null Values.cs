//Create a program that assigns null values to an integer and to double 
//variables. Try to print them on the console, try to add some values or 
//the null literal to them and see the result.

using System;

class NullValue
{
    static void Main()
    {
        Console.Title = "Null Values";
        int? nullInteger = null;        //doesn't work without the '?'
        Console.WriteLine("This is integer with Null value -> {0}", nullInteger);
        int valueInteger = 5;
        Console.WriteLine("This is integer with value 5 -> {0}", valueInteger);
        double? nullDouble = null;      //doesn't work without the '?'
        Console.WriteLine("This is double with null value -> {0}", nullDouble);
        double valueDouble = 0.5D;
        Console.WriteLine("This is double with value -> {0}", valueDouble);
        int? temporary = nullInteger + nullInteger;     //I don't even know what this ? stands for
        Console.WriteLine("Null + Null = {0}", temporary);
        temporary = nullInteger + valueInteger;
        Console.WriteLine("Null + Value = {0}", temporary);
    }
}