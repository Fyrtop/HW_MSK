using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = FindMax(1, 2, 20, 1020);
            Console.WriteLine($"Max number: {max}");

        }
        static int FindMax(params int[] array)
        {
            int max = 0;
            foreach (int i in array)
            {
                if (i > max)
                { max = i; }
            }
            return max;
        }
    }
}
