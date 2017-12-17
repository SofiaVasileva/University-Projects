using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _376
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Average is:" + AverageNumber());
            Console.WriteLine("Sum is:" + SevenNumber());

            Console.WriteLine("Enter positive integer a:");
            int a = int.Parse(Console.ReadLine());

            while (a < 0)
            {
                Console.WriteLine("Invalid input! Enter a:");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter positive integer b:");
            int b = int.Parse(Console.ReadLine());
            while (b < 0)
            {
                Console.WriteLine("Invalid input! Enter b:");
                b = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter positive integer c:");
            int c = int.Parse(Console.ReadLine());
            while (c < 0)
            {
                Console.WriteLine("Invalid input! Enter c:");
                c = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Result is:" + (Sred(Math.Abs(c - b)) - Sred(c + a)));


        }

        static double AverageNumber()
        {
            double x;
            double s = 0;
            int br = 0;
            do
            {
                Console.WriteLine("Enter positive number:");
                x = double.Parse(Console.ReadLine());
                while (x < 0)
                {
                    Console.WriteLine("Invalid input! Enter positive number:");
                    x = int.Parse(Console.ReadLine());
                }
                s = s + x;
                if (x != 0) br++;
            }

            while (x != 0);

            double average = 0;
            if (br > 0)
                average = s / br;
            return average;

        }
        static double SevenNumber()
        {
            double sum = 0;
            double number = 0;


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter seven number:");
                number = double.Parse(Console.ReadLine());
                if (number < 0 || number > 300)
                    sum = sum + number;
            }
            return sum;
        }
        static double Sred(double k)
        {

            int br = 0;


            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                k = rand.Next(int.MinValue, int.MaxValue);
                if (k >= 10 && k <= 100) br++;
            }
            double avg = 0;

            avg = k / br;
            return avg;

        }
    }
}

