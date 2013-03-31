using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battleship
{
    static void Main()
    {
        int Sx1 = int.Parse(Console.ReadLine());
        int Sy1 = int.Parse(Console.ReadLine());
        int Sx2 = int.Parse(Console.ReadLine());
        int Sy2 = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        int Cx1 = int.Parse(Console.ReadLine());
        int Cy1 = int.Parse(Console.ReadLine());
        int Cx2 = int.Parse(Console.ReadLine());
        int Cy2 = int.Parse(Console.ReadLine());
        int Cx3 = int.Parse(Console.ReadLine());
        int Cy3 = int.Parse(Console.ReadLine());
        
        int ShipMaxX = Math.Max(Sx1, Sx2);
        int ShipMinX = Math.Min(Sx1, Sx2);
        int ShipMaxY = Math.Max(Sy1, Sy2);
        int ShipMinY = Math.Min(Sy1, Sy2);
        int Sy1Min = ShipMinY - H;
        int Sy2Max = ShipMaxY - H;
        int Cy1N = H - Cy1;
        int Cy2N = H - Cy2;
        int Cy3N = H - Cy3;
        int sum = 0;
        if (((Cx1 > ShipMaxX) || (Cx1 < ShipMinX)) || ((Cy1N < Sy1Min) || (Cy1N > Sy2Max)))
        {
            sum = 0;
        }
        else
        {
            if (((Cx1 < ShipMaxX) && (Cx1 > ShipMinX)) && ((Cy1N > Sy1Min) && (Cy1N < Sy2Max)))
            {
                sum = 100;
            }
            else
            {
                if (((Cx1 == ShipMinX) || (Cx1 == ShipMaxX)) && ((Cy1N == Sy1Min) || (Cy1N == Sy2Max)))
                {
                    sum = 25;
                }
                else
                {
                    sum = 50;
                }
            }
            
        }
        if (((Cx2 > ShipMaxX) || (Cx2 < ShipMinX)) || ((Cy2N < Sy1Min) || (Cy2N > Sy2Max)))
        {
            sum += 0;
        }
        else
        {
            if (((Cx2 < ShipMaxX) && (Cx2 > ShipMinX)) && (Cy2N > Sy1Min) && (Cy2N < Sy2Max))
            {
                sum += 100;
            }
            else
            {
                if (((Cx2 == ShipMinX) || (Cx2 == ShipMaxX)) && ((Cy2N == Sy1Min) || (Cy2N == Sy2Max)))
                {
                    sum += 25;
                }
                else
                {
                    sum += 50;
                }
            }
        
        }
        if (((Cx3 > ShipMaxX) || (Cx3 < ShipMinX)) || (Cy3N < Sy1Min) || (Cy3N > Sy2Max))
        {
            sum += 0;
        }
        else
        {
            if (((Cx3 < ShipMaxX) && (Cx3 > ShipMinX)) && ((Cy3N > Sy1Min) && (Cy3N < Sy2Max)))
            {
                sum += 100;
            }
            else
            {
                if (((Cx3 == ShipMinX) || (Cx3 == ShipMaxX)) && ((Cy3N == Sy1Min) || (Cy3N == Sy2Max)))
                {
                    sum += 25;
                }
                else
                {
                    sum += 50;
                }
            }
        
        }
        
        //if (((Cx1 > Sx2) || (Cx1 < Sx1)) || ((Math.Abs(Cy1N) < Sy1N) || (Math.Abs(Cy1N) > Sy2N)))
        //{
        //    sum = 0;
        //}
        //if (((Cx1 == Sx1) || (Cx1 == Sx2)) && ((Math.Abs(Cy1N) == Sy1N) || (Math.Abs(Cy1N) == Sy2N)))
        //{
        //    sum = 25;
        //}
        //if ((((Cx1 == Sx1) || (Cx1 == Sx2)) && ((Math.Abs(Cy1N) > Sy1N) || (Math.Abs(Cy1N) < Sy2N))) || (((Cx1 < Sx1) || (Cx1 > Sx2)) && ((Math.Abs(Cy1N) == Sy1N) || (Math.Abs(Cy1N) == Sy2N))))
        //{
        //    sum = 50;
        //}
        //if ((Cx1 > Sx1) && (Cx1 < Sx2) && (Math.Abs(Cy1N) > Sy1N) && (Math.Abs(Cy1N) < Sy2N))
        //{
        //    sum = 100;
        //}
        //
        //if (((Cx2 > Sx2) || (Cx2 < Sx1)) || ((Math.Abs(Cy2N) < Sy1N) || (Math.Abs(Cy2N) > Sy2N)))
        //{
        //    sum += 0;
        //}
        //if (((Cx2 == Sx1) || (Cx2 == Sx2)) && ((Math.Abs(Cy2N) == Sy1N) || (Math.Abs(Cy2N) == Sy2N)))
        //{
        //    sum += 25;
        //}
        //if ((((Cx2 == Sx1) || (Cx2 == Sx2)) && ((Math.Abs(Cy2N) > Sy1N) || (Math.Abs(Cy2N) < Sy2N))) || (((Cx2 < Sx1) || (Cx2 > Sx2)) && ((Math.Abs(Cy2N) == Sy1N) || (Math.Abs(Cy2N) == Sy2N))))
        //{
        //    sum += 50;
        //}
        //if ((Cx2 > Sx1) && (Cx2 < Sx2) && (Math.Abs(Cy2N) > Sy1N) && (Math.Abs(Cy2N) < Sy2N))
        //{
        //    sum += 100;
        //}
        //
        //if (((Cx3 > Sx2) || (Cx3 < Sx1)) || ((Math.Abs(Cy3N) < Sy1N) || (Math.Abs(Cy3N) > Sy2N)))
        //{
        //    sum += 0;
        //}
        //if (((Cx3 == Sx1) || (Cx3 == Sx2)) && ((Math.Abs(Cy3N) == Sy1N) || (Math.Abs(Cy3N) == Sy2N)))
        //{
        //    sum += 25;
        //}
        //if ((((Cx3 == Sx1) || (Cx3 == Sx2)) && ((Math.Abs(Cy3N) > Sy1N) || (Math.Abs(Cy3N) < Sy2N))) || (((Cx3 < Sx1) || (Cx3 > Sx2)) && ((Math.Abs(Cy3N) == Sy1N) || (Math.Abs(Cy3N) == Sy2N))))
        //{
        //    sum += 50;
        //}
        //if ((Cx3 > Sx1) && (Cx3 < Sx2) && (Math.Abs(Cy3N) > Sy1N) && (Math.Abs(Cy3N) < Sy2N))
        //{
        //    sum += 100;
        //}
        Console.WriteLine("{0}%",sum);
    }
}

