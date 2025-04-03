using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rib = double.Parse(Console.ReadLine());
            double s, v;
            CalcCube(rib, out s, out v);
            Console.Write($"Объем куба: {v},\nПлощадь поверхности куба: {s}");
        }
        static void CalcCube(double x, out double s, out double v)
        {
            v = x * x * x;
            s = x * x * 6;
        }
    }
}
