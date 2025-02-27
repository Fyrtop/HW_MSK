using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int big = num1 > num2 && num1 > num3 ? num1 : (num2 > num3 ? num2 : num3);
            int small = num1 < num2 && num1 < num3 ? num1 : (num2 < num3 ? num2 : num3);
            Console.Write(num1 + num2 + num3 - big - small);
        }
    }
}
