//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the 
//first two variables (mind adding an interval). Declare a third string 
//variable and initialize it with the value of the object variable (you 
//should perform type casting).

using System;

class Object
{
    static void Main()
    {
        Console.Title = "Hi there.";
        string helloString = "Hello";
        string worldString = "World";
        object helloWorldObject = string.Concat(helloString, " ", worldString);
        string helloWorldString = helloWorldObject.ToString();
        Console.WriteLine("{0}!", helloWorldString);
    }
}