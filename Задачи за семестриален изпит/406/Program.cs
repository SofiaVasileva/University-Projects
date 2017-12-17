using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _406
{
    class Program
    {
        static int Average(int[] array, int k)
        {
            int avg = 0;
            int br = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= -10 && array[i] <= 10)
                {
                    if (array[i] % k == 0) br++;
                    avg = array[i] / array.Length;
                }

            }
            return avg;
        }
        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                
            }
            return max;
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Vuvedete chsilo");
            n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 60)
            {
                Console.WriteLine("Vuvedete chsilo");
                n = int.Parse(Console.ReadLine());
            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[]"+ i );
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Srednoaritmetichno na chislata delqshti se na {k} bez ostatuk {Average(array,k)} ");
            Console.WriteLine($"Maksimalniq elemnt e {Max(array)} ");
        }
    }
}
