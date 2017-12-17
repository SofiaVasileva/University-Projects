using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSomeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = new int[100];
            Random rand = new Random();

            for (int i = 0; i < arrNums.Length; i++)
            {
                arrNums[i] = rand.Next(0, 133);
            }

            for (int i = 0; i < arrNums.Length; i += 2) // are having even indexes
            {
                Console.WriteLine(arrNums[i] + " has index " + i + " that is even");
            }
            for (int i = 1; i < arrNums.Length; i += 2) // are odd and having odd indexes
            {
                if (arrNums[i] % 2 == 1)
                    Console.WriteLine(arrNums[i] + " is odd and have index " + i + " that is also odd");
            }

            for (int i = 0; i < arrNums.Length; i++) // are divided to 3 without reminder
            {
                if (arrNums[i] % 3 == 0)
                    Console.WriteLine(arrNums[i] + " divied by 3 has no reminder");
            }
            for (int i = 0; i < arrNums.Length; i++) // are divided to 7 and have 1 as reminder
            {
                if (arrNums[i] % 7 == 1)
                    Console.WriteLine(arrNums[i] + " divied by 7 has reminder 1");
            }

            for (int i = 0; i < arrNums.Length; i++) // are in the interval between 26 and 100
            {
                if (arrNums[i] > 25 && arrNums[i] < 101)
                    Console.WriteLine(arrNums[i] + " is in the interval between 26 and 100");
            }

            for (int i = 0; i < arrNums.Length; i++) // are not in the interval between 26 and 100
            {
                if (arrNums[i] < 26 || arrNums[i] > 100)
                    Console.WriteLine(arrNums[i] + " is not in the interval between 26 and 100");
            }
        }
    }
}
