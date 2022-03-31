using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Pangrams
    {


        public static string pangrams(string s)
        { 
            char A = 'A';
            char Z = 'Z';

            char a = 'a';
            char z = 'z';

            int diff = A - a;

            bool panagram = true;

            for(int i = A; i <= Z; i++)
            {
                char cLittle = Convert.ToChar(i);
                char cBig = Convert.ToChar(i + 32);

                if(!s.Contains(cLittle) && !s.Contains(cBig) )
                {
                    panagram = false;
                    break;
                }
            }

            if (panagram) return "pangram";
            else return "not pangram";
            
        }

        public void Run()
        {

            string s = "The quick brown fox jumps over the lazy Dog";

            string result = pangrams(s);

        }

    }
}

