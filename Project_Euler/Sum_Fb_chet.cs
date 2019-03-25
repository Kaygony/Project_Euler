using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Sum_Fb_chet
    {
        public static void Answer()
        {
            Console.WriteLine(" The sum of all even elements of the Fibonacci series, which do not exceed 4 million:");


            Console.WriteLine("начальный массив");
            int[] x = new int[100];
            for(int i=0; i<100; i++)
            {
                Console.WriteLine(x[i]);
            }
            

            Fibonachi(x);
            Console.WriteLine("фибоначи массив");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(x[i]);
            }


            Console.WriteLine("Press 1 to return ");
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

        static void Fibonachi(int[] x)
        {
            int i = 0;

            x[0] = 1;
            x[1] = 2;

            while (x[i] < 4000000)   
            {
                x[i + 2] = x[i] + x[i + 1];
                Console.WriteLine(x[i + 2]);
                i++;
            }
        }

        static bool Chet(int x)
        {
            if ((x % 2) == 0)
            {
                return (true);
            }
            else return (false);
        }
    }
}
