﻿//Which of the following values can be assigned to a variable of type 
//float and which to a variable of type double: 34.567839023, 12.345, 
//8923.1234857, 3456.091?

using System;

class FloatOrDouble
{
    static void Main(string[] args)
    {
        Console.Title = "Data Types";
        float a = 12.345f;
        float b = 3456.091f;
        double c = 34.567839023;
        double d = 8923.1234857;
        Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, d);
    }
}