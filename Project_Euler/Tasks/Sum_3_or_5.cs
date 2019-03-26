using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Sum_3_or_5
    {

        public static void Answer() // The sum of all numbers less than 1000 that are multiples of 3 or 5
        {
            Console.Clear();
            Console.WriteLine(" The sum of all numbers less than 1000 that are multiples of 3 or 5 :");

            int[] nums = new int[1000];
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                nums[i] = i;
                if (Division_by_5(nums[i]) == true || Division_by_3(nums[i]) == true)
                {
                    sum += nums[i];
                }    
            }
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

        static bool Division_by_5(int x) // determination of division by 5
        {
            if((x%10)== 0 || (x % 10) == 5)
            {
                return (true);
            }
            else return (false);
        }
        static bool Division_by_3(int x) // determination of division by 3
        {
            if ( (Sum_of_numders(x) % 3) == 0)
            {
                return (true);
            }
            else return (false);           
        }

        static int Sum_of_numders(int x) // the sum of the digits of the number
        {
            int sum = 0;

            for( int i = 0; i < 3; i++)
            {
                sum += x % 10;
                x = x / 10;
            }

            return (sum);
        }

    }
}
