using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sent = Console.ReadLine();
            string sentRev = new string(sent.Reverse().ToArray());
            Console.WriteLine(sentRev == sent ? "YES" : "NO");
        }
    }
}
