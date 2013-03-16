﻿using System;
using System.Linq;

class NumbersWithWords
{
    static void Main()
    {
        Console.Title = "Numbers with words";
        int n;
        while (true)
        {
            Console.Write("Input number from o to 999: ");
            string value = Console.ReadLine();
            bool result = int.TryParse(value, out n);
            if ((result == true) && (n >= 0) && (n <= 999))
            {
                break;
            }
        }
        int first = n / 100;
        int second = (n - (first * 100)) / 10;
        int third = n % 10;
        string firstValue = Convert.ToString(first);
        string secondValue = Convert.ToString(second);
        string thirdValue = Convert.ToString(third);
        switch (firstValue)
        {
            default:
                break;
            case "0":
                break;
            case "1":
                Console.Write("One hundred ");
                break;
            case "2":
                Console.Write("Two hundred ");
                break;
            case "3":
                Console.Write("Three hundred ");
                break;
            case "4":
                Console.Write("Four hundred ");
                break;
            case "5":
                Console.Write("Five hundred ");
                break;
            case "6":
                Console.Write("Six hundred ");
                break;
            case "7":
                Console.Write("Seven hundred ");
                break;
            case "8":
                Console.Write("Eight hundred ");
                break;
            case "9":
                Console.Write("Nine hundred ");
                break;
        }
        switch (secondValue)
        {
            default:
                break;
            case "0":
                if (first != 0)
                {
                    Console.Write("and ");
                }
                break;
            case "1":
                switch (thirdValue)
                {
                    default:
                        break;
                    case "0":
                        Console.Write("Ten");
                        break;
                    case "1":
                        Console.Write("Eleven");
                        break;
                    case "2":
                        Console.Write("Twelve");
                        break;
                    case "3":
                        Console.Write("Thirteen");
                        break;
                    case "4":
                        Console.Write("Fourteen");
                        break;
                    case "5":
                        Console.Write("Fifteen");
                        break;
                    case "6":
                        Console.Write("Sixteen");
                        break;
                    case "7":
                        Console.Write("Seventeen");
                        break;
                    case "8":
                        Console.Write("Eighteen");
                        break;
                    case "9":
                        Console.Write("Nineteen");
                        break;
                }
                break;
            case "2":
                Console.Write("Twenty");
                break;
            case "3":
                Console.Write("Thirty");
                break;
            case "4":
                Console.Write("Fourty ");
                break;
            case "5":
                Console.Write("Fifty ");
                break;
            case "6":
                Console.Write("Sixty ");
                break;
            case "7":
                Console.Write("Seventy ");
                break;
            case "8":
                Console.Write("Eighty ");
                break;
            case "9":
                Console.Write("Ninety ");
                break;
        }
        if (second != 1)
        {
            switch (thirdValue)
            {
                default:
                    break;
                case "0":
                    break;
                case "1":
                    Console.Write("One");
                    break;
                case "2":
                    Console.Write("Two");
                    break;
                case "3":
                    Console.Write("Three");
                    break;
                case "4":
                    Console.Write("Four");
                    break;
                case "5":
                    Console.Write("Five");
                    break;
                case "6":
                    Console.Write("Six");
                    break;
                case "7":
                    Console.Write("Seven");
                    break;
                case "8":
                    Console.Write("Eight");
                    break;
                case "9":
                    Console.Write("Nine");
                    break;
            }
        }
    }
}