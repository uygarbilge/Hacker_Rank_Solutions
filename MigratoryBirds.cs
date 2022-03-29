using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class MigratoryBirds
    {

        public static int migratoryBirds(List<int> arr)
        {
            Hashtable h = new Hashtable(); 

            for(int i = 0; i < arr.Count; i++)
            {
                if (h.ContainsKey(arr[i]))
                {
                    h[arr[i]] = (int)h[arr[i]] + 1;
                }
                else
                    h[arr[i]] = 1;

            }

            int highValue = 0;
            int lowId = 6;

            foreach(int k in h.Keys)
            {
                if( (int)h[k] > highValue)
                {
                    highValue = (int)h[k]; 
                }
            }

            foreach (int k in h.Keys)
            {
                if ((int)h[k] == highValue)
                {
                    if( k < lowId)
                    {
                        lowId = k;
                    }
                }
            }

                return lowId;
        }



        public void Run()
        {

            List<int> arr  = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, };

            int result = migratoryBirds(arr);

        }

    }
}

