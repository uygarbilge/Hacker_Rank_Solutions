using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountingValleys
    {

        public static int countingValleys(int steps, string path)
        {

            
            int currentLevel = 0; //begin with sea level

            int totalValleys = 0;

            for(int i = 0; i < steps; i++)
            {
                char c = path[i];

                if(c  == 'D')
                {
                    if( currentLevel == 0 )
                    {
                        totalValleys++;
                    }
                    currentLevel--;
                }
                else if (c == 'U')
                {
                    
                    currentLevel++;
                }


            }

            return totalValleys;
        }



        public void Run()
        {


            string path = "DDUUUUDDDDUU";
            countingValleys(path.Length, path);

        }


    }
}

