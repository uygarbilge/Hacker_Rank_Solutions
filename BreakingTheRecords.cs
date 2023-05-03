using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class BreakingTheRecords 
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> records = new List<int>();

            int min = 0;
            int max = 0;

            int minCount = 0;
            int maxCount = 0;

            int rowCount = records.Count;

            for (int i = 0; i < scores.Count; i++)
            {
                if(i == 0)
                {
                    min = max = scores[i];
                }
                else
                {
                    if (scores[i] < min)
                    {
                        min = scores[i];
                        minCount++;
                    }
                    else if (scores[i] > max)
                    {
                        max = scores[i];
                        maxCount++;
                    }    
                }
            }
             
            records.Add(maxCount);
            records.Add(minCount);

            return records;
        }


        public void Run()
        {
            List<int> scores = new List<int>() { 12, 24, 10, 24}; 
            breakingRecords(scores); 
        }
    }
}
