using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона[20; 60]
            int n = 0;
            do
            {
                Console.WriteLine("Введите число от 20 до 60 включительно");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 20 || n > 60);
            Console.WriteLine("Ну наконец-то!");
        }

    }
}
