//Declare five variables choosing for each of them the most appropriate of
//the types byte, sbyte, short, ushort, int, uint, long, ulong to 
//represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class SuitableDataTypes
{
    static void Main()
    {
        Console.Title = "Data Types";
        byte from0to255 = 97;
        sbyte from_128to127 = -115;
        short from_32768to32767 = -10000;
        ushort from0to65535 = 52130;
        int from_2147483648to2147483647 = 4825932;
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", from0to255, from_128to127, from_32768to32767, from0to65535, from_2147483648to2147483647);
    }
}