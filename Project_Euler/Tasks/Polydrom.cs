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

            int[] a = new int[1000];
            int[] b = new int[1000];
            int m = 0;

            for(int i = 0; i<1000; i++)
            {
                a[i] = i;
                b[i] = i;          
            }

            for (int i = 0; i < 1000; i++)
            {
                for(int j = 0; j<1000; j++)
                {
                    /* if((PolydromChek(a[i] * b[j]) == true) && ((a[i] * b[j])>m))
                     {
                         m = a[i] * b[j];
                         Console.WriteLine($"m = {m}");
                     } */
                    PolydromChek(a[i] * b[j]);
                    Console.WriteLine($"a[i] * b[j] = {a[i] * b[j]}");
                }
                
            }

            Console.WriteLine($"Answer: {m}");

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

            }

            int j = 5;
            for (int i = 0; i < 6; i++)
            {
                p[i] = p[i] * d[j];
                j--;

            }

            for (int i = 0; i < 6; i++)
            {
                y += p[i];
            }

            if (x == y)
            {
                //return (true);
                Console.WriteLine(true);
            }
            else
            {
                //return (false);
                Console.WriteLine(false);
            }
                
        }


    }
}
