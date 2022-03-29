using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SparseArray
    {

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();

            Hashtable hashTable = new();

            foreach (string s in strings)
            {
                if (!hashTable.ContainsKey(s))
                {
                    hashTable.Add(s, 1);
                }
                else //contains
                {
                    int val = (int)hashTable[s];
                    hashTable[s] = val + 1;
                }
            }

            foreach(string s in queries)
            {
                int occur = 0;

                if(hashTable.ContainsKey(s))
                {
                    occur = (int)hashTable[s];
                }

                result.Add(occur);
            }

            return result;
        }

        public void Run()
        {

            List<string> strings = new List<string>() { "ab", "ab", "abc" };

            List<string> queries = new List<string>() { "ab", "abc", "bc" };




            List<int> res = matchingStrings(strings, queries);

          
        }
    

    }
}

