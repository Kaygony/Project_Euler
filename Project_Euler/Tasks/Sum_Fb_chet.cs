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
            Console.Clear();
            Console.WriteLine(" The sum of all even elements of the Fibonacci series, which do not exceed 4 million:");

            int sum = 0;
            int[] x = new int[40];
        
            Fibonachi(x);

            Console.WriteLine("Fibonacci series");
            for (int i = 0; i < 40; i++)
            {
                if(x[i] < 4000000 && x[i] != 0 && Chet(x[i])==true)
                {
                    Console.WriteLine(x[i]);
                    sum += x[i];
                }
                
            }

            Console.Write("The sum of all even elements of the Fibonacci series: ");
            Console.WriteLine(sum);

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
