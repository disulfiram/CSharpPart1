using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int Day = int.Parse(Console.ReadLine());
        int Month = int.Parse(Console.ReadLine());
        int Year = int.Parse(Console.ReadLine());
        Day += 1;
        if ((Day <= 31 && Month % 2 == 0) || (Day <= 30 && Month % 2 == 1) && Month != 2)
        {
            Console.WriteLine("{0}.{1}.{2}", Day, Month, Year);
        }
        
        {
            
        }
    }
}

