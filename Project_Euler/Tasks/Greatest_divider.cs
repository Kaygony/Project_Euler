using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Greatest_divider
    {
        public static void Answer() // The largest divisor of 600851475143, which is a prime number
        {
            Console.Clear();
            Console.WriteLine(" The largest divisor of 600851475143, which is a prime number :");

            
            long n = 600851475143;

            Sieve(n);
            

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

        static void Sieve(long n) // sieve of Eratosthenes
        {
            long[] x = new long[n];

            x[0] = 0;

            for (int k = 1; k <= n; k++)
                x[k] = 1;

            for(int k =1; k*k <= n;k++)
            {
                if (x[k] == 1)
                {
                    for (int l = k * k; l <= n; l += k)
                        x[l] = 0;
                }   
            }
            
        }
    }
}
