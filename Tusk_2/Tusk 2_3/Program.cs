using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double duim = double.Parse(Console.ReadLine());
            double sm = duim * 2.54;
            int m = Convert.ToInt32(sm / 100);
            int san = Convert.ToInt32(sm % 100);
            double mm = duim % 1;
            Console.Write($"{duim} дюйм = {m} м {san} см {mm} мм");
        }
    }
}
