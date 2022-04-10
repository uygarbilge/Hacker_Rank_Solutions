using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankProject
{
    public class Common
    {
        //Factors of a number
        public static List<int> Factor(int number)
        {
            var factors = new List<int>();
            int max = (int)Math.Sqrt(number);  // Round down

            for (int factor = 1; factor <= max; ++factor) // Test from 1 to the square root, or the int below it, inclusive.
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor) // Don't add the square root twice!  Thanks Jon
                        factors.Add(number / factor);
                }
            }
            return factors;
        }


        //counting sort
        public static List<int> CountingSort(int[] Array)
        {
            int n = Array.Length;
            int max = 0;
            //find largest element in the Array
            for (int i = 0; i < n; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }

            //Create a freq array to store number of occurrences of 
            //each unique elements in the given array 
            int[] freq = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                freq[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                freq[Array[i]]++;
            }

            //sort the given array using freq array
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (freq[i] > 0)
                {
                    Array[j] = i;
                    j++;
                    freq[i]--;
                }
            }

            return Array.ToList();
        }


    }
}
