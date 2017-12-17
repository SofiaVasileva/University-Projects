using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiserPiggy
{
    class Program
    {
        static void Main(string[] args)
        {

            string Fiffer;

            int sumpg1; int.TryParse("594", out sumpg1);
            Console.WriteLine("Sum of all letters in piggy Fiffer's name is " + sumpg1);
            string Fiddler;
            int sumpg2; int.TryParse("697", out sumpg2);
            Console.WriteLine("Sum of all letters in piggy Fiddler's name is " + sumpg2);
            string Practical;
            int sumpg3; int.TryParse("816", out sumpg3);
            Console.WriteLine("Sum of all letters in piggy Practical's name is " + sumpg3);
            if (594 < 697) 
            {
                Console.WriteLine("The Piggy Fiddler's name is more expensive from Piggy Fiffer's");
            }               

            if (697 < 816) 
            {
                Console.WriteLine("The Piggy Practical's name is more expensive from Piggy Fiddler'с");
            }
            Console.WriteLine("The piggy name which is the wealthiest Practical");
        }
    }
}
