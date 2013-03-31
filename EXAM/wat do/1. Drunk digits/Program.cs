using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TripleRotationOfDigits
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int L = K.ToString().Length;
        int? Last0 = K % 10;
        int? Last1 = (K / 10) % 10;
        int? Last2 = (K / 100) % 10;
        int? Last3 = (K / 1000) % 10;
        int? Last4 = (K / 10000) % 10;
        int? Last5 = (K / 100000) % 10;
        switch (L)
        {
            case 1:
                {
                    Console.WriteLine(Last0);
                    break;
                }
            case 2:
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (Last0 != 0)
                        {
                            int? temp = Last0;
                            Last0 = Last1;
                            Last1 = temp;
                        }
                        else
                        {
                            Last0 = Last1;
                            Last1 = null;
                        }
                    }
                    Console.WriteLine("{0}{1}", Last1, Last0);
                    break;
                }
            case 3:
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (Last0 != 0)
                        {
                            int? temp = Last0;
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = temp;
                        }
                        else
                        {
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = null;
                        }
                    }
                    Console.WriteLine("{0}{1}{2}", Last2, Last1, Last0);
                    break;
                }
            case 4:
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (Last0 != 0)
                        {
                            int? temp = Last0;
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = Last3;
                            Last3 = temp;
                        }
                        else
                        {
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = Last3;
                            Last3 = null;
                        }
                    }
                    Console.WriteLine("{0}{1}{2}{3}", Last3, Last2, Last1, Last0);
                    break;
                }
            case 5:
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (Last0 != 0)
                        {
                            int? temp = Last0;
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = Last3;
                            Last3 = Last4;
                            Last4 = temp;
                        }
                        else
                        {
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = Last3;
                            Last3 = Last4;
                            Last4 = null;
                        }
                    }
                    Console.WriteLine("{0}{1}{2}{3}{4}", Last4, Last3, Last2, Last1, Last0);
                    break;
                }
            case 6:
                {
                    for (int i = 0; i < 3; i++)
			        {
			            if (Last0 != 0)
                        {
                            int? temp = Last0;
                            Last0= Last1;
                            Last1 = Last2;
                            Last2 = Last3;
                            Last3 = Last4;
                            Last4 = Last5;
                            Last5 = temp;                          
                        }
                        else
                        {
                            Last0 = Last1;
                            Last1 = Last2;
                            Last2 = Last3;
                            Last3 = Last4;
                            Last4 = Last5;
                            Last5 = null;
                        }
   			        }
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}", Last5, Last4, Last3, Last2, Last1, Last0);     
                    break;
                }
            default:
                break;
        }
    }
}