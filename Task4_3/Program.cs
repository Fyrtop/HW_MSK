using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 2;
            while (count <= b) 
            {
                a *= a; count++;
            }
            Console.WriteLine(a);
        }
    }
}
