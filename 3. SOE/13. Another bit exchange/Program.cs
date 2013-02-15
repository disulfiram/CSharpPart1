using System;

class AnotherBitExchange
{
    static void Main()
    {
        Console.Title = "Bits: 3, 4 & 5 will be exchanged with bits: 24, 25 & 26 in the integer";
        int n;
        while (true)
        {
            Console.Write("Input integer: ");
            string Value = Console.ReadLine();
            bool nResult = int.TryParse(Value, out n);
            if (nResult == true)
            {
                break;
            }
            else
            {
                Console.WriteLine("Not valid integer. Try again: ");
            }
        }
        int ThirdBit;
        int ForthBit;
        int FifthBit;
        int TForthBit;
        int TFifthBit;
        int TSixthBit;
        int mask3 = 1 << 3;
        int NumberAndMask = n & mask3;
        ThirdBit = NumberAndMask >> 3;
        int mask4 = 1 << 4;
        NumberAndMask = n & mask4;
        ForthBit = NumberAndMask >> 4;
        int mask5 = 1 << 5;
        NumberAndMask = n & mask5;
        FifthBit = NumberAndMask >> 5;
        int mask24 = 1 << 24;
        NumberAndMask = n & mask24;
        TForthBit = NumberAndMask >> 24;
        int mask25 = 1 << 25;
        NumberAndMask = n & mask25;
        TFifthBit = NumberAndMask >> 25;
        int mask26 = 1 << 26;
        NumberAndMask = n & mask26;
        TSixthBit = NumberAndMask >> 26;
        bool ValueCheck = true;
        if (ThirdBit == 0)
        {
            ValueCheck = false;
        }
        else
        {
            ValueCheck = true;
        }
        int NewNumber;
        if (ValueCheck == false)
        {
            int mask = ~(1 << 26);
            NewNumber = n & mask;
        }
        else
        {
            int mask = 1 << 26;
            NewNumber = n | mask;
        }

        if (ForthBit == 0)
        {
            ValueCheck = false;
        }
        else
        {
            ValueCheck = true;
        }
        if (ValueCheck == false)
        {
            int mask = ~(1 << 25);
            NewNumber = NewNumber & mask;
        }
        else
        {
            int mask = 1 << 25;
            NewNumber = NewNumber | mask;
        }

        if (FifthBit == 0)
        {
            ValueCheck = false;
        }
        else
        {
            ValueCheck = true;
        }
        if (ValueCheck == false)
        {
            int mask = ~(1 << 24);
            NewNumber = NewNumber & mask;
        }
        else
        {
            int mask = 1 << 24;
            NewNumber = NewNumber | mask;
        }

        if (TForthBit == 0)
        {
            ValueCheck = false;
        }
        else
        {
            ValueCheck = true;
        }
        if (ValueCheck == false)
        {
            int mask = ~(1 << 5);
            NewNumber = NewNumber & mask;
        }
        else
        {
            int mask = 1 << 5;
            NewNumber = NewNumber | mask;
        }

        if (TFifthBit == 0)
        {
            ValueCheck = false;
        }
        else
        {
            ValueCheck = true;
        }
        if (ValueCheck == false)
        {
            int mask = ~(1 << 4);
            NewNumber = NewNumber & mask;
        }
        else
        {
            int mask = 1 << 4;
            NewNumber = NewNumber | mask;
        }

        if (TSixthBit == 0)
        {
            ValueCheck = false;
        }
        else
        {
            ValueCheck = true;
        }
        if (ValueCheck == false)
        {
            int mask = ~(1 << 3);
            NewNumber = NewNumber & mask;
        }
        else
        {
            int mask = 1 << 3;
            NewNumber = NewNumber | mask;
        }
        Console.WriteLine("New number is: {0}", NewNumber);
        Console.WriteLine("In Binary:");
        Console.WriteLine("{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("{0}", Convert.ToString(NewNumber, 2).PadLeft(32, '0'));
    }
}

