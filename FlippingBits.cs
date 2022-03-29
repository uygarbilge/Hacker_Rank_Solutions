using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class FlippingBits
    {

        public static long flippingBits(long n)
        {
            string s = Convert.ToString(n, 2);

            int zeroCount = 32 - s.Length;

            for (int i = 0; i < zeroCount; i++)
                s = "0" + s;

            Console.WriteLine(s.Length);

            s = s.Replace('0', '2');
            s = s.Replace('1', '0');
            s = s.Replace('2', '1');

            long result = Convert.ToInt64(s, 2);

            return result;
        }

        public void Run()
        {

            int q = 3;                 
            long result = flippingBits(q);

        }

    }
}

