using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKrug
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double s;
	    double r;
            Console.WriteLine("Enter the radius of the circle: ");
            r = double.Parse(Console.ReadLine());
            s = pi*r * r;
            Console.WriteLine("Area of the circle is equal to" + s);
        }
    }
}
