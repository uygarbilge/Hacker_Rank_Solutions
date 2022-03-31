using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StrongPassword
    {

        public static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong

            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int existingCharacters = 0;
            
            //contains number?
            foreach(char c in numbers)
            {
                if(password.Contains(c))
                {
                    existingCharacters++;
                    break;
                }
            }
            //contains lowercase?
            foreach (char c in lower_case)
            {
                if (password.Contains(c))
                {
                    existingCharacters++;
                    break;
                }
            }

            //contains uppercase?
            foreach (char c in upper_case)
            {
                if (password.Contains(c))
                {
                    existingCharacters++;
                    break;
                }
            }

            //special characters
            foreach (char c in special_characters)
            {
                if (password.Contains(c))
                {
                    existingCharacters++;
                    break;
                }
            }


            int result = 4 - existingCharacters;
            int missingDigit = 6 - password.Length;

            result = Math.Max( result, missingDigit );
             
            return result;

        }




        public void Run()
        {
            string password = "2bbbb";

            minimumNumber(password.Length, password);
        }



    }
}

