using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DynamicArray
    {

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            int lastAnswer = 0;
            List<int> answers = new List<int>();

             

            return answers;
        }


        public void Run()
        {
            int n = 2;


            List<List<int>> queries = new List<List<int>>();

            queries.Add(new List<int>() { 1, 0, 5 });
            queries.Add(new List<int>() { 1, 1, 7 });
            queries.Add(new List<int>() { 1, 0, 3 });
            queries.Add(new List<int>() { 2, 1, 0 });
            queries.Add(new List<int>() { 2, 1, 1 });

            dynamicArray(n, queries);
        }


    }
}


