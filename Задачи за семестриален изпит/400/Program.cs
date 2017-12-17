using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _400
{
    class Program
    {
        static void Valeji(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = double.Parse(Console.ReadLine());
        }
        static double DniSValeji(double[] array)
        {
            double vali = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    vali++;
                }

            }
            return vali;
        }
        static void Check(double[] array)
        {
            double nomer = DniSValeji(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine($"Prez {i + 1} den e  valqlo");
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
            Console.WriteLine("Valeji za A:");
            double[] A = new double[n];
            Valeji(A);
            Console.WriteLine("Valeji za B:");
            double[] B = new double[n];
            Valeji(B);
            Console.WriteLine("Valeji za C:");
            double[] C = new double[n];
            Valeji(C);
            Console.WriteLine("Dni v koito e valqlo za stanciq A:" + DniSValeji(A));
            Console.WriteLine("Dni v koito e valqlo za stanciq B:" + DniSValeji(B));
            Console.WriteLine("Dni v koito e valqlo za stanciq C:" + DniSValeji(C));
            Console.WriteLine("Za stanciq A:"); Check(A);
            Console.WriteLine("Za stanciq B:"); Check(B);
            Console.WriteLine("Za stanciq C:"); Check(C);

        }
    }
}

    

