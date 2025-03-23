using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool redFlag = false;
            const int n = 5;
            int[,] arr = new int[n,n];
            int r, c;
            r = c = n;
            Random rnd = new Random();

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[i, j] = rnd.Next(0, 2);
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0;i < r; i++)
            {
                for (int j = 0; j < c-2; j++)
                {
                    if (arr[i, j] + arr[i, j + 1] + arr[i, j + 2] == 3)
                    {
                        Console.WriteLine("ДА");
                        redFlag = true;
                        break;
                    }
                
                }
                if (redFlag)
                { return; }
            }
            redFlag = false;
            for (int i = 0; i < r-2; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (arr[j, i] + arr[j, i + 1] + arr[j, i + 2] == 3)
                    {
                        Console.WriteLine("ДА");
                        redFlag = true;
                        break;
                    }

                }
                if (redFlag)
                { return; }
            }
            Console.Write("NO");
        }
    }
}
