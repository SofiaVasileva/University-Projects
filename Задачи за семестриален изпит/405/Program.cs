using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405
{
    class Program
    {
        static int Prod(int[] array, int k)
        { int prod = 1;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < k) 
                    prod = prod * array[i];
            }
            return prod;

        }
        static int Suma(int[] array)
        {
            int br = 0;
            int stot = 0;
            int des = 0;
            int ed = 0;
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 100 && array[i] <= 666)
                {
                    stot = array[i] / 100;
                    des = array[i] / 10 % 10;
                    ed = array[i] % 10;
                }
                suma = stot + des + ed;
                if (suma % 3 == 0) br++;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vuvedete chislo:");
            n = int.Parse(Console.ReadLine());
            while (n <2 || n >25)
            {
                Console.WriteLine("Vuvedete chislo:");
                n = int.Parse(Console.ReadLine());

            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            { Console.WriteLine("array[]"+i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Proizvedenieto po malko ot {k} e {Prod(array,k)}");
            Console.WriteLine($"Sumata na cifrite koito se delqt na 3 e {Suma(array)}");
        }
    }
}
