using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a number 1, 2, 3 or 4. Reject another value. Show the text 'clubs, 'diamonds', 'hearts' or 'spades' 
            // for 1, 2, 3 or 4 respectively. Use a switch statement (so don’t use if-else)

            Console.WriteLine("Enter a number between 1 and 4");
            string input = Console.ReadLine();
            int enterednumber = int.Parse(input);

            //  Show the text 'clubs, 'diamonds', 'hearts' or 'spades'
            // for 1, 2, 3 or 4 respectively//

        switch (enterednumber)
            {
                case 1:
                    Console.WriteLine("Spade");
                break;
                case 2:
                    Console.WriteLine("Diamond");
                break;
                case 3:
                    Console.WriteLine("Clubs");
                break;
                case 4:
                    Console.WriteLine("Hearts");
                break;
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }

            Console.ReadKey();
        }
    }
}
