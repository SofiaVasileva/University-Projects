using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSomeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
        
            {
                Console.OutputEncoding = Encoding.UTF8;
                string letters = "абвгдежзийклмнопрстуфхцчшщъюя";
                Random rand = new Random();
                char c;
                
                for (int i = 0; i < 100; i++)
                {
                    c = letters[rand.Next(0, letters.Length)]; 
                    if ("аео".Contains(c)) Console.WriteLine("Буквата (" + c + ") е широка гласна и се намира под номер "+i+" ");
                    else if ("иуъ".Contains(c))
                        Console.WriteLine("Буквата (" + c + ") е тясна гласна и се намира под номер "+i+" ");
                    else if ("юя".Contains(c)) Console.WriteLine("Буквата (" + c + ") е съставна гласна  и се намира под номер " + i + "");
                }
                for (int i = 0; i < 100; i++)
                {
                    c = letters[rand.Next(0, letters.Length)];
                    if ("п, ф, к, т, ш, с, х, ц".Contains(c)) Console.WriteLine("Буквата (" + c + ") е беззвучна съгласна  и се намира под номер " + i + "");
                    else if ("л, м, н, р".Contains(c))
                        Console.WriteLine("Буквата (" + c + ") е сонорна съгласна");
                    else if ("б, в, г, д, ж, з, ч".Contains(c)) Console.WriteLine("Буквата (" + c + ") е звучна съгласна  и се намира под номер " + i + "");
                }

            }
        }

    }
}

	

