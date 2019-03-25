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
            Console.WriteLine("Project Euler:");
            Console.WriteLine("1. The sum of all numbers less than 1000 that are multiples of 3 or 5");
            Console.WriteLine("2. ");


            string selection = Console.ReadLine();
            switch(selection)
            {
                case "1":
                    Sum_3_or_5.Answer();
                    break;

                case "2":
                    Sum_Fb_chet.Answer();
                    break;


                default:
                    Console.WriteLine("You enter uknown command");
                    break;

            }
            
        }
       
    }
 
}
