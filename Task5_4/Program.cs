using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] arr = new int[n];
            int[] arrTmp = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 11);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            int j = 0;
            for (int i = n-1; i >= 0; i--)
            {
                arrTmp[j] = arr[i];
               Console.Write($"{arrTmp[j]} ");
                j++;
            }
            
        }

    }
}
