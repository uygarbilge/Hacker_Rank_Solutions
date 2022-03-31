using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CaesarCipher
    {
        public static string caesarCipher(string s, int k)
        {
            string  result = string.Empty;

            char A = 'A'; //65
            char Z = 'Z'; // 90

            char a = 'a';  //97
            char z = 'z'; //122

            for(int i = 0; i < s.Length; i++)
            { 

                int letter = s[i];

                if( (letter >= 65 && letter <= 90))
                {
                    int newLetter = 0;
                    newLetter = letter + k;
                    while(newLetter > 90)
                    {
                        newLetter = newLetter - Z - 1 + A; 
                     }
                    char newChar = (char)newLetter;
                     result = result + newChar.ToString();

                }
                else if (letter >= 97 && letter <= 122)
                {

                    int newLetter = 0;
                    newLetter = letter + k;
                    while (newLetter > 122)
                    {
                        newLetter = newLetter - z - 1 + a; 
                    }
                    char newChar = (char)newLetter;
                    result = result + newChar.ToString();
                }
                else
                {
                    result = result + s[i].ToString();
                }
            } 

            return result;
        }


        public void Run()
        {
            string s = "159357lcfd";
            int k = 98;
            caesarCipher(s, k);
        }
    }
}
