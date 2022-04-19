using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WeightedUniformStrings

    {

        public static List<string> weightedUniformStrings(string s, List<int> queries)
        {
            List<string> result = new List<string>();

            List<string> substrings = new List<string>();

            int startIndex = 0;
            int endIndex = 1;

            while(startIndex < s.Length )
            {
                if(startIndex == s.Length - 1)
                    endIndex = s.Length - 1;

                if(s[startIndex] != s[endIndex])
                {
                    substrings.Add(s[startIndex].ToString());

                    startIndex++;
                    endIndex++;
                }

                else // same characters continue
                {
                    int charCount = 0;
                    while( startIndex < s.Length && endIndex < s.Length &&  s[startIndex] == s[endIndex])
                    {
                        endIndex++;
                    }
                    charCount = endIndex - startIndex;

                    string substr = s[startIndex].ToString();
                    for (int i = 1; i <= charCount; i++)
                    {
                        substrings.Add(substr);
                        substr += s[startIndex].ToString();

                    }

                    startIndex = endIndex;
                    endIndex++;

                }
            }

            //calculate weights
            List<int> weights = new List<int>();

            for (int i = 0; i < substrings.Count; i++)
            {
                int w = GetWeight(substrings[i]);

                weights.Add(w);
            }

            //final check
            for(int i = 0; i < queries.Count; i++)
            {
                if (weights.Contains(queries[i]))
                {
                    result.Add("Yes");
                }
                else
                    result.Add("No");

            }
             

            return result;
        }


        public static int GetWeight (string s)
        {
            //char a = 'a';  //97
            //char z = 'z'; //122

            int sum = 0;


            int charWeight = s.ElementAt(0) - 96;

            return charWeight * s.Length;

        }

        public void Run()
        { 
            string s = "abccddde";

            List<int> queries = new List<int>() { 1, 3 ,12, 9, 5, 10};

            weightedUniformStrings(s, queries);
        }
    }
}
