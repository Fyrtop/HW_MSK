using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk4_8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tmp = 0;
            do
            {
                tmp *= 10;
                tmp += num % 10;
                num /= 10;
            }
            while (num != 0);
                Console.WriteLine(tmp);
        }
    }
}
