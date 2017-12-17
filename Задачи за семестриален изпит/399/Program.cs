using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _399
{
    class Program
    {
        static void Valeji(double[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

        }

        static double DniBezValeji(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    sum++;
            }
            return sum;




        }
        static void Check(double[] array)
        {
            double sredno = DniBezValeji(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                    Console.WriteLine($"V den {i + 1} ne e valqlo");

            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Vuvedete broi dni v meseca:");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 31);
            Console.WriteLine("Valeji za stanciq A:");
            double[] A = new double[n];
            Valeji(A);
            Console.WriteLine("Valeji za stanciq B:");
            double[] B = new double[n];
            Valeji(B);
            Console.WriteLine("Valeji za stanciq C:");
            double[] C = new double[n];
            Valeji(C);
            Console.WriteLine(" Dni bez valeji za stanciq A:" + DniBezValeji(A));

            Console.WriteLine("Dni bez valeji za stanciq B:" + DniBezValeji(B));

            Console.WriteLine("Dni bez  valeji za stanciq C:" + DniBezValeji(C));

            Console.WriteLine("Za stanciq A:"); Check(A);
            Console.WriteLine("Za stanciq B:"); Check(B);
            Console.WriteLine("Za stanciq C:"); Check(C);
        }
    }
}
    

