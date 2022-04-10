using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SansaAndXor
    {

        public static int sansaXor(List<int> arr)
        {

        
            // initialize result by 0
            // as (a XOR 0 = a)
            int res = 0;

            // loop over all elements once
            for (int i = 0; i < arr.Count; i++)
            {
                // get the frequency of
                // current element
                int freq = (i + 1) * (arr.Count - i);
 

                // if frequency is odd, then include it in the result
                if (freq % 2 == 1)
                    res = res ^ arr[i];
            }

            // return the result
               return res;
         
         
        }


        public void Run()
        {
            List<int> arr = new List<int>() { 98, 74, 12 };
            sansaXor(arr);
        }
    }
}
