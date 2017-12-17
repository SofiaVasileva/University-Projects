using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Chas(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int Nad8(int[] a)
        {
            int br = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 8)
                    br++;
            }
            return br;
        }
        static void Check(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>8)
                    Console.WriteLine($"Prez den {(i+1)} slujitelq e rabotil nad 8 chasa");
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
            Console.WriteLine("Vuvedete chasove za slujitel A:");
            int[] A = new int[n];
            Chas(A);
            Console.WriteLine("Vuvedete chasove za slujitel B:");
            int[] B = new int[n];
            Chas(B);
            Console.WriteLine("Vuvedete chasove za slujitel C:");
            int[] C = new int[n];
            Chas(C);
            Console.WriteLine($"Slujitel A e rabotil nad 8 chasa prez {Nad8(A)} dni");
            Console.WriteLine($"Slujitel B e rabotil nad 8 chasa prez {Nad8(B)} dni");
            Console.WriteLine($"Slujitel C e rabotil nad 8 chasa prez {Nad8(C)} dni");
            Console.WriteLine("Za slujitel A:"); Check(A);
            Console.WriteLine("Za slujitel B:");Check(B);
            Console.WriteLine("Za slujitel C:");Check(C);

        }
    }
}
