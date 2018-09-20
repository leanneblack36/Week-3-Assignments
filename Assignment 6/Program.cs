using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter Score

            Console.Write("Enter score: ");
            string input1 = Console.ReadLine();
            int points = int.Parse(input1);

            // Grade ‘A’, ‘B’ and ‘C’ represents a pass and the student has successfully completed the course.
            //Enter the score and state which letter a student will be given as output.
            //In addition, state whether or not the student has passed the subject.
            // A = 90 - 100 points
            // B = 80 - 89 points
            // C = 70 - 79 points(or CR)
            // D = 60 - 69 points
            //   F = fewer than 60 points


            //Show grade and if pass or fail//

            string grade = "A";
            string passed = "course passed";

            if (points < 90)
            {
                grade = "B";
            }
            if (points < 80)
            {
                grade = "C";
            }
            if (points < 70)
            {
                grade = "D";
                passed = "course not passed";
            if (points < 60)
            {
                grade = "F";
            passed = "course not passed";
            }
        }
            Console.WriteLine("Grade:{0} ", grade);
            Console.WriteLine(passed);
            Console.ReadKey();

        }
    }
}
