using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter three numbers. Show the sum, average, product, highest and lowest of the numbers

            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            int firstNumber = int.Parse(input1);

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            int secondNumber = int.Parse(input2);

            Console.Write("Enter third number: ");
            string input3 = Console.ReadLine();
            int thirdNumber = int.Parse(input3);

            //Calculation the sum//

            int calculatedSum = firstNumber + secondNumber + thirdNumber;

            //caluclate average//

            double calculatedAverage = calculatedSum / 3;

            //calculate product //

            int calculatedProduct = firstNumber * secondNumber * thirdNumber;

            //calculate highest number//
            int highestNumber = thirdNumber;

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                highestNumber = firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                highestNumber = secondNumber;
            }
            //calculate lowest number//
            int lowestNumber = thirdNumber;

            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                lowestNumber = firstNumber;
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                lowestNumber = secondNumber;
            }

            Console.Write("Sum = ");
            Console.WriteLine(calculatedSum);

            Console.WriteLine("Average = {0:0.00}", calculatedAverage);

            Console.WriteLine("Product = {0} ", calculatedProduct);
         
            Console.WriteLine("Highest = {0} ",highestNumber);

            Console.Write("Lowest = {0} ", lowestNumber);

            Console.ReadKey();
        
        }
    }
}
