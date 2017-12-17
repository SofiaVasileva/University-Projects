using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_7I
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double h, r, R, V;
            Console.WriteLine("Enter height: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the lower base: ");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the upper base: ");
            r = double.Parse(Console.ReadLine());
            V = pi * h*(R*R + R * r + r*r) / 3;
            Console.WriteLine("The cone volume is equal to: " + V+"");

        }

        
    }
}
