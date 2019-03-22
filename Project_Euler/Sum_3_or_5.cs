using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Sum_3_or_5
    {
        void Answer() // The sum of all numbers less than 1000 that are multiples of 3 or 5
        {
            Console.WriteLine(" The sum of all numbers less than 1000 that are multiples of 3 or 5 :");

            int[] nums = new int[1000];
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                nums[i] = Division_by_3(i);
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }

        static int Division_by_3(int x) // determination of division by 3
        {
            if ( (Sum_of_numders(x) % 3) == 0)
            {
                return (x);
            }
            else
            {
                return (0);
            }
        }

        static int Sum_of_numders(int x) // the sum of the digits of the number
        {
            int sum = 0;

            for( int i = 0; i < 3; i++)
            {
                sum += x % 3;
            }

            return (sum);
        }

    }
}
