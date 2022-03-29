using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GradingStudents

    {

        public static List<int> gradingStudents(List<int> grades)
        {

            List<int> result = new List<int>();

            foreach (int grade in grades)
            {
                int roundedGrade = 0;


                if (grade < 38)
                {
                    roundedGrade = grade;
                }
                else if ( ( 5 - (grade % 5) < 3) && ( 5 - (grade % 5) != 0))
                {
                    roundedGrade = grade + 5 - (grade % 5);
                }
                else if ((5 - (grade % 5) >= 3) && (5 - (grade % 5) != 0))
                {
                    roundedGrade = grade;
                }
                else if (grade % 5 == 0)
                {
                    roundedGrade = grade;
                }

                result.Add(roundedGrade);
            }

            return result;
        }

        public void Run()
        {
            List<int> grades = new List<int>() { 0, 30, 38, 40, 71, 72, 73, 74, 75, 95, 96, 97, 98, 99, 100 };
            gradingStudents(grades);
        }
    }
}
