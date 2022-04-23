using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Waiter
    {

        public static List<int> waiter(List<int> number, int q)
        {
            List<int> answers = new List<int>();

            List<int> A = new List<int>();
            List<int> B = new List<int>();

            Stack<int> numberStack = new Stack<int>();

            foreach (int i in number)
                numberStack.Push(i);


            //iterate q times
            int primeIndex = 1;

            for(int i = primeIndex; i <= q; i++)
            {

                //if it is the first prime, insert from numbers array
                if(i == 1)
                {
                    int prime = 2;

                    while(numberStack.Count > 0)
                    {
                        int topNumber = numberStack.Pop();

                        if (topNumber % prime == 0)
                            B.Add(topNumber);
                        else
                            A.Add(topNumber);
                    }

                    foreach (int j in A)
                        Console.Write(j + ", ");

                    //move B elements to answers
                    for(int b = B.Count - 1; b >= 0; b--)
                        answers.Add(B[b]);

                    foreach (int j in answers)
                        Console.Write(j + ". ");

                    B.Clear();
                        
                }
                else // i > 1
                {
                    int prime = GetNthPrime(i);

                    List<int> indexesToRemoveFromA = new List<int>();   

                    for(int a = A.Count - 1; a >= 0 ; a--)
                    {
                        int topANumber = A[a];
                        if (topANumber % prime == 0)
                        {
                            B.Add(topANumber);
                            //A.RemoveAt(a);
                            indexesToRemoveFromA.Add(a);
                        }
                       
                    }

                    foreach(int index in indexesToRemoveFromA)
                        A.RemoveAt(index);

                    //move B elements to answers
                    for (int b = B.Count - 1; b >= 0; b--)
                        answers.Add(B[b]);
                    B.Clear();
                }
  

            }

            //remove all remaining elements in A to answers
            for(int i = A.Count - 1; i >= 0; i--)
                answers.Add(A[i]);
             

            return answers;
        }

        public static int GetNthPrime(int rangenumber)
        {
            int  c = 0, num = 2, i, letest = 0;
            

            while (c != rangenumber)
            {
                int count = 0;
                for (i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    c++;
                    letest = num;
                }
                num = num + 1;
            }

            return letest;
        }

        public void Run()
        {
            

            List<int> a = new() { 80, 37, 86, 79, 8, 39, 43, 41, 15, 33, 30, 15, 45, 55, 61, 74, 49, 49, 20, 66, 77, 19, 85, 44, 81, 82, 27, 5, 36, 83, 91, 45, 39, 44, 19, 44, 71, 49, 8, 66, 81, 40, 29, 60, 35, 31, 44 } ;
            int q = 21;
            waiter(a, q);

        }
    

    }
}

