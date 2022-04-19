using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperReducedString
    {
        public static string superReducedString(string s)
        {
             
            int index = 0;
            int i = 0;

            while (i < s.Length - 1)
            {
                if (s[i] == s[i + 1])
                {
                    index = i;
                     

                    if (index < s.Length - 1 && s[index] == s[index + 1])
                    {
                        s = s.Remove(i, 2);
                        i = 0;
                    }
                   
                }
                else
                    i++;
            }

            if (s == string.Empty)
                return "Empty String";

            return s;
        }

        public string RemoveSubString(string s, int startIndex, int count)
        {
            string subString = s.Remove(startIndex, count);
            return subString;
        }


        public void Run()
        {

            string s = "aaabccddd";
            superReducedString(s);

        }

    }

    public class SubStringToBeRemoved
    {
        public int startIndex { get; set; }
        public int endIndex { get; set; }
    }
}

