using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double radius;
            radius = rand.Next(33, 187);

            Console.WriteLine("The circle random  radius is: " + radius);
            double area = Math.PI * (radius * radius);
            Console.WriteLine("The circle area random is =" + "{0:F2}", area);

        }
    }
}
