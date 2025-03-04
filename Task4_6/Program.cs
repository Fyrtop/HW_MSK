using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
                while (n % 2 == 0)
            { 
            n /= 2;
            }
        Console.Write(n == 1 ? "Yes": "NO");
            //решение работает, если считать 1 как два в степени ноль.
        }

    }
}
