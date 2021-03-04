using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NixonWeek6Lab
{
    //Form Validation class
    public class Validations
    {

        public static bool IsInstagramLinkValid(string temp)
        {
            bool results = true;
            string instagram = "Instagram.com";
            int slshPosition = temp.IndexOf("/");

            if (!temp.Contains(instagram))
            {
                results = false;
            }
            if (!temp.Contains("/"))
            {
                results = false;
            }
            if (slshPosition > temp.Length - 3)
            {
                results = false;
            }

                return results;
        }
        //bad word checker
        public static bool IsThereBadWords(string temp)
        {
            bool results = false;
            string[] fakeBadWords = { "poop", "homework", "class", "fun" };

            foreach (string strWords in fakeBadWords)
            {

                if (temp.Contains(strWords))
                {
                    results = true;
                }

            }

            return results;
        }

        //Method to make sure input is filled in and not blank
        public static bool IsItFilledIn(string temp)
        {
            bool results = false;

            if (temp.Length > 0)
            {
                results = true;
            }

            return results;
        }

        //checks to make sure state abbreviation is 2 characters
        public static bool CorrectStateAbbreviation(string temp)
        {
            bool results = true;

            //if temp length is not equal to 2 return false
            if (temp.Length != 2)
            {
                results = false;
            } else if (!Regex.IsMatch(temp, @"^[a-zA-Z]+$")) {
                results = false;
            }

            return results;
        }

        //Method to validate that an email is valid
        public static bool EmailValidation(string temp)
        {
            bool results = true;

            //Looking for @
            int atPosition = temp.IndexOf("@");
            int nextAtPosition = temp.IndexOf("@", atPosition + 1);

            //Looking for "."
            int periodPosition = temp.LastIndexOf(".");

            //Checking length
            if (temp.Length < 8)
            {
                results = false;

                //If position is less than 2 it is false
            } else if (atPosition < 2)
            {
                results = false;

                //If period position + 2 is greater than length of email returns false
            } else if (periodPosition + 2 > temp.Length)
            {
                results = false;
            }

            return results;
        }

        //Checks to make sure zip code is 5 digits long
        public static bool IsZipCodeValid(string temp)
        {

            var regUSZipCode = @"^\d{5}(?:[-\s]\d{4})?$";

            bool results = true;
            //if temp length is not equal to 5 
            if ((!Regex.Match(temp, regUSZipCode).Success))
            {
                results = false;
            }

            return results;

        }

        //checks if phone num is correct length
        public static bool IsPhoneNumValid(string temp)
        {
            bool results = true;

            // Remove anything that is not a number
            string strPhone = Regex.Replace(temp, @"[^\d]", String.Empty);

            // Check for exactly 10 numbers left over
            if (strPhone.Length != 10)
            {
                results = false;
            }

            return results;
        }
    }
}