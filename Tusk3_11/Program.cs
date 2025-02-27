using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно ли на прямоугольном участке застройки размером a * b метров разместить
            //два дома размером в плане p * q и r * s метров? Дома можно располагать только
            //параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            int maxab = Math.Max(a,b);
            int minab = Math.Min(a,b);
            int maxpq = Math.Max(p,q);
            int minpq = Math.Min(p,q);
            int minpq = Math.Min(p,q);
            int maxrs = Math.Max(r, s);
            int minrs = Math.Min(r, s);
            string posibility;
            //Проверяем, можно ли вообще воткнуть дома на тот участок. Сравниваем самую большую сторону дома
            //с самой длинной стороной участка и самую короткую сторону дома с самой короткой стороной участка
            if (maxab < Math.Max(maxrs, maxpq) || minab < Math.Min(minrs, minpq))
            {
                posibility = "NO";
                            }
            else
            { 
                //Пока что фиг знает, не идет ничего в голову
            
            }

        }

    }
}
