using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // A metal turning lathe will be replaced by a new lathe at the end of the year if one or more of the
            //following conditions have been met:
            //more than 10,000 working hours
            //7 years old or more
            // more than 25 failures a year


            Console.Write("Enter number of working hours: ");
            string input1 = Console.ReadLine();
            double WorkingHours = double.Parse(input1);

            Console.Write("Enter number of years: ");
            string input2 = Console.ReadLine();
            double numberOfYears = double.Parse(input2);

            Console.Write("Enter number of failures: ");
            string input3 = Console.ReadLine();
            double numberOfFailures = double.Parse(input3);

            //calculate if more than 10,000 working hours

            if (WorkingHours > 10000 & numberOfYears > 7 & numberOfFailures > 25)
            {
                Console.WriteLine("machine needs to be replaced");
            }
            else if (WorkingHours > 10000 & numberOfYears > 7 & numberOfFailures < 25)
            {
                Console.WriteLine("machine needs to be replaced");
            }
            else if (WorkingHours > 10000 & numberOfYears < 7 & numberOfFailures < 25)
            {
                Console.WriteLine("machine needs to be replaced");
            }
            else if (WorkingHours < 10000 & numberOfYears < 7 & numberOfFailures > 25)
            {
                Console.WriteLine("machine needs to be replaced");
            }
            else if (WorkingHours < 10000 & numberOfYears > 7 & numberOfFailures < 25)
            {
                Console.WriteLine("machine needs to be replaced");
            }
            else if (WorkingHours < 10000 & numberOfYears < 7 & numberOfFailures < 25)
            {
                Console.WriteLine("Machine does not need to be replaced.");
            }

            Console.ReadKey();
        }
    }
}
