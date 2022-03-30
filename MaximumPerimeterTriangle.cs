using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MaximumPerimeterTriangle
    {
        public static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            List<int> result = new List<int>();

            int [] array = sticks.ToArray();

            //Array.Sort(array);
            //Array.Reverse(array);

            long maxPerimeter = -1;
            int longestSide = 0;


            for(int i = 0; i < array.Length; i++)
                for(int j = i+1; j < array.Length; j++)
                    for(int k = j+1; k < array.Length; k++)
                    {
                        if(array[i] + array[j] > array[k] &&
                            array[i] + array[k] > array[j] &&
                            array[j] + array[k] > array[i])
                        {
                            long perim = (long)array[i] + array[j] + array[k];
                            if(perim > maxPerimeter)
                            {
                                result.Clear();
                                result.Add( array[i]);
                                result.Add(array[j]);
                                result.Add(array[k]);

                                longestSide = result.Max();

                                maxPerimeter = perim;
                            }
                            else if( perim == maxPerimeter )
                            {
                                int max = result.Max();
                                if(  max >  longestSide )
                                {
                                    result.Clear();
                                    result.Add(array[i]);
                                    result.Add(array[j]);
                                    result.Add(array[k]);

                                    longestSide = max;
                                }
                            }
                                
                        }

                    }
            result.Sort();

            if (result.Count == 0)
                result.Add(-1);

            return result;
        }

        public void Run()
        {
            List<int> sticks = new List<int>() { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 };
            maximumPerimeterTriangle(sticks);
        }
    }
}
