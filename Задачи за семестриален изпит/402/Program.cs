using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _402
{
    class Program
    {
        static void Valeji(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = double.Parse(Console.ReadLine());

        }
        static double Min(double[] array)
        {
            double min = array[0] ;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min)
                    min = array[i];
            }
            return min;
        }
        static void Check(double[] array)
        {
            double ravno = Min(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==ravno && array[i]>0)
                    Console.WriteLine($"Prez den {i+1} kolichestvoto valeji e ravno na minimalnoto");
            }

        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("vuvedete broi dni:");
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
            Console.WriteLine("Minimalno kolichestvo valeji za stanciq A" + Min(A));
            Console.WriteLine("Minimalno kolichestvo valeji za stanciq B:" + Min(B));
            Console.WriteLine("Minimalno kolichestvo valeji za stanciq C:" + Min(C));
            Console.WriteLine("Za stanciq A:");Check(A);
            Console.WriteLine("Za stanciq B:");Check(B);
            Console.WriteLine("Za stanciq C:");Check(C);


        }
    }
}
