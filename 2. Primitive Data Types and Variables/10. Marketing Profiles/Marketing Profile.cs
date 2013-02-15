using System;

class Profile
{
    static void Main()      //realised the program was not what was asked of us some time after it was complete so I left it like that
    {
        Console.Title = "Please enter your details.";
        Console.Write("First Name: ");
        string FirstName = Console.ReadLine();      
        Console.Write("Last Name: ");
        string LastName = Console.ReadLine();
        Console.Write("Age: ");
        byte Age;
        while (true)
        {
            Age = byte.Parse(Console.ReadLine());
            if (Age <= 70)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid value. Try again: ");
            }
        }
        string Sex;
        Console.Write("Sex(f/m): ");
        Sex = Console.ReadLine();
        bool GenderCheck = (Sex == "f");
        if (GenderCheck == true)
        {
            Sex = "Female";
        }
        else
        {
            Sex = "Male";
        }
        Console.Write("ID Number: 2756");
        ushort IDNumber;
        while (true)
        {
            IDNumber = ushort.Parse(Console.ReadLine());
            if (IDNumber <= 9999)
            {
                if (IDNumber > 999)     //could not find a way to do this with one cycle
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
        Console.WriteLine(" Name: {0} {1}\n Age: {2}\n Sex: {3}\n ID Number: 2756{4}", FirstName, LastName, Age, Sex, IDNumber);
    }
}