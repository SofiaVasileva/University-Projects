using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _367
{
    class Program
    {

        static void NumberinWords()
        {
            Console.Write("Enter number in interval [1,10]:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {

                case 1: Console.WriteLine("The number in word is one"); break;
                case 2: Console.WriteLine("The number in word is two"); break;
                case 3: Console.WriteLine("The number in word is three"); break;
                case 4: Console.WriteLine("The number in word is four"); break;
                case 5: Console.WriteLine("The number in word is five"); break;
                case 6: Console.WriteLine("The number in word is six"); break;
                case 7: Console.WriteLine("The number in word is seven"); break;
                case 8: Console.WriteLine("The number in word is eight"); break;
                case 9: Console.WriteLine("The number in word is nine"); break;
                case 10: Console.WriteLine("The number in word is ten"); break;

                default: Console.WriteLine("Error!!!Enter number in interval [0,10]");
                    break;

            }
            Console.ReadKey(true);


        }
        static void Main(string[] args)
        {
            NumberinWords();
        }

        
    }
}
