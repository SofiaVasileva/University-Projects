using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeckOfCards
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string Answer = "";
            bool showB = false;
            do
            {
                Console.WriteLine("Do you want to see a full deck of cards?");
                Answer = Console.ReadLine();
                if (Answer == "yes" || Answer == "Yes") showB = true;
                else if (Answer == "no" || Answer == "No") showB = false;
            }

            while (showB == false);
            {
                Console.OutputEncoding = Encoding.ASCII;
                Console.WriteLine("A\u0003, A\u0006, A\u0004, A\u0005");
                Console.WriteLine("2\u0003, 2\u0006, 2\u0004, 2\u0005");
                Console.WriteLine("3\u0003, 3\u0006, 3\u0004, 3\u0005;");
               Console.WriteLine("4\u0003, 4\u0006, 4\u0004, 4\u0005;");
                Console.WriteLine("5\u0003, 5\u0006, 5\u0004, 5\u0005;");
                Console.WriteLine("6\u0003, 6\u0006, 6\u0004, 6\u0005;");
                Console.WriteLine("7\u0003, 7\u0006, 7\u0004, 7\u0005;");
                Console.WriteLine("8\u0003, 8\u0006, 8\u0004, 8\u0005;");
                Console.WriteLine("9\u0003, 9\u0006, 9\u0004, 9\u0005;");
                Console.WriteLine("10\u0003, 10\u0006, 10\u0004, 10\u0005;");
                Console.WriteLine("J\u0003, J\u0006, J\u0004, J\u0005;");
                Console.WriteLine("Q\u0003, Q\u0006, Q\u0004, Q\u0005;");
                Console.WriteLine("K\u0003, K\u0006, K\u0004, K\u0005;");
               
               
            }


        }
    }
}

