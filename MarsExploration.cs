using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class MarsExploration
    {

        public static int marsExploration(string s)
        {
            int sosCount = s.Length / 3; 
            /*
             * 
              SOS  0 1 2
              SOT  3 4 5
              KOT  6 7 8
              MOT  9 10 11
             */
            int differentLetters = 0;

            for(int i = 0; i < sosCount; i++)
            {
                //get sos strings, compare with sos, increment count
                string substr = s.Substring(i * 3, 3);

                //find difference
                if( substr[0] != 'S' ) differentLetters++;
                if (substr[1] != 'O') differentLetters++;
                if (substr[2] != 'S') differentLetters++;

            }

            return differentLetters;
        }

        public void Run()
        {
            string s = "SOSSOTKOTMOT";

            int result = marsExploration(s);
        }
    

    }
}

