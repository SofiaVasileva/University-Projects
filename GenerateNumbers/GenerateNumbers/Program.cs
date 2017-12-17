using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[125];
            Random rand = new Random();
            for (int i = 0; i < number.Length; i++)
            { number[i] = rand.Next(0, 50); }
            for (int i = 0; i < number.Length; i++)
            { if (i != 0 && i != 125 && i%2==0) Console.WriteLine(i); }

        }
    }
}
