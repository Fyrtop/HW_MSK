using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int pos = 0;
            int neg = 0;
            int zero = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                if (array[i] == 0)
                {
                    zero++;
                }
                else 
                {
                    if (array[i] > 0)
                    {
                        pos++;
                    }
                    else
                    {
                        neg++;
                    }

                }
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Четных: {pos}, Нечетных: {neg}, Нулей: {zero}");
        }
    }
}
