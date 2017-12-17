using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
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
        static double Sredno(int[] a)
        {
            int br = 0;
            double sum = 0;
            double average = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                br++;
            }
            average = sum / br;
            return average;
        }
        static void Check(int[] a)
        {
            double sredno = Sredno(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]>sredno)
                    Console.WriteLine($"PRez den {(i+1)} slujitelqt e rabotil nad srednoto kolichestvo chasove za meseca");
            }

        }
        static void Main(string[] args)
        {
            int n;
            do

            {
                Console.WriteLine("Vuvedete broi dni:");
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
            Console.WriteLine($"Sredno izraboteni chasove na slujitel A: {Sredno(A)}");
            Console.WriteLine($"Sredno izraboteni chasove na slujitel B: {Sredno(B)}");
            Console.WriteLine($"Sredno izraboteni chasove na slujitel C: {Sredno(C)}");
            Console.WriteLine("Za slujitel A:"); Check(A);
            Console.WriteLine("Za slujitel B:");Check(B);
            Console.WriteLine("Za slujitel C:");Check(C);
        }
    }
}
