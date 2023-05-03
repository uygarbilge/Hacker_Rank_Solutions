using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class mini_max_sum
    { 
        void miniMaxSum(List<int> arr)
        {
            long maxSum = 0L;
            long minSum = 0L;

            int [] array = arr.ToArray();

            Array.Sort(array);

            minSum = (long)array[0] + (long)array[1] + (long)array[2] + (long)array[3];
            maxSum = (long)array[1] + (long)array[2] + (long)array[3] + (long)array[4];

            Console.WriteLine(minSum + " " + maxSum); 
        }

        public void Run()
        { 
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList(); 
            miniMaxSum(arr); ;
        }
    }
}
