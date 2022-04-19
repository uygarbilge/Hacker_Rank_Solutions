using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TwoCharacters 
    {

        public static int alternate2(string s)
        {
            //find all DISTINCT characters in the string
            HashSet<char> chars = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                chars.Add(s[i]);
            }

            string searchString = string.Empty;


        }

        public static int alternate(string s)
        {
            int result = 0;

            //find all DISTINCT characters in the string
            HashSet<char> chars = new HashSet<char>();
            for(int i = 0; i< s.Length; i++)
            {
                chars.Add(s[i]);
            }

            int longest = 0;

            //remove each character and test if string is alternating
            foreach(char c in chars)
            {
                string newString = removeACharacter(s, c);
                //test if it is valid 
                if(IsValidAlternating(newString) > 0)
                {
                    if(newString.Length > longest)
                        longest = newString.Length;
                }
                else
                {
                   
                    int subLongest = alternate(newString);
                    if (subLongest > longest)
                        longest = subLongest;
                }
            }


            return longest;
        }

        
        //returns length of valid string, returns -1 if not valid
        public static int IsValidAlternating( string s)
        {

            if(s.Length == 1)
                return -1;

            else if (s.Length == 2 && s[0] != s[1])
                return 2;
            else if (s.Length == 2 && s[0] == s[1])
            {
                return -1;
            }

            else if ( s.Length > 2 )
            {
                if( s[0] == s[2] && s[0] != s[1])
                {
                    char first = s[0];
                    char second = s[1];

                    int i = 0;
                    while (i < s.Length)
                    {
                        if( i % 2  == 0  && s[i] != first) return -1;
                        if (i % 2 == 1 && s[i] != second) return -1;

                        i++;

                    }

                    return s.Length;
                }

                 
            }
            return -1;
          
        }

        public static string removeACharacter( string s, char c)
        {

            char[] chars = s.ToCharArray();

            List<char> list = new List<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i] != c)
                    list.Add(chars[i]);

            }

            string result = string.Empty;

            for (int i = 0; i < list.Count; i++)
                result = result + list[i];

            return result;
        }

        public void Run()
        {
            // string removeTest = removeACharacter("afdafcgya", 'a');

            // bool abc = IsValidAlternating("abababab");

            string s = "asdcbsdcagfsdbgdfanfghbsfdab";

            int result =   alternate(s);   
        }
    }
}
