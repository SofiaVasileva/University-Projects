using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _393
{
    class Program
    
        {
            static double Sum3(double x, int a)
            {//а
                double result = Math.Pow(x + a, 3);
                return result;

            }
            static void Array(int[] a)
            {
                //v
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("Enter {0} element: ", i);
                    a[i] = Int32.Parse(Console.ReadLine());
                }
                //g
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j]) // swap items
                        {
                            int tmp = a[i];
                            a[i] = a[j];
                            a[j] = tmp;
                        }
                    }
                }
                for (int i = 0; i < a.Length; i++)  // print sorted array
                {
                    Console.Write(a[i] + " ");
                }

            }

            static void Main(string[] args)
            {
                // б
                Console.WriteLine("Enter x=");
                double x = double.Parse(Console.ReadLine());
                double result = 10 * x * Sum3(x, 5) + Sum3(x, 2);
                Console.WriteLine("Result is:" + result);
                //v,g
                Console.Write("Enter array length: ");
                int n = Int32.Parse(Console.ReadLine());
                int[] a = new int[n];
                Array(a);
                Console.WriteLine("Result is" + Sum3(x, a[n - 1]));
            }


        }
    }

    


