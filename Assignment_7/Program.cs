using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eneter weight, height and gender//
            Console.Write("Enter weight (kg): ");
            string input1 = Console.ReadLine();
            double inputWeight = double.Parse(input1);

            Console.Write("Enter length (cm): ");
            string input2 = Console.ReadLine();
            double inputHeight = double.Parse(input2);

            Console.Write("Enter gender male/female: ");
            string inputGender = Console.ReadLine();


            //calculate BMI = body weight (kg) / square of height (cm/100)//

            double BMI = inputWeight / Math.Pow(inputHeight / 100.0, 2);

            //display BMI//

            Console.WriteLine("bmi value:{0:0.0} ", BMI);

            //output the normal healthy values for male and female//

            if (inputGender == "male")
            {
                Console.WriteLine("normal bmi-values (min .. max) : 20..25");
            }
            else
            { 
                Console.WriteLine("normal bmi-values (min .. max): 19..24");
            }

            // calculate the male healthy weight between 20×(cm/100)² and 25×(cm/100)²//

            double healthyMaleWeightMin = 20 *  Math.Pow(inputHeight / 100.0, 2);
            double healthyMaleWeightMax = 25 * Math.Pow(inputHeight / 100.0, 2);

            //display min and max weight range//

            Console.WriteLine("healthy weight range: " + healthyMaleWeightMin.ToString("0.0") + "... " + healthyMaleWeightMax.ToString("0.0"));


            Console.ReadKey();
        }
    }
}
