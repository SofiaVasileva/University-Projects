using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _395
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter number days:");
            int days = int.Parse(Console.ReadLine());
            double[] NumberDay = new double[days];
            DailyTemperature(NumberDay);
            //v
            double max = NumberDay[0];
            for (int i = 0; i < days; i++)
            {
                if (NumberDay[i] > max)
                {
                    max = NumberDay[i];
                }
            }
            Console.WriteLine("Maximum temperature in F° is: " + max);
            Console.WriteLine("Maximum temperature in C°  is: " + CelF(max));
            //g
            Console.WriteLine("Daily temperatures in Celsius  below -10°");
            for (int i = 0; i < days; i++)
            
         
                if (CelF(NumberDay[i]) < -10)
                    Console.WriteLine($"{i + 1} day: {CelF(NumberDay[i])}");
            

        }
        static double CelF(double f)
        {//a
            double cels = 5 / 9 * (f - 32);
            return cels;
        }

        static void DailyTemperature(double[] days)
        {//b

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($" Enter temperature for {i + 1} day: ");
                int DailyTemperature = int.Parse(Console.ReadLine());
                if (DailyTemperature >= -100 && DailyTemperature <= 100)
                {
                    days[i] = DailyTemperature;

                }
                else Console.WriteLine("Temperature  is not in interval [-100,100]");

            }
        }
    }
}