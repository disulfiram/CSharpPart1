using System;

class Circle
{
    static void Main()
    {
        Console.Title = "Circle info";
        double r;
        double A;
        double P;
        double pi = Math.PI;
        Console.Write("Input circle radius:");
        while (true)
        {
            string Value = Console.ReadLine();
            double.TryParse(Value,out r);
            if (r > 0)
            {
                break;
            }
            else
	        {
                Console.WriteLine("Invalid radius. Try again.");
	        }
        }
        A = Math.Pow( r , 2) * pi;
        P = 2 * pi * r;
        Console.WriteLine("Area and perimeter of a circle with radius r = {0}, are as follows: A = {1}, P = {2}",r,A,P);
    }
}

