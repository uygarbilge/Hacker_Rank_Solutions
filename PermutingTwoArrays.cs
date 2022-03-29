using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PermutingTwoArrays
    {

        public string twoArrays(int k, List<int> A, List<int> B)
        {
            bool result = true;

            int [] a = A.ToArray();
            int [] b = B.ToArray();

             
            Array.Sort(a);

            Array.Sort(b);
            Array.Reverse(b);


            for (int i = 0; i < a.Length; i++)
                if (a[i] + b[i] < k)
                {
                    result = false;
                }
                     

            if (result)
                return "YES";
            else
                return "NO";
        }

         

        public void Run()
        {


            int k = 13;

            List<int> A = new List<int>() { 1, 2, 6 };

            List<int> B = new List<int>() { 3, 2, 7 };

            string result = twoArrays(k, A, B);

            Console.WriteLine(result);


        }


    }
}

