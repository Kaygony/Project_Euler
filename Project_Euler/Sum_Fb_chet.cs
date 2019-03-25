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
            Console.WriteLine(" The sum of chet numbers of Phibonachi less than 4000000:");

            int[] x = new int[10000];
            Console.WriteLine(x);

            Fibonachi(x);
            Console.WriteLine(x);


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
