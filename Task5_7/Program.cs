using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int r = 10;
            int c = 5;
            int[,] arr = new int[r, c];
            Random rnd = new Random();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = rnd.Next(0, 11);
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < r; i++) 
            {
                int max = 0;
                for (int j = 0; j < c; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}
