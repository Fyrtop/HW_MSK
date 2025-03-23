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
            int[] arrTmp = arr;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arrTmp[i] < arrTmp[j])
                    {
                        indMin = j;
                        int tmp = arrTmp[i];
                        arrTmp[i] = arrTmp[j];
                        arrTmp[j] = tmp;

                    }
                }
            }
            for (int i = 0; i > n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        indMax = j;
                        int tmp = arrTmp[i];
                        arrTmp[i] = arrTmp[j];
                        arrTmp[j] = tmp;

                    }
                }
            }
            //Чот фиг знает, как тут индексы получить. С максимальным и минимальным все просто, все через сортировку, а индексы быз специальных средств получить как не понимаю
            Console.WriteLine();
            //Console.Write($"Мах: {arrTmp[n-1]}, Индекс: {indMax}, Min: {arr[0]}, Индекс: {indMin}");
            //Console.Write($"Мах: {arr[n-1]}, Индекс: {indMax}, Min: {arr[0]}, Индекс: {indMin}");


        }
        }
    }

