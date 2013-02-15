using System;

class Series
{
    static void Main()
    {
        Console.Title = "Series";
        double Sn = 1;
        for (double i = 2; i < 1001; i++)                        //1/n < 0.001
        {                                                        //n > 1000
            if (i % 2 == 0)                                      
            {                                                    
                Sn += (1 / i);                                   
            }                                                    
            else                                                 
            {                                                    
                Sn -= (1 / i);                                   
            }                                                    
        }                                                        
        Console.WriteLine("Sn = {0:F3}", Sn);                    
    }
}
