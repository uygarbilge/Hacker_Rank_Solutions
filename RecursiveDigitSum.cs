using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class RecursiveDigitSum
    {

        public static int superDigit(string n, int k)
        {
            int result = 0;

            int calc = Calculate(n);

            result = Calculate( (calc * k).ToString());

            return result;
        }

        public static int Calculate(string n)
        {
            if(n.Length == 1)
                return Int32.Parse(n);

            int sum = 0;
            foreach (char c in n)
                sum += Calculate(c.ToString());

            return Calculate(sum.ToString());
        }

        public void Run()
        {



            string n = "9875";

            int k = 4;

            int result = superDigit(n, k);

        }

    }
}

