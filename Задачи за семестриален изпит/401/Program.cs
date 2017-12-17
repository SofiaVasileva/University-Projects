using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401
{
    class Program
    {
        static void Valeji(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = double.Parse(Console.ReadLine());
        }
        static double SrednoKolichestvo(double[] array)
        {
            double avg = 0;
            int br = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > 0)
                {
                    sum = sum + array[i];
                    br++;
                }

            }
            avg = sum / br;
            return avg;
        }
        static void Check(double[] array)
        {

            double broi = SrednoKolichestvo(array);
            int br = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > broi) br++;
                    Console.WriteLine($"Dni s valeji nad srednoto: {br}");

            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Vuvedete broi dni:");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 31);
            Console.WriteLine("Valeji za stanciq A:");
            double[] A = new double[n];
            Valeji(A);
            Console.WriteLine("Valjei za stanciq B:");
            double[] B = new double[n];
            Valeji(B);
            Console.WriteLine("Valeji za stanciq C:");
            double[] C = new double[n];
            Valeji(C);
            Console.WriteLine("Sredno kolichestvo valeji za dnite v koito e valqlo za stanciq A:" + SrednoKolichestvo(A));
            Console.WriteLine("Sredno kolichestvo valeji za dnite v koito e valqlo za stanciq B" + SrednoKolichestvo(B));
            Console.WriteLine("Sredno kolichestvo valeji za dnite v koito e valqlo za stanciq C:" + SrednoKolichestvo(C));
            Console.WriteLine(" za stanciq A:"); Check(A);
            Console.WriteLine(" za stanciq B"); Check(B);
            Console.WriteLine("za stanciq C:"); Check(C);
        }
    }
}

    

