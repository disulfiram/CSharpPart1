using System;

class DotInCircle
{
    static void Main()
    {
        Console.Title = "Is the given dot inside a circle K(0,5)";
        Console.Write("X coordinate of dot: ");
        double InputX = double.Parse(Console.ReadLine());       //Not suer if float or double?
        Console.Write("Y coordinate of dot: ");
        double InputY = double.Parse(Console.ReadLine());
        double Dist = Math.Sqrt((InputX*InputX) + (InputY*InputY));
        if (Dist < 5)
        {
            Console.WriteLine("The dot is in the circle");
        }
        else
        {
            if (Dist == 5)
            {
                Console.WriteLine("The dot is on the circle");
            }
            else
            {
                Console.WriteLine("The dot is outside the circle");
            }
        }
    }
}
