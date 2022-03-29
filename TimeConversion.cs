using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class TimeConversion
    {

        public static string timeConversion(string s)
        {
              
            DateTime d = DateTime.Parse(s); 
            string result = d.ToString("HH:mm:ss"); 

            return result;
        }

        public void Run()
        {
             
            string s = "07:05:45PM";

            string result = timeConversion(s); 
         
        }

    }
}

