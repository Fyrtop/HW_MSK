using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine()) - double.Parse(Console.ReadLine());
            Console.WriteLine(num > 0 ? ">" : (num < 0 ? "<" : "="));
        }
    }
}
