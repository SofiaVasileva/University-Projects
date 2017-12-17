using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Valeji(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
            }

        }
        static int NeVali(double[] a)
        {
            int br = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                    br++;

            }
            return br;
        }
        static void Check(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==0)
                    Console.WriteLine($"Prez den {(i+1)} ne e valqlo");
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
            Console.WriteLine("Vuvedete valeji za stancniq A:");
            double[] A = new double[n];
            Valeji(A);
            Console.WriteLine("Vuvedete valeji za stanciq B:");
            double[] B = new double[n];
            Valeji(B);
            Console.WriteLine("Vuvedete valeji za stanciq C:");
            double[] C = new double[n];
            Valeji(C);
            Console.WriteLine($"Dni prez koito ne e valqlo za stancniq A: {NeVali(A)}");
            Console.WriteLine($"Dni prez koito ne e vavqlo za stancniq B: {NeVali(B)}");
            Console.WriteLine($"Dni prez koito ne e valqlo za stancniq C: {NeVali(C)}");
            Console.WriteLine("Za stancniq A:");Check(A);
            Console.WriteLine("Za stancniq B:");Check(B);
            Console.WriteLine("Za stancniq C:");Check(C);
        }
    }
}
