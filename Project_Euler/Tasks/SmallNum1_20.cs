using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class SmallNum1_20
    {
        public static void Answer() // the largest palindrome obtained by multiplying two three-digit numbers
        {
            Console.Clear();
            Console.WriteLine(" The smallest number divisible by all numbers from 1 to 20 :");

            int[] x = new int[10000000];
            int min = 10000000;
            int[] del = new int[10000000];

            /* for (int i = 1; i < 10000000; i++)
             {
                 x[i] = i;
                 if ((x[i] % 2 == 0) && (x[i] % 3 == 0) && (x[i] % 4 == 0) && (x[i] % 5 == 0) && (x[i] % 6 == 0) && (x[i] % 7 == 0) &&
                     (x[i] % 8 == 0) && (x[i] % 9 == 0) && (x[i] % 10 == 0) && (x[i] % 11 == 0) && (x[i] % 12 == 0) && (x[i] % 13 == 0) && (x[i] % 14 == 0) &&
                     (x[i] % 15 == 0) && (x[i] % 16 == 0) && (x[i] % 17 == 0) && (x[i] % 18 == 0) && (x[i] % 19 == 0) && (x[i] % 20 == 0) && (x[i] < min))
                 {
                     min = x[i];
                 }
             }*/

            for (int i = 1; i < 10000000; i++)
            {
                x[i] = i;
                if ((x[i] % 2 == 0) && (x[i] % 3 == 0) && (x[i] % 4 == 0) && (x[i] % 5 == 0) && (x[i] % 6 == 0) && (x[i] % 7 == 0) &&
                    (x[i] % 8 == 0) && (x[i] % 9 == 0) && (x[i] % 10 == 0) && (x[i] % 11 == 0) && (x[i] % 12 == 0) && (x[i] % 13 == 0) && (x[i] % 14 == 0) &&
                    (x[i] % 15 == 0) && (x[i] % 16 == 0) && (x[i] % 17 == 0) && (x[i] % 18 == 0) && (x[i] % 19 == 0) && (x[i] % 20 == 0))
                {
                    del[i] = x[i];
                    Console.WriteLine($"del[{i}] = {del[i]}");
                }
            }

                Console.WriteLine($"Answer = {min}");


            Console.WriteLine("/n Press 1 to return ");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Program.Main();
                    break;

                default:
                    Console.WriteLine("You enter uknown command");
                    break;

            }
        }
    }
}
