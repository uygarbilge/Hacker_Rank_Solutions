using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class CountingSort
    {

        public static List<int> countingSort(List<int> arr)
        {

            
            int[] temp = arr.ToArray();

        

            int[] result = new int[100];


            Hashtable hashTable = new();

            foreach (int s in arr)
            {
                if (!hashTable.ContainsKey(s))
                {
                    hashTable.Add(s, 1);
                }
                else //contains
                {
                    hashTable[s] = (int)hashTable[s] + 1;
                    
                }
            }

            foreach(int key in hashTable.Keys)
            {
                result[key] = (int)hashTable[key];
            }

            return result.ToList<int>();  
        }

        public void Run()
        {

            List<int> arr = new() { 1, 1, 3, 2, 1 };

            List<int> result = countingSort(arr);

        }
    

    }
}

