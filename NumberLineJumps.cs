using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class NumberLineJumps
    {

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
           
            if( v1 <= v2)
            {
                return "NO";
            }
             
            int velocityDiff = v1 - v2;
            int distance = x2 - x1;

            if ( distance % velocityDiff == 0)
                return "YES";

            return "NO";
       
        }

        public void Run()
        {

            kangaroo(10, 4, 32, 2);
        }

    }
}

