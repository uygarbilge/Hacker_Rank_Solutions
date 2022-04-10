using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SherlockAndArray
    {

        public static string balancedSums(List<int> arr)
        {

            if (arr.Count == 1)
                return "YES";


            //find the total sum first
            int totalSum = 0;
            foreach (int i in arr)
                totalSum += i;

            int leftSide = 0;
            int rightSide = totalSum;  

            //start from 
            for(int i = 0; i < arr.Count; i++)
            {
                //sum of left part is = totalSum - left part

                if (i == 0)
                    leftSide = 0;
                else
                    leftSide += arr[i - 1];
                 
                rightSide = totalSum - leftSide;

                if (leftSide == (rightSide - arr[i]))
                    return "YES";
            }

            //not found
            return "NO";
        }

        public void Run()
        {
            List<int> arr = new List<int> { 2, 0, 0, 0};
            balancedSums(arr);

        }


    }
}


