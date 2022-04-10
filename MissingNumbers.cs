using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MissingNumbers
    {

        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {

            List<int> result = new List<int>();

            int [] a = arr.ToArray();
            int [] b = brr.ToArray();

            Array.Sort(a);
            Array.Sort(b);

            Hashtable atable = new Hashtable();
            Hashtable btable = new Hashtable();

            for (int i = 0; i < a.Length; i++)
            {
                int num = arr[i];
                if (atable.ContainsKey(num))
                    atable[num] = (int)(atable[num]) + 1;
                else
                    atable.Add(num, 1);
            }

            for (int i = 0; i < b.Length; i++)
            {
                int num = brr[i];
                if (btable.ContainsKey(num))
                    btable[num] = (int)(btable[num]) + 1;
                else
                    btable.Add(num, 1);
            }
             
            //start comparing
            for(int i = 0; i < b.Length; i++)
            {
                int hashbTimes = (int)btable[b[i]];

               if(atable.ContainsKey(b[i]))
                {
                    int hashATimes = (int)atable[b[i]];

                    if (hashbTimes > hashATimes)
                    {
                        if(!result.Contains(b[i]))
                            result.Add(b[i]);

                    }
                        
                }
                else
                {
                    if (!result.Contains(b[i]))
                        result.Add(b[i]);
                    //add it to the list

                }

            }
            
            //if it does not exist that many times in b, 
            

            return result;
        }


        public void Run()
        {
            List<int> arr = new List<int> { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            List<int> brr = new List<int> { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204, };

            missingNumbers(arr, brr);   


        }
    }
}


