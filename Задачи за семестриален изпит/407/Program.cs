using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _407
{
    class Program
    {
        static int Sredno(int[] array, int k)
        { int br = 0;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= -k && array[i] <= k)
                {
                    if (array[i] % 5 == 0) br++;
                    sum = sum + array[i];
                }
            }
            average = sum / br;
            return average;
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;

        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Vuvedete chislo");
            n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 30)
            {
                Console.WriteLine("Vuvedete chislo");
                n = int.Parse(Console.ReadLine());
            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[]" + i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine( $"Rezultat {Sredno(array,k)}" );
            Console.WriteLine($"Minimalen element {Min(array)}");
        }
    }
}
