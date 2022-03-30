using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class PickingNumbers
    {

        public static int pickingNumbers(List<int> a)
        {

            int result = 0; 
            a.Sort();

            int tempLength = 1;

            for (int i = 0; i < a.Count; i++)
            {
                for(int j = i +1; j < a.Count; j++)
                {
                   
                    
                    if(Math.Abs(a[j] - a[i]) < 2)
                    {
                        tempLength++;
                    }

                  
                }
                if (tempLength > result)
                {
                    result = tempLength;
                }
                tempLength = 1;
            }

            return result;
        }

        public void Run()
        { 

            List<int> arr =  new List<int> { 1, 1, 2, 2, 4, 4, 5, 5,5 };

            pickingNumbers(arr);
        }

    }
}

