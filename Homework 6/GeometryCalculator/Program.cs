using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {

        private static void triangle( double side, double height)
        {
            
            
            double area = (side * height) / 2;
            Console.WriteLine("The area of the triangle is {0:0.00}" +area);



        }
        private static void squar(double side)
        {    
            double area = side * side;
            Console.WriteLine("The area of the squar is {0:0.00}" + area);
        }
        private static void radian(double β)
        {
            const double pi = Math.PI;
           double rand = (pi / 180) * β;
            Console.WriteLine("Your degrees in radians are " +rand);
        }
        

    
        static void Main(string[] args)
        {

            Console.WriteLine("Choose option (triangle,squar or radians)");
            string choose = Console.ReadLine();
            if (choose == "triangle") 
            { double trside;
                double trheight;
                Console.WriteLine("Enter side: ");
                trside = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter height: ");
                trheight = double.Parse(Console.ReadLine());
                triangle(trside,trheight);
            }
            if (choose == "squar") 
            {
                 Console.WriteLine("Enter side: ");
                 double squarSide = double.Parse(Console.ReadLine());
                squar(squarSide);
                
            }
            if (choose == "radians") 
            {
                
                Console.WriteLine("Enter the degrees you want to transform in radians:");
               double radians = double.Parse(Console.ReadLine());
                radian(radians);
            }

        }


    }
}
