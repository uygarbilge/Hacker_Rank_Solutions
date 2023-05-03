using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class PlusMinus
    { 
        public static void plusMinus(List<int> arr)
        {
            int zeroCount = 0;
            int positiveCount = 0;
            int negativeCount = 0;

            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 6;
          
            foreach (int i in arr)
            {
                if (i >  0) positiveCount++;
                else if (i < 0) negativeCount++;
                else zeroCount++; 
            }

            decimal zeroRatio = 0;
            decimal positiveRatio = 0;
            decimal negativeRatio = 0;

            if (arr.Count > 0)
            {
                zeroRatio = (decimal)zeroCount / arr.Count;
                positiveRatio = (decimal)positiveCount / arr.Count;
                negativeRatio = (decimal)negativeCount / arr.Count;
            }

            Console.WriteLine(positiveRatio.ToString("N", setPrecision));
            Console.WriteLine(negativeRatio.ToString("N", setPrecision));
            Console.WriteLine(zeroRatio.ToString("N", setPrecision)); 
        }

        public void Run()
        { 
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList(); 
            plusMinus(arr);
        } 
    }
}

