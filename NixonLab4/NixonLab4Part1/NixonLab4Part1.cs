using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NixonLab4
{
    class Program
    {
        //Initializing Person Structure
        struct Person
        {
            //Initializing variables
            public string fName;
            public string mName;
            public string lName;
            public string street1;
            public string street2;
            public string city;
            public string state;
            public string zipCode;
            public string phoneNum;
            public string email;
        }

        
        static void Main(string[] args)
        {
            //Establishing new variable for structure
            Person temp = new Person();

            //Prompting for first name
            Console.Write("\nEnter your First Name: ");
            temp.fName = Console.ReadLine();

            //Prompting for middle name
            Console.Write("\nEnter your Middle Name: ");
            temp.mName = Console.ReadLine();

            //Prompting for last name
            Console.Write("\nEnter your Last Name: ");
            temp.lName = Console.ReadLine();

            //Prompting for street 1
            Console.Write("\nEnter Street 1: ");
            temp.street1 = Console.ReadLine();

            //Prompting for street 2
            Console.Write("\nEnter Street 2: ");
            temp.street2 = Console.ReadLine();

            //Prompting for City
            Console.Write("\nEnter your City: ");
            temp.city = Console.ReadLine();

            //Prompting for state
            Console.Write("\nEnter your State: ");
            temp.state = Console.ReadLine();

            //Prompting for zip code
            Console.Write("\nEnter your Zip Code: ");
            temp.zipCode = Console.ReadLine();

            //prompting for phone number
            Console.Write("\nEnter your Phone Number: ");
            temp.phoneNum = Console.ReadLine();

            //prompting for email
            Console.Write("\nEnter your Email: ");
            temp.email = Console.ReadLine();

            //Displaying all values inputted
            Console.Write($"\nFirst Name: {temp.fName}");
            Console.Write($"\nMiddle Name: {temp.mName}");
            Console.Write($"\nLast Name: {temp.lName}");
            Console.Write($"\nStreet 1: {temp.street1}");
            Console.Write($"\nStreet 2: {temp.street2}");
            Console.Write($"\nCity: {temp.city}");
            Console.Write($"\nState: {temp.state}");
            Console.Write($"\nZip Code: {temp.zipCode}");
            Console.Write($"\nPhone #: {temp.phoneNum}");
            Console.Write($"\nEmail: {temp.email}");

            //Pauses program
            Console.ReadKey();
        }
    }
}
