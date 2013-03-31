using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Quadronacci
{
    static void Main()
    {
        //Input Data
        long Trib1 = long.Parse(Console.ReadLine());
        long Trib2 = long.Parse(Console.ReadLine());
        long Trib3 = long.Parse(Console.ReadLine());
        long Trib4 = long.Parse(Console.ReadLine());

        byte R = byte.Parse(Console.ReadLine());
        byte C = byte.Parse(Console.ReadLine());
        long[] Quadronacci = new long[(R * C) + 1];
        Quadronacci[1] = Trib1;
        Quadronacci[2] = Trib2;
        Quadronacci[3] = Trib3;
        Quadronacci[4] = Trib4;
        for (int i = 5; i <= R * C; i++)
        {
            Quadronacci[i] = Quadronacci[i - 1] + Quadronacci[i - 2] + Quadronacci[i - 3] + Quadronacci[i - 4];
        }
        for (int i = 1; i <= R * C; i++)
        {
            if (((i-1) % C == 0) && i!=1)
            {
                Console.WriteLine();
            }
            else if (i !=1)
            {
                Console.Write(" ");
            }
            Console.Write(Quadronacci[i]);
        }
    }
}

