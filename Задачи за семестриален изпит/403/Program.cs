using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _403
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
        static double Max(double[] array)
        {
            double max= array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] > max)
                    max = array[i];
            }
            return max;



        }
        static void Check(double[] array)
        {
            double ravno = Max(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0 && array[i]==ravno)
                    Console.WriteLine($"Prez den {i+1} valejite sa ravni na maksimalnite.");
            }

        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Vuvedete broi dni");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 31);
            Console.WriteLine("Valeji za stanciq A:");
            double[] A = new double[n];
            Valeji(A);
            Console.WriteLine("Valeji za stanciq B:");
            double[]B=new double[n];
            Valeji(B);
            Console.WriteLine("Valeji za stanciq C:");
            double[] C = new double[n];
            Valeji(C);

            Console.WriteLine("Maksimalni valeji za stanciq A:" + Max(A));
            Console.WriteLine("Maksimalni valeji za stanciq B:" + Max(B));
            Console.WriteLine("Masimalni valeji za stanciq C:" + Max(C));
            Console.WriteLine("Za stanciq A:");Check(A);
            Console.WriteLine("Za stanciq B:");Check(B);
            Console.WriteLine("Za stanciq C:"); Check(C);
        }
    }
}
