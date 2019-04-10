using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Polydrom
    {
        public static void Answer() // the largest palindrome obtained by multiplying two three-digit numbers
        {
            Console.Clear();
            Console.WriteLine(" The largest palindrome obtained by multiplying two three-digit numbers :");

            Console.WriteLine("enter digit");
            int x = Convert.ToInt32(Console.ReadLine());

            PolydromChek(x);


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

        static void PolydromChek(int x)
        {
            int y = 0;

            int[] d = new int[7];
            d[0] = 1;

            int[] p = new int[6];

            for(int i =0; i<6; i++)
            {
                p[i] = x % (d[i] * 10);
                x -= p[i];
                
                d[i+1] = d[i] * 10;

                p[i] = p[i] / d[i];

                Console.WriteLine($" p = {p[i]}");

            }
            Console.WriteLine(" ");

            for (int i = 0; i < 6; i++)
            {
                int j = 6;
                p[i] = p[i] * d[j];
                j--;

                Console.WriteLine($" pр = {p[i]}");
            }
            Console.WriteLine(" ");

            for (int i = 0; i < 6; i++)
            {
                y += p[i];
                Console.WriteLine($" d = {d[i]}");
            }
            Console.WriteLine(" ");

            Console.WriteLine($" y = {y}");
        }
    }
}
