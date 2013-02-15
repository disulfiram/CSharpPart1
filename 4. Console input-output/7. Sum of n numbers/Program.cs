using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Title = "Sum of N numbers";
        Console.Write("Input N: ");
        int N;
        double n;
        double Sum = 0;
        while (true)
        {
            string Value = Console.ReadLine();
            int.TryParse(Value, out N);
            if (N > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("{0} is invalid number. Try again.", Value);
            }
        }
        for (int i = 1; i <= N; i++)
        {
            while (true)
            {
                Console.Write("Input number {0}: ",i);
                string Value = Console.ReadLine();
                bool nResult = double.TryParse(Value, out n);
                if (nResult == true)
                {
                    Sum += n;
                    break;
                }
                else
                {
                    Console.WriteLine("{0} is invalid number. Try again.", Value);
                }
            }
        }
        Console.WriteLine("The sum of the numbers is: {0}", Sum);
    }
}
