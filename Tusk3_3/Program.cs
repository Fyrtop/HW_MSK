using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int bigger12 = num1 >= num2 ? num1 : num2;
            int bigger34 = num3 >= num4 ? num3 : num4;
            Console.Write(bigger12 > bigger34 ? bigger12 : bigger34);
        }
    }
}
