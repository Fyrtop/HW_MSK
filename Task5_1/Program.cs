using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();
            int eq = 0;
            for (int i = 0; i < n; i++) 
            {
                array[i] = rnd.Next(0, 101);
                eq = array[i]%2 == 0 ? eq+1 : eq-1;
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(eq > 0 ? "Больше четных" : (eq == 0 ? "Четных и нечетных одинаковое количество" : "Больше нечетных"));
        }
    }
}
