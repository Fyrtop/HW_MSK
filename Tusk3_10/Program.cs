using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Застройщик построил n домов. Вывести фразу «Мы построили n домов»,
            //обеспечив правильное согласование числа со словом «дом», например:
            //20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».
            int num = int.Parse(Console.ReadLine());
            string fin = "";
            switch (num)
            {
                case int n when n%100 >= 5 && n%100 <= 20:
                    fin = "ов";
                    break;
                case int n when n % 10 == 1:
                    fin = "";
                    break;
                case int n when n % 10 > 1 && n % 10 < 5:
                    fin = "а";
                    break;
                default:
                    fin = "ов";
                    break;
            }
            Console.Write($"{num} - «Мы построили {num} дом{fin}»");
           
                
           
            
            
            

        }

    }
}
