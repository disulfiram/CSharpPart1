using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Кирилица НЕ работи");
            //Console.OutputEncoding = Encoding.UTF8;
            int a = 21;
            int b = 2;
            int c = 10;
            int ac = a ^ c;
            int acb = ac >> b++;
            int result = (a ^ c) >> --b;
            Console.WriteLine(result);
            string test = "This \\is\\ a testing\"string\"";
            Console.WriteLine(test);
            a = 100;
            b = 200;
            c = 300;
            int res = a < b ? a > c ? c : a : b;
            Console.WriteLine(res);
            a = int.MaxValue;
            Console.WriteLine(a);
            res = a + 1;
            Console.WriteLine(res);
            a = 1;
            //if ((bool)a)
            a = 6;
            b = 8;
            Console.WriteLine("If I do this I will get:" + a + b);
            a = 5;
            //int? b1 = a;
            //a = b1;
            switch (a)
            {
                case 1: Console.WriteLine(1); break;
                case 2: Console.WriteLine(2); break;
                case 3: Console.WriteLine(3); break;
                case 4: Console.WriteLine(4); break;
            }
            //int? a! = null;
            //res = a ?? 5.5;
            bool first = false;
            bool second = false;
            bool third = true;
            bool fourth = false;
            bool fifth = true;
            Console.WriteLine( first ? second : third ? fourth : fifth);
            Console.WriteLine("Кирилица работи");
            a = 2;
            b = 3;
            double Result = (double)b / a;
            Console.WriteLine(Result);
        }
    }
}
