using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NumbersWithWords
    {
        static void Main()
        {
            Console.Title = "Numbers with words";
            int n;
            while (true)
            {
                Console.Write("Input number from o to 999: ");
                string Value = Console.ReadLine();
                bool Result = int.TryParse(Value, out n);
                if ((Result == true) && (n >=0) && (n <= 999))
                {
                    break;
                }
            }
            int First = n / 100;
            int Second = (n - (First * 100)) / 10;
            int Third = n % 10;
            string FirstValue = Convert.ToString(First);
            string SecondValue = Convert.ToString(Second);
            string ThirdValue = Convert.ToString(Third);
            switch (FirstValue)
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
            switch (SecondValue)
            {
                default:
                    break;
                case "0":
                    if (First != 0)
                    {
                        Console.Write("and ");
                    }
                    break;
                case "1":
                    switch (ThirdValue)
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
            if (Second != 1)
            {
                switch (ThirdValue)
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
