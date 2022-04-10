using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MaxMin
    {

        public static int maxMin(int k, List<int> arr)
        {
            int maxMin = Int32.MaxValue;

            int [] array = arr.ToArray();

            Array.Sort(array);
            // get first k elements for 

            

            for(int i = 0; i < array.Length - k + 1; i++)
            {
                 //get the next k elements and calculate

                
                //max of temp array            
                int tempFairness = array[i + k - 1] - array[i];

                if (tempFairness < maxMin)
                    maxMin = tempFairness;
            }

            return maxMin;
        }


        public void Run()
        {
            int k = 3;
            List<int> arr = new List<int>() { 3, 100, 200, 300, 350, 400, 401, 402};

            maxMin(k, arr);

        }


    }
}

