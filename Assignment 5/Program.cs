using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter two numbers. Determine and show whether one number is a multiple of the other number.//

            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            int firstNumber = int.Parse(input1);

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            int secondNumber = int.Parse(input2);

            //calculate whether one number is a multiple of the other number//

            double numberResult = firstNumber / secondNumber;
            int isMultiple = 0;
           
            if (Math.Floor(numberResult) * secondNumber == firstNumber)
            {
                Console.WriteLine("Number 1 is a multiple of number 2");
                isMultiple = 1;
            }

            numberResult = secondNumber / firstNumber;

            if (Math.Floor(numberResult) * firstNumber == secondNumber)
            {
                Console.WriteLine("Number 2 is a multiple of number 1");
                isMultiple = 1;
            }

            if (isMultiple == 0 )
             {
                Console.WriteLine("Numbers are no multiples");
            }
            Console.ReadKey();
        }
    }
}
