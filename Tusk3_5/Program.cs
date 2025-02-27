using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.

namespace Tusk3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.Write(num % 10 == 0 ? "Да" : "Нет");
        }
    }
}
