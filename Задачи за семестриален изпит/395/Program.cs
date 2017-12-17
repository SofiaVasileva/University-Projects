using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _395
{
    class Program
    {
        static double CelF(double f)
        {
            double cel = 5 / 9 * (f - 32);
            return cel;
        }
        static void DailyTemperatyre(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool f;
                do
                {
                    Console.WriteLine("Enter temperature for" + (i + 1) + "day:");
                    f = double.TryParse(Console.ReadLine(), out a[i]);
                }
                while (!f || a[i] < -100 || a[i] > 100);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number days:");
            int day = int.Parse(Console.ReadLine());
            double[] a = new double[day];
            DailyTemperatyre(a);
            double max = a[0];
            for (int i = 0; i < day; i++)
                if (a[i] > max)
                { max = a[i]; }
            Console.WriteLine("Maximum temperature in F° is: " + max);
            Console.WriteLine("Maximum temperature in C°  is: " + CelF(max));
            Console.WriteLine("Daily temperatures in Celsius  below -10°");
            for (int i = 0; i < day; i++)
            {
                if (CelF(a[i]) < -10)
                    Console.WriteLine((i + 1) + " day:" + CelF(a[i]));
            }
        }
    }
}
    

