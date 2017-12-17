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
            double x, s = 0; int br = 0;
            do
            {
                Console.WriteLine("Enter number:");
                x = double.Parse(Console.ReadLine());
                s = s + x;
                if (x != 0) br++;
            }
            while (x != 0);
            if (br > 0) Console.Write("Sredno aritmetichno:"+s/br);

        }
    }
}
