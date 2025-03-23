using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50].
            //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
            //Вывести отсортированный таким образом массив на экран
            const int n = 10;
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-50, 51);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

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
            for (int i = 5; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }

                }

            }
            for (int i = 0; i < n; i++)
            {
               Console.Write($"{arr[i]} ");
            }

        }
        }
    }

