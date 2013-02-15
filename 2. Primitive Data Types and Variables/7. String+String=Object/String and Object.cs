using System;

class Object
{
    static void Main()
    {
        Console.Title = "Hi there.";
        string H = "Hello";
        string W = "World";
        object HW = string.Concat(H, " ", W);
        string HWS = HW.ToString();
        Console.WriteLine("{0}!", HWS);
    }
}
