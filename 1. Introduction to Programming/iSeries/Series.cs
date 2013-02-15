using System;

class Series
{
    public static int SeriesN(int n)
    {
        int a = 2;
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            if (i % 2 == 0)
            {
                a = temp - (2 * temp + 1);      //Getting positive values of the series
            }
            else
            {
                a = temp - (2 * temp - 1);      //Getting negative values of the series
            }
        }
        return a;
    }
    static void Main()
    {
        Console.Title = "Number Series";
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine(SeriesN(i));
        }
    }
}