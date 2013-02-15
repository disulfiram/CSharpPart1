using System;

class Quotes
{
    static void Main()
    {
        Console.Title = "Same sentance different ways.";
        string FirstWay = "The \"use\" of quotations causes difficulties.";
        string SecondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0} \n{1}", FirstWay, SecondWay);
    }
}
