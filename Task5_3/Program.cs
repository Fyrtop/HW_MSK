using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
            //Найти и вывести значение максимального, минимального элементов и их индексы
            const int n = 10;
            int[] arr = new int[n];
            int indMax = 0;
            int indMin = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 51);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            int max = arr[0];
            int min = arr[0];
            
            for (int i = 0; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    indMax = i;
                }

                if (min > arr[i])
                {
                    min = arr[i];
                    indMin = i;
                }
            }


            Console.WriteLine();
            Console.Write($"Max: {max}, Индекс: {indMax}, Min: {min}, Индекс: {indMin}");



        }
        }
    }

