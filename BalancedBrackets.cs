using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class BalancedBrackets
    {

        public static string isBalanced(string s)
        {
            bool isBalanced = true;

            Stack<char> stack = new Stack<char>();
 
             
            
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }

                else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if(stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    if( s[i] == ')' && stack.Peek() != '(' ||
                        s[i] == ']' && stack.Peek() != '[' ||
                        s[i] == '}' && stack.Peek() != '{' )
                    {
                        isBalanced = false;
                        break;
                    }
                    else
                        stack.Pop();
                } 

            }

            if (stack.Count != 0)
                isBalanced = false;

            return isBalanced ? "YES" : "NO";
        }




        public void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }

        }

    }
}

