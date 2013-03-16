using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic Equation";
        double a;
        double b;
        double c;
        Console.WriteLine("Input as follows:");
        while (true)
        {
            Console.Write("a = ");
            string value = Console.ReadLine();
            bool aResult = double.TryParse(value, out a);
            Console.Write("b = ");
            value = Console.ReadLine();
            bool bResult = double.TryParse(value, out b);
            Console.Write("c = ");
            value = Console.ReadLine();
            bool cResult = double.TryParse(value, out c);
            if ((aResult == true) && (bResult == true) && (cResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        double discreminant = Math.Pow(b, 2) - (4 * a * c);
        if (discreminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Equation has one solution: {0}", x);
        }
        else
        {
            if (discreminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discreminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discreminant)) / (2 * a);
                Console.WriteLine("Solutions to the equation are: {0}, {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Equation has no real solutions.");
            }
        }
    }
}
