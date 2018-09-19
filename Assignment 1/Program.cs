using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter two numbers. Show the highest value ('highest value is: …') and show the lowest value ('lowest
            //value is: …'            //input two numbers//
            Console.WriteLine("Enter first number");
            string input1 = Console.ReadLine();
            int firstnumber = int.Parse(input1);

            Console.WriteLine("Enter second number");
            string input2 = Console.ReadLine();
            int secondnumber = int.Parse(input2);

            //calculate highest and lowest//
            if (firstnumber > secondnumber)
            {
                int highestnumber = firstnumber;
                int lowestnumber = secondnumber;

                Console.WriteLine("The highest value is: " + highestnumber + " The lowest value is: " + lowestnumber);
            }

            else  
            {
                int highestnumber = secondnumber;
                int lowestnumber = firstnumber;

                Console.WriteLine("The highest value is: " + highestnumber + " The lowest value is: " + lowestnumber);
            }

            Console.ReadKey();


        }
          




    }
    }

