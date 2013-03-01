//Declare  two integer variables and assign them with 5 and 10 and after 
//that exchange their values.

using System;

class Exchange
{
    static void Main()
    {
        Console.Title = "Exchanged variables.";
        byte first = 5;
        byte second = 10;
        byte exchange;          //temporary variable to store the value of the other variables.
        exchange = first;       //1. store value
        first = second;         //first var takes value of second
        second = exchange;      //second var takes the stored value
        Console.WriteLine("First variable started as 5, now is: {0}\nSecond variable started as 10, now is: {1}", first, second);
    }
}