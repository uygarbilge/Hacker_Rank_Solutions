using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SumVsXor
    {
        //TIME LIMIT EXCEEDED

        public static long sumXor(long n)
        {
            long result = 0; 

            for(int i = 0; i <= n; i++)
            {
                if ( (n + i) == (n ^ i))
                    result++;
            }

            return result;
        }


        public void Run()
        {
           long n = Convert.ToInt64(Console.ReadLine().Trim());
           sumXor(n);
        }

    }
}

