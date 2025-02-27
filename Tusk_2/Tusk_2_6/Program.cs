using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(l / 0.5) * 0.5);
        }
    }
}
