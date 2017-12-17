using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
       private static void GetMax(int FirstNumber, int SecondNumber)
        {
            int max = FirstNumber;
            if (SecondNumber > FirstNumber)
            { max = SecondNumber; }
            Console.WriteLine("The biggest number is " + max);
        }
        static void Main(string[] args)
        {
            int num1;
            int num2;
            
            Console.WriteLine("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            GetMax(num1,num2);
            
            

        }

       
    }
}
