using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0,11);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }

                }
            }

            Console.Write($"Наибольшие элементы: {arr[0]} и {arr[1]}");


        }
    }
}
