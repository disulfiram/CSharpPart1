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
            string Value = Console.ReadLine();
            bool aResult = double.TryParse(Value, out a);
            Console.Write("b = ");
            Value = Console.ReadLine();
            bool bResult = double.TryParse(Value, out b);
            Console.Write("c = ");
            Value = Console.ReadLine();
            bool cResult = double.TryParse(Value, out c);
            if ((aResult == true) && (bResult == true) && (cResult == true))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid numbers. Try again:");
            }
        }
        double D = Math.Pow(b, 2) - (4 * a * c);
        if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Equation has one solution: {0}", x);
        }
        else
        {
            if (D > 0)
            {
                double x_1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x_2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("Solutions to the equation are: {0}, {1}", x_1, x_2);
            }
            else
            {
                Console.WriteLine("Equation has no real solutions.");
            }
        }
    }
}
