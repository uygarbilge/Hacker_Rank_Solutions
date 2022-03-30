using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SeperateTheNumbers
    {

        public static void separateNumbers(string s)
        {
            //s is max 32 characters

            if(s.Length == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            bool found = false;

            //i is starting digit number: start searching with 1 digit
            //
            int charIndex = 0;

           

            for(int i = 1; i <= s.Length / 2; i++)
            {
                 bool b = calculate(i, s); 
                if(b)
                {
                    found = true;
                  
                    Console.WriteLine("YES " +  s.Substring(0, i));
                    break;

                }
            }

            if (!found)
                Console.WriteLine("NO");
        }

        public  static bool calculate( int digitCount, string s)
        {
            bool result = true;

            int index = 0;
          
            string nextString = string.Empty;

            long number = Int64.Parse( s.Substring(index, digitCount));
            
            long nextNumber = 0;

            

            while (index + nextString.Length < s.Length-1 && result)
            {
              
                //next number searched for
                nextNumber = number + 1; 

                //next string searched for
                nextString = nextNumber.ToString();
                int nextStringSize = nextString.Length; 

                index = index + number.ToString().Length;

                //if next substring overflows string, return false
                if (index + nextStringSize > s.Length)
                    return false;

                // check if the next substring is equal to the nextNumber
                if(s.Substring(index, nextStringSize) == nextString)
                {
                    number = nextNumber;
                    //do nothing
                }
                else // the string is not beautiful
                {
                    result = false;
                }
               
            }

            return result;
        }

        public void Run()
        {
            string s = "55555555555555555555555555555555";
            separateNumbers(s);
        }

    }
}

