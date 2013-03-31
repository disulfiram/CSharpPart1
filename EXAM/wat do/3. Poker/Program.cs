using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        string[] Card = new string[5];
        for (int i = 0; i < 5; i++)
        {
            Card[i] = Console.ReadLine();
        }
        int countA = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;
        int count7 = 0;
        int count8 = 0;
        int count9 = 0;
        int count10 = 0;
        int countJ = 0;
        int countQ = 0;
        int countK = 0;
        for (int i = 0; i < 5; i++)
        {
            if (Card[i] == "A")
            {
                countA += 1;
            }
            if (Card[i] == "2")
            {
                count2 += 1;
            }
            if (Card[i] == "3")
            {
                count3 += 1;
            }
            if (Card[i] == "4")
            {
                count4 += 1;
            }
            if (Card[i] == "5")
            {
                count5 += 1;
            }
            if (Card[i] == "6")
            {
                count6 += 1;
            }
            if (Card[i] == "7")
            {
                count7 += 1;
            }
            if (Card[i] == "8")
            {
                count8 += 1;
            }
            if (Card[i] == "9")
            {
                count9 += 1;
            }
            if (Card[i] == "10")
            {
                count10 += 1;
            }
            if (Card[i] == "J")
            {
                countJ += 1;
            }
            if (Card[i] == "Q")
            {
                countQ += 1;
            }
            if (Card[i] == "K")
            {
                countK += 1;
            }
        }
        if (countA == 5 || count2 == 5 || count3 == 5 || count4 == 5 || count5 == 5 || count6 == 5 || count7 == 5 || count8 == 5 || count9 == 5 || count10 == 5 || countJ == 5 || countQ == 5 || countK == 5)
        {
            Console.WriteLine("Impossible");
        }
        else
        {
            if (countA == 4 || count2 == 4 || count3 == 4 || count4 == 4 || count5 == 4 || count6 == 4 || count7 == 4 || count8 == 4 || count9 == 4 || count10 == 4 || countJ == 4 || countQ == 4 || countK == 4)
            {
                Console.WriteLine("Four of a Kind");
            }
            else
            {
                if ((countA == 3 || count2 == 3 || count3 == 3 || count4 == 3 || count5 == 3 || count6 == 3 || count7 == 3 || count8 == 3 || count9 == 3 || count10 == 3 || countJ == 3 || countQ == 3 || countK == 3) && (countA == 2 || count2 == 2 || count3 == 2 || count4 == 2 || count5 == 2 || count6 == 2 || count7 == 2 || count8 == 2 || count9 == 2 || count10 == 2 || countJ == 2 || countQ == 2 || countK == 2))
                {
                    Console.WriteLine("Full House");
                }
                else
                {
                    if ((countA == 1 && count2 == 1 && count3 == 1 && count4 == 1 && count5 == 1) || (count2 == 1 && count3 == 1 && count4 == 1 && count5 == 1 && count6 == 1) || (count3 == 1 && count4 == 1 && count5 == 1 && count6 == 1 && count7 == 1) || (count4 == 1 && count5 == 1 && count6 == 1 && count7 == 1 && count8 == 1) || (count5 == 1 && count6 == 1 && count7 == 1 && count8 == 1 && count9 == 1) || (count6 == 1 && count7 == 1 && count8 == 1 && count9 == 1 && count10 == 1) || (count7 == 1 && count8 == 1 && count9 == 1 && count10 == 1 && countJ == 1) || (count8 == 1 && count9 == 1 && count10 == 1 && countJ == 1 && countQ == 1) || (count9 == 1 && count10 == 1 && countJ == 1 && countQ == 1 && countK == 1) || (count10 == 1 && countJ == 1 && countQ == 1 && countK == 1 && countA == 1))
                    {
                        Console.WriteLine("Straight");
                    }
                    else
                    {
                        if (countA == 3 || count2 == 3 || count3 == 3 || count4 == 3 || count5 == 3 || count6 == 3 || count7 == 3 || count8 == 3 || count9 == 3 || count10 == 3 || countJ == 3 || countQ == 3 || countK == 3)
                        {
                            Console.WriteLine("Three of a Kind");
                        }
                        else
                        {
                            if (countA == 2 ^ count2 == 2 ^ count3 == 2 ^ count4 == 2 ^ count5 == 2 ^ count6 == 2 ^ count7 == 2 ^ count8 == 2 ^ count9 == 2 ^ count10 == 2 ^ countJ == 2 ^ countQ == 2 ^ countK == 2)
                            {
                                Console.WriteLine("One Pair");
                            }
                            else
                            {
                                if ((countA == 2 || count2 == 2 || count3 == 2 || count4 == 2 || count5 == 2 || count6 == 2 || count7 == 2 || count8 == 2 || count9 == 2 || count10 == 2 || countJ == 2 || countQ == 2 || countK == 2) && (countA == 2 || count2 == 2 || count3 == 2 || count4 == 2 || count5 == 2 || count6 == 2 || count7 == 2 || count8 == 2 || count9 == 2 || count10 == 2 || countJ == 2 || countQ == 2 || countK == 2))
                                {
                                    Console.WriteLine("Two Pairs");
                                }
                                else
                                {
                                    Console.WriteLine("Nothing");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

