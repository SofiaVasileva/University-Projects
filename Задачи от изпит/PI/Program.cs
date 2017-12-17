using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI
{
    class Program
    {
        static void PI(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

        }
        static int Broi(int[] array)
        {
            int br = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < 50)
                    br++;

            }
            return br;
        }
        static void Check(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 || array[i] > 100)
                    Console.WriteLine($"Prez den {(i + 1)} PI e pogreshno vuvedeno");
            }
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Vuvedete broi dni");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 31);
            Console.WriteLine("Vuvedete procentno izpulnenie PI za rabotnik A:");
            int[] A = new int[n];
            PI(A);
            Console.WriteLine("Vuvedete procentno izpulnenie PI za rabotnik B:");
            int[] B = new int[n];
            PI(B);
            Console.WriteLine("Vuvedete procentno izpulennie PI za rabotnik C:");
            int[] C = new int[n];
            PI(C);
            Console.WriteLine($"Broq na dnite prez koito 0<PI<50 za rabotnik A:{ Broi(A)}");
            Console.WriteLine($"Broq na dnite prez koito 0<PI<50 za rabotnik B: {Broi(B)}");
            Console.WriteLine($"Broq na dnite prez koito 0<PI,50 za rabotnik C: {Broi(C)}");
            Console.WriteLine("Za rabotnik A:"); Check(A);
            Console.WriteLine("Za rabotnik B:"); Check(B);
            Console.WriteLine("Za rabotnik C:"); Check(C);
        }
    }
}
