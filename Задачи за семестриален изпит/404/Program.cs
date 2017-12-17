using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404
{
    class Program
    {
        static int Sum(int[]array,int k)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > k)
                    sum = sum + array[i];
            }
            return sum;
        }
        static int Chetno(int[] array)
        {
            int chetno = 0;
            int br = 0;
            int ed = 0;
            int des = 0;
            int stot = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 100 && array[i] <= 999)
                {
                    stot = array[i] / 100;
                    des = array[i] / 10 % 10;
                    ed = array[i] % 10;
                    chetno = stot + des + ed;
                }
                if (chetno % 2 == 0) br++;
                   
            }
            return chetno;

        }

        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Vuvedete chislo v intervala [2,50]");
            n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 50) 
            {
                Console.WriteLine("Vuvedete chislo v intervala [2,50]");
                n = int.Parse(Console.ReadLine());
            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[]" + i);
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("k=");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sumata po golqma ot {k} e ravna na {Sum(array, k)}");
            Console.WriteLine($"S chetni chisla { Chetno(array)}");
                
        }
    }
}
