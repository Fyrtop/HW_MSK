using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 25;
            int[] arr = new int[n];
            for (int i = 0; i < n; i+=2) 
            {
                arr[i] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
                if (i == 4 || i == 9 || i == 14 || i == 19)
                { Console.WriteLine(); }
            }
            Console.WriteLine("\n");
            const int m = 5;
            int r, c;
            r = c = m;
            int[,] arr2 = new int[r,c];

            for (int i = 0; i < n; i++)
            { 
                int row = i/m;
                int col = i%m;
                arr2[row,col] = arr[i];
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
