using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter three numbers. If the first two are both greater than the third, show 'The third number is the
            //smallest of the three', otherwise show 'The third number is not the smallest of the three'. 
           
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            int firstnumber = int.Parse(input1);

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            int secondnumber = int.Parse(input2);

            Console.Write("Enter third number: ");
            string input3 = Console.ReadLine();
            int thirdnumber = int.Parse(input3);

            //. If the first two are both greater than the third, show 'The third number is the
            //smallest of the three', otherwise show 'The third number is not the smallest of the three

            if (firstnumber > secondnumber && secondnumber > thirdnumber)
            {
            Console.WriteLine("The third number is the smallest of the three"); 
            }
            else
            {
             Console.WriteLine("The third number is not the smallest of the three");
            }
            Console.ReadKey();

        }
    }
}
