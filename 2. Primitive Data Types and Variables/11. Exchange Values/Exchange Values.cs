using System;

class Exchange
{
    static void Main()
    {
        Console.Title = "Exchanged variables.";
        byte First = 5;
        byte Second = 10;
        byte Exchange;          //temporary variable to store the value of the other variables.
        Exchange = First;       //1. store value
        First = Second;         //first var takes value of second
        Second = Exchange;      //second var takes the stored value
        Console.WriteLine("First variable started as 5, now is: {0}\nSecond variable started as 10, now is: {1}", First, Second);
    }
}
