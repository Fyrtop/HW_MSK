using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Вводится натуральное число n. Найти 1 + 1 / 2 + 1 / 3 + … +1 / n
          int n = int.Parse(Console.ReadLine());
            double count = 0;
            for (double i = 1; i <= n; i++ )
            {
                count += 1 / i;
            }
            Console.WriteLine(count);
        }
    }
}
