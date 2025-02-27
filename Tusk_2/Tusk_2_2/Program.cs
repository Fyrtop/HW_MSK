using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Угол а задан в градусах, минутах и секундах. Найти его величину в радианах.
//Рекомендации по тестированию: проверить работоспособность программы для углов,
//больших развернутого.

            int grad = int.Parse(Console.ReadLine());
            int minut = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            double ang = (grad * 3600 + minut * 60 + sec) / 3600;
            double rad_ang = (Math.PI/180) * ang;
            Console.WriteLine(rad_ang);
        }
    }
}
