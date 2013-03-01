//Declare two string variables and assign them with following value:
//"The "use" of quotations causes difficulties"
//Do the above in two different ways: with and without using quoted strings.

using System;

class Quotes
{
    static void Main()
    {
        Console.Title = "Same sentance different ways.";
        string firstWay = "The \"use\" of quotations causes difficulties.";
        string secondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0} \n{1}", firstWay, secondWay);
    }
}