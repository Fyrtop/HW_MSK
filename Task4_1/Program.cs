using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводится натуральное число n. Найти n! 
            //Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                count *= i;
            }
            Console.Write(count);
        }
    }
}
