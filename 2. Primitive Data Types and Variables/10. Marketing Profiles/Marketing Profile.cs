//A marketing firm wants to keep record of its employees. Each record 
//would have the following characteristics – first name, family name, age, 
//gender (m or f), ID number, unique employee number (27560000 to 
//27569999). Declare the variables needed to keep the information for a 
//single employee using appropriate data types and descriptive names.

using System;

class Profile
{
    static void Main()      //realised the program was not what was asked of us some time after it was complete so I left it like that
    {
        Console.Title = "Please enter your details.";
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();      
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        byte age;
        while (true)
        {
            age = byte.Parse(Console.ReadLine());
            if (age <= 70)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid value. Try again: ");
            }
        }
        string sex;
        Console.Write("Sex(f/m): ");
        sex = Console.ReadLine();
        bool genderCheck = (sex == "f");
        if (genderCheck == true)
        {
            sex = "Female";
        }
        else
        {
            sex = "Male";
        }
        Console.Write("ID Number: 2756");
        ushort idNumber;
        while (true)
        {
            idNumber = ushort.Parse(Console.ReadLine());
            if (idNumber <= 9999)
            {
                if (idNumber > 999)     //could not find a way to do this with one cycle
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid ID Number value. Try again: 2756");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID Number value. Try again: 2756");
            }
        }
        Console.WriteLine(" Name: {0} {1}\n Age: {2}\n Sex: {3}\n ID Number: 2756{4}", firstName, lastName, age, sex, idNumber);
    }
}