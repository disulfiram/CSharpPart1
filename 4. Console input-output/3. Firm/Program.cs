using System;

class FirmDetails
{
    static void Main()
    {
        Console.Title = "Firm Details";
        string Name;
        Console.Write("Input company name: ");
        Name = Console.ReadLine();
        string Address;
        Console.Write("Input address. Start with country: ");
        string Country = Console.ReadLine();
        Console.Write("City: ");
        string City = Console.ReadLine();
        Console.Write("Street: ");
        string Street = Console.ReadLine();
        Console.Write("Number: ");
        string Number = Console.ReadLine();
        Address = Country + ", " + City + ", " + Street + " " + Number;
        int PhoneNum;
        Console.Write("Input phone number: ");
        while (true)
        {
            string Value = Console.ReadLine();
            int.TryParse(Value, out PhoneNum);
            if (PhoneNum > 99999 && PhoneNum < 10000000)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid phone number. Try again.");
            }
        }
        int FaxNum;
        Console.Write("Input fax number: ");
        while (true)
        {
            string Value = Console.ReadLine();
            int.TryParse(Value, out FaxNum);
            if (FaxNum > 99999 && FaxNum < 10000000)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid fax number. Try again.");
            }
        }
        string WebSite;
        Console.Write("Input website: ");
        WebSite = Console.ReadLine();
        Console.WriteLine("Manager Details");
        string FirstName;
        Console.Write("Input first name: ");
        FirstName = Console.ReadLine();
        string LastName;
        Console.Write("Input last name: ");
        LastName = Console.ReadLine();
        byte Age;
        Console.Write("Input age: ");
        while (true)
        {
            string Value = Console.ReadLine();
            byte.TryParse(Value, out Age);
            if (Age > 18 && Age < 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid age number. Try again.");
            }
        }
        int MPhoneNum;
        Console.Write("Input phone number: ");
        while (true)
        {
            string Value = Console.ReadLine();
            int.TryParse(Value, out MPhoneNum);
            if (MPhoneNum > 99999 && MPhoneNum < 10000000)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid phone number. Try again.");
            }
        }
        string CN = "Company Name";     //string names apropriate since
        string CA = "Address";          //values are descriptive enough
        string CPN = "Phone Number";
        string CFN = "Fax Number";
        string CSite = "Web Site";
        string MFN = "First Name";
        string MLN = "Last Name";
        string MA = "Age";
        string MN = "Phone Number";
        Console.WriteLine("Company Details");
        Console.WriteLine("{0, -12}: {1}", CN, Name);
        Console.WriteLine("{0, -12}: {1}", CA, Address);
        Console.WriteLine("{0, -12}: {1}", CPN, PhoneNum);
        Console.WriteLine("{0, -12}: {1}", CFN, FaxNum);
        Console.WriteLine("{0, -12}: {1}", CSite, WebSite);
        Console.WriteLine("{0, -12}: {1}", MFN, FirstName);
        Console.WriteLine("{0, -12}: {1}", MLN, LastName);
        Console.WriteLine("{0, -12}: {1}", MA, Age);
        Console.WriteLine("{0, -12}: {1}", MN, MPhoneNum);
    }
}

