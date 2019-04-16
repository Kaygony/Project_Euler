using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Project Euler:");
            Console.WriteLine("1. The sum of all numbers less than 1000 that are multiples of 3 or 5");
            Console.WriteLine("2. The sum of all even elements of the Fibonacci series, which do not exceed 4 million ");
            Console.WriteLine("3. The largest divisor of 600851475143, which is a prime number (It's not working) ");
            Console.WriteLine("4. The largest palindrome obtained by multiplying two three-digit numbers ");
            Console.WriteLine("5. The smallest number divisible by all numbers from 1 to 20 ");


            string selection = Console.ReadLine();
            switch(selection)
            {
                case "1":
                    Sum_3_or_5.Answer();
                    break;

                case "2":
                    Sum_Fb_chet.Answer();
                    break;

                case "3":
                   // Greatest_divider.Answer();
                    break;

                case "4":
                    Polydrom.Answer();
                    break;

                case "5":
                    SmallNum1_20.Answer();
                    break;


                default:
                    Console.WriteLine("You enter uknown command");
                    break;

            }
            
        }
       
    }
 
}
