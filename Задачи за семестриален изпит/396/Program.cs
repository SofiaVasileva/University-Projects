using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _396
{
    class Program
    {
        static double CelK(double k)
        {
            //a
            double cel = k - 273.15;
            return cel;
        }
        static void DailyTemperature(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {//b
                Console.WriteLine($"Enter daily temperature for {i + 1} day in interval [223,323]");
                int temperature = int.Parse(Console.ReadLine());
                if (temperature >= 223 && temperature <= 323)
                {
                    array[i] = temperature;
                }
                else Console.WriteLine("Temperature is not in interval [223,323]");
            }


        }

        static void Main(string[] args)
        {//b
            Console.WriteLine("Enter number day:");
            int day = int.Parse(Console.ReadLine());
            int[] NumberDay = new int[day];
            DailyTemperature(NumberDay);
            //v
            int min = NumberDay[0];
            for (int i = 0; i < day; i++)
            {
                if (NumberDay[i] < min)

                {
                    min = NumberDay[i];
                }
                Console.WriteLine("Minimum temperature in K° is: " + min);
                Console.WriteLine("Minimum temperature in  C° is:" + CelK(min));
            }
            for (int i = 0; i < day; i++)
            {
                if (CelK(NumberDay[i]) >= 10 && CelK(NumberDay[i]) <= 30)
                {
                    Console.WriteLine("Daily temperatures in Celsius between 10° and 30° is " + CelK(NumberDay[i]));
                }

            }

        }

    }
}

