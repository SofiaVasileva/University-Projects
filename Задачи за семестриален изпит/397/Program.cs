using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _397
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number day:");
            int NumberDay = int.Parse(Console.ReadLine());
            int[] day = new int[NumberDay];
            DailyTemperature(day);
            //v
            int min = day[0];
            int max = day[0];
            //  int result = max - min; 
            for (int i = 0; i < day.Length; i++)
            {
                if (day[i] < min)
                {
                    min = day[i];
                }
                else if (day[i] > max)
                {
                    day[i] = max;
                }
            }
            Console.WriteLine($"Difference between min and max is {max - min} ");

            for (int i = 0; i < day.Length; i++)
                Console.WriteLine($"Temperature in Kelvin{Kelvin(day[i])}");

        }

        static double Kelvin(double t)
        {
            //a
            double cels = t + 273.15;
            return cels;
        }
        static void DailyTemperature(int[] days)
        {
            //b

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"Enter daily temperature for{i + 1} day in interval [-50,50]");
                int dailytemperature = int.Parse(Console.ReadLine());
                if (dailytemperature >= -50 && dailytemperature <= 50)
                {
                    days[i] = dailytemperature;
                }
                else Console.WriteLine("Enter temeprature in interval [-50,50]");
            }
        }

    }
}

   
