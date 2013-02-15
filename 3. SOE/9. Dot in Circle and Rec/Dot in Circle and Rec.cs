using System;

class DotInCircleRec
{
    static void Main()
    {
        Console.Title = "Is the given dot inside a circle K((1,1),3)";
        Console.Write("X coordinate of dot: ");
        double InputX = double.Parse(Console.ReadLine());       //Not suer if float or double?
        Console.Write("Y coordinate of dot: ");
        double InputY = double.Parse(Console.ReadLine());
        if (InputX >= -1 && InputX <= 5 && InputY >= -1 && InputY <= 1)
        {
            Console.WriteLine("The dot is in the rectanel");           
        }
        else
        {
            Console.WriteLine("The dot is outside the rectangel");
        }
        InputX = InputX - 1;
        InputY = InputY - 1;
        double Dist = Math.Sqrt((InputX * InputX) + (InputY * InputY));
        if (Dist < 3)
        {
            Console.WriteLine("The dot is in the circle");
        }
        else
        {
            if (Dist == 3)
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
