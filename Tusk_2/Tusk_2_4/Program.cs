using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n / 1000;
            int n2 = (n % 1000) / 100;
            int n3 = (n % 100) / 10;
            int n4 = n % 10;
            Console.WriteLine(n1 * 1000 + n4 * 100 + n3 * 10 + n2);
        }
    }
}
