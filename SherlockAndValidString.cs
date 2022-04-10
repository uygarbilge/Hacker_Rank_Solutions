using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class SherlockAndValidString
    {
        public string isValid(string s)
        {

            Hashtable h = new Hashtable();
            List<int> list = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                 
                    if (!(h.ContainsKey(s[i])))
                        h.Add(s[i], 1);
                    else
                        h[s[i]] = (int)h[s[i]] + 1;
                 
            }


            int[] array = new int[h.Count];

            h.Values.CopyTo(array, 0);

            Array.Sort(array);
             

            //if all characters appear the same time, return YES
            if (checkArray(array, 0, array.Length))
                return "YES";
  
                
            //Either first value must be 1 and all others must be equal ( like "abbccdd", "ffzgg" )

            if(array[0] == 1)
            {
                 
                if ( checkArray(array, 1, array.Length) )
                    return "YES"; 
               
            }


            //Or first n-1 values must be same and the last one is one more than the others ( like "aaabbbcccc" or "ddeefff" ) 
            if (checkArray(array, 0 , array.Length - 1) && array[array.Length - 1] - array[array.Length - 2] == 1)
                return "YES";


            return "NO";

        }

        //startIndex and EndIndex is included in the search
        public bool checkArray( int [] array, int startIndex, int endIndex) 
        { 

            for (int i = startIndex; i < endIndex - 1; i++)
                if (array[i] != array[i + 1]) 
                    return false;

             return true; 
        }
  


        public void Run()
        {
            string s = "aabbccdddd";

            isValid(s);

        }

    }
}

