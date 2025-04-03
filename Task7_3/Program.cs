using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            bool reverse = true;
            PrintNumbers(array, reverse);
        }
        static void PrintNumbers(int [] array, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
