using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main()
    {
        decimal X = decimal.Parse(Console.ReadLine());
        decimal Y = decimal.Parse(Console.ReadLine());

        if (X>0)
        {
            if (Y>0)
            {
                Console.WriteLine("1");
            }
            if (Y<0)
            {
                Console.WriteLine("4");
            }
            if (Y==0)
            {
                Console.WriteLine("6");
            }
        }
        if (X < 0)
        {
            if (Y > 0)
            {
                Console.WriteLine("2");
            }
            if (Y < 0)
            {
                Console.WriteLine("3");
            }
            if (Y == 0)
            {
                Console.WriteLine("6");
            }
        }
        if (X == 0)
        {
            if (Y > 0)
            {
                Console.WriteLine("5");
            }
            if (Y < 0)
            {
                Console.WriteLine("5");
            }
            if (Y == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}