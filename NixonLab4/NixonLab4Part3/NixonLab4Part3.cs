using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NixonLab4
{
    class NixonLab4Part2
    {
        //Initializing Person Class
        public class Person
        {
            //Changed all string to private and Initialized
            private string fName;
            private string mName;
            private string lName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zipCode;
            private string phoneNum;
            private string email;

            public string FName
            {
                //Returns value of variable
                get
                {
                    return fName;
                }

                //Assigns value to fName
                set
                {
                    //If input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        fName = value;
                    }
                    else
                    { //If nothing is inputted
                        fName = "No input...";
                    }
                }
            }

            public string MName
            {
                //Returns value of variable
                get
                {
                    return mName;
                }

                //Assigns value to mName
                set
                {
                    //If input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        mName = value;
                    }
                    else
                    {
                        //if nothing is inputted
                        mName = "No input...";
                    }
                }
            }

            public string LName
            {
                //Returns value of variable
                get
                {
                    return lName;
                }

                //Assigns value to lName
                set
                {
                    //If input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        lName = value;
                    }
                    else
                    {
                        //if nothing is inputted
                        lName = "No input...";
                    }
                }
            }

            public string Street1
            {
                //Returns value of variable
                get
                {
                    return street1;
                }

                //Assigns value to street1
                set
                {
                    //If input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        street1 = value;
                    }
                    else
                    {
                        //if nothing is inputted
                        street1 = "No input...";
                    }
                }
            }

            public string Street2
            {
                //Returns value of variable
                get
                {
                    return street2;
                }

                //Assigns value to street2
                set
                {
                    //If input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        street2 = value;
                    }
                    else
                    {
                        //if nothing is inputted
                        street2 = "No input...";
                    }
                }
            }

            public string City
            {
                //Returns value of variable
                get
                {
                    return city;
                }

                //Assigns value to city
                set
                {
                    //if input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        city = value;
                    }
                    else
                    {
                        //if nothing is inputted
                        city = "No input...";
                    }
                }
            }

            public string State
            {
                //Returns value of variable
                get
                {
                    return state;
                }

                //Assigns value to state
                set
                {
                    //if input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        state = value;
                    }
                    else
                    {
                        //if nothing is inputted
                        state = "No input...";
                    }
                }
            }

            public string ZipCode
            {
                //Returns value of variable
                get
                {
                    return zipCode;
                }

                //Assigns value to state
                set
                {
                    //If input is filled in value is assigned
                    if (Validations.IsItFilledIn(value))
                    {
                        zipCode = value;
                    }
                    else
                    {
                        //If nothing is inputted
                        zipCode = "No input...";
                    }
                }
            }

            public string PhoneNum
            {
                //Returns value of variable
                get
                {
                    return phoneNum;
                }

                //Assigns value to phoneNum
                set
                {
                    //If input is filled in value is assigned
                    if(Validations.IsItFilledIn(value))
                    {
                        phoneNum = value;
                    } else
                    {
                        //If nothing is inputted
                        phoneNum = "No input...";
                    }
                    
                }
            }

            public string Email
            {
                //Returns value of variable
                get
                {
                    return email;
                }

                //Assigns value to email if it is valid
                set
                {
                    //Calling validator to make sure email is valid
                    if (Validations.EmailValidation(value))
                    {
                        //if email is valid it is assigned to email
                        email = value;

                        //If email is not valid returns "Invalid email" as value
                    } else {
                        email = "Invalid Email...";
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Establishing new variable for structure
            Person temp = new Person();

            //Prompting for first name
            Console.Write("\nEnter your First Name: ");
            temp.FName = Console.ReadLine();

            //Prompting for middle name
            Console.Write("\nEnter your Middle Name: ");
            temp.MName = Console.ReadLine();

            //Prompting for last name
            Console.Write("\nEnter your Last Name: ");
            temp.LName = Console.ReadLine();

            //Prompting for street 1
            Console.Write("\nEnter Street 1: ");
            temp.Street1 = Console.ReadLine();

            //Prompting for street 2
            Console.Write("\nEnter Street 2: ");
            temp.Street2 = Console.ReadLine();

            //Prompting for City
            Console.Write("\nEnter your City: ");
            temp.City = Console.ReadLine();

            //Prompting for state
            Console.Write("\nEnter your State: ");
            temp.State = Console.ReadLine();

            //Prompting for zip code
            Console.Write("\nEnter your Zip Code: ");
            temp.ZipCode = Console.ReadLine();

            //prompting for phone number
            Console.Write("\nEnter your Phone Number: ");
            temp.PhoneNum = Console.ReadLine();

            //prompting for email
            Console.Write("\nEnter your Email: ");
            temp.Email = Console.ReadLine();

            //Cannot assign to private fName has to be assigned to public FName
            temp.FName += "Poopy";

            //Displaying all values inputted
            Console.Write($"\nFirst Name: {temp.FName}");
            Console.Write($"\nMiddle Name: {temp.MName}");
            Console.Write($"\nLast Name: {temp.LName}");
            Console.Write($"\nStreet 1: {temp.Street1}");
            Console.Write($"\nStreet 2: {temp.Street2}");
            Console.Write($"\nCity: {temp.City}");
            Console.Write($"\nState: {temp.State}");
            Console.Write($"\nZip Code: {temp.ZipCode}");
            Console.Write($"\nPhone #: {temp.PhoneNum}");
            Console.Write($"\nEmail: {temp.Email}");

            //Pauses program
            Console.ReadKey();
        }
    }
}