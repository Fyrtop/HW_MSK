using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sent = Console.ReadLine();
            string maxWord = "";
            // int len = 0;
            string[] words = sent.Split(' ');
            foreach (string word in words)
            {
                if (word.Length > maxWord.Length)
                { 
                    maxWord = word;
                }

            }
            Console.WriteLine(maxWord);
        }
    }
}
