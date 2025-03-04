using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            while (n >= 10)
            {
                n /= 10; count++;
            }
            Console.WriteLine(count);
        }
    }
}
