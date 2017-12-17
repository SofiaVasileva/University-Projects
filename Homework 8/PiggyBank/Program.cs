using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            double sqrt = 0;
            double bonus = 0;
            double year = bonus * 12;
            Random random = new Random();
            for (int i = 1; i < 31; i++)
            {
                number = random.Next(1, 999 * 999+1);
                sqrt = Math.Sqrt(number);
                Console.WriteLine("{0:0.0000} is the number for day {1}", sqrt, i);
                if (sqrt >= 1 && sqrt <= 300)
                {
                    sqrt *= 5.1;
                    Console.WriteLine("Bonus is: " + sqrt);
                    bonus += sqrt;

                }
                else if (sqrt >= 301 && sqrt <= 600)
                {
                    sqrt *= 10.098;
                    Console.WriteLine("Bonus is: " + sqrt);
                    bonus += sqrt;

                }
                else if (sqrt > 601 && sqrt <= 999)
                {
                    sqrt *= 100.00001;
                    Console.WriteLine("Bonus is: " + sqrt);
                    bonus += sqrt;
                }
                Console.WriteLine("Monthly bonus: {0:0.0000}\n", bonus);

                if (year > 1000000)
                {
                    Console.WriteLine("The year bonus is" + year + " and it is more than a million.");
                }
                else
                {
                    Console.WriteLine("The year bonus is" + year + " and it is less than a million.");
                }












            }
        }
    }
}
