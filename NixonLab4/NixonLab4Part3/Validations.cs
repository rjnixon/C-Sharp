using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NixonLab4
{
    public class Validations
    {

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

        //Method to validate that an email is valid
        public static bool EmailValidation(string temp)
        {
            bool results = true;

            //Looking for @
            int atPosition = temp.IndexOf("@");
            //int nextAtPosition = temp.IndexOf("@", atPosition + 1);

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
    }
}