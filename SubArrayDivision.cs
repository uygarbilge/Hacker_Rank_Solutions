using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SubArrayDivision
    {

        public static int birthday(List<int> s, int d, int m)
        {
           // int i = 0;
            //int j = 0;

            int totalWays=0;

            for(int i = 0; i < s.Count; i++)
                for (int j = i + 1; j < s.Count; j++)
                {
                    Console.WriteLine("i=" + s[i] + ", j = " + s[j]);

                    if( j -i + 1 == m) //day match
                    {
                        int sum = 0;
                        for(int a = i; a <= j; a++)
                            sum += s[a];

                        if(sum == d)
                        {
                            totalWays++;
                        }
                    }
                }

   


            return totalWays;
        }

        public void Run()
        {
            List<int> list = new List<int>() { 2, 2, 1, 3, 2 };
            birthday(list, 4, 2);
          
        }
    

    }
}

