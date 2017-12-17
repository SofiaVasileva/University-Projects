using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int countLucky = 0;
            int countNormal = 0;
            for (int i = 0; i <= 999999; i++)
            { if ((i % 10 + i / 10 % 10 + i / 100 % 10) == (i / 1000 % 10 + i / 10000 % 10 + i / 100000))
                { countLucky++; Console.WriteLine(i.ToString("000000")); }
                else { countNormal++; } }
            Console.WriteLine("Total lucky numbers are: " + countLucky);
            Console.WriteLine("Total not lucky numbers are: " + countNormal);
            int sum = countLucky + countNormal;
            Console.WriteLine("Total tickets are: " + sum);
        }
    }
}
