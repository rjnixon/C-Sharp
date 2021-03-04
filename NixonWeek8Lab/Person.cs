using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NixonWeek6Lab
{
    //Person Class
    class Person { 
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
        private string feedback = "";

        public string Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
            }
        }
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
                if (!Validations.IsThereBadWords(value))
                {
                    fName = value;
                }
                else
                {
                    Feedback += "\nERROR:" + "First Name contains bad words.";
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
                if (!Validations.IsThereBadWords(value))
                {
                    mName = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "Middle Name contains bad words.";
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
                if (!Validations.IsThereBadWords(value))
                {
                    lName = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "Last Name contains bad words.";
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
                if (!Validations.IsThereBadWords(value))
                {
                    street1 = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "Street 1 contains bad words.";
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
                if (!Validations.IsThereBadWords(value))
                {
                    street2 = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "Street 2 contains bad words.";
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
                if (!Validations.IsThereBadWords(value))
                {
                    city = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "City contains bad words.";
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
                if (Validations.CorrectStateAbbreviation(value))
                {
                    state = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "State abbreviation is Incorrect";
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
                if (Validations.IsZipCodeValid(value))
                {
                    zipCode = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "Zip code is incorrect";
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
                if (Validations.IsPhoneNumValid(value))
                {
                    phoneNum = value;
                }
                else
                {
                    Feedback += "\nERROR: " + "Home Phone # is incorrect";
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
                }
                else
                {
                    Feedback += "\nERROR: " + "Email is incorrect.";
                }
            }
        }

        //Constructor
        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            street1 = "";
            street2 = "";
            city = "";
            state = "";
            zipCode = "";
            phoneNum = "";
            email = "";
            feedback = "";
        }
    }
}
