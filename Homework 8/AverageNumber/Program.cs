using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double x = 0;
            int br = 0;
            do
            {
                Console.WriteLine("Enter number:");
                x = double.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Finished!!!");
                }
                else if (x >= 1 && x <= 255)
                {
                    br++;
                    s += x;
                }
            }

            while (x != 0);
            if (br > 0) Console.WriteLine("Average "  + s / br +  "");
        }
    }
}