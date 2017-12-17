using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Answer = "";
            bool showB = false;
            do
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                Answer = Console.ReadLine();
                if (Answer == "yes" || Answer == "Yes") showB = true;
                else if (Answer == "no" || Answer == "No") showB = false;
            }

            while (showB == false);

            Console.WriteLine("Enter first number: ");
            double FirstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double SecondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation: ");
            char Operation = char.Parse(Console.ReadLine());
            double Sum=FirstNumber+SecondNumber;
            if (Operation == '+') Console.WriteLine("Result is " + "{0:F2}",(Sum*10/100));
            double Subtract;
            if (Operation == '-')
                if (FirstNumber > SecondNumber)
                {
                    Subtract = Math.Pow(FirstNumber, 2) - SecondNumber;
                    Console.WriteLine("Result is " + "{0:F2}", Subtract);
                }
                else Console.WriteLine("Result is " + "{0:F2}",(Math.Pow(SecondNumber,2)-FirstNumber));
            double Multiplication = FirstNumber * Math.Sqrt(SecondNumber);
            if (Operation == '*') Console.WriteLine("Result is " + "{0:F2}", Multiplication);
            double Divide = FirstNumber / SecondNumber;
            if (Operation == '/')

            {
                if (SecondNumber == 0)

                    Console.WriteLine("Error! You can't divide to !!!");


                else Console.WriteLine("Result is " + "{0:F2}", Divide);
            }
          

        }
    }
}
