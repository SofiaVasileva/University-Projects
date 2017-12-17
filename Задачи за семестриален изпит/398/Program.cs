using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _398
{
    class Program
    {
        static void Valeji(double[] array)
        {
            //a
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

        }
        static double SrednoKolichetvo(double[] array)
        {

            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average = average + array[i];
            }
            double avg = average / array.Length;
            return avg;

        }
        static void Check(double[] array)
        {
            double sredno = SrednoKolichetvo(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sredno)
                    Console.WriteLine($"Den{i + 1} e s nad srednoto nivo na valeji");
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
            Console.WriteLine("Sredno kolichestvo valeji za stanciq A:" +
            SrednoKolichetvo(A));
            Console.WriteLine("Sredno kolichestvo valeji za stanciq B:" +
            SrednoKolichetvo(B));
            Console.WriteLine("Sredno kolichestvo valeji za stanciq C:" +
            SrednoKolichetvo(C));
            Console.WriteLine("Za stanciq A:"); Check(A);
            Console.WriteLine("Za stanciq B:"); Check(B);
            Console.WriteLine("Za stanciq C:"); Check(C);
        }
    }
}



    
