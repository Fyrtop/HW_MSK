using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить регулярное выражение для проверки корректности номера телефона. Корректный номер имеет формат +7(123)456-78-90.
            string pattern = @"^\+[1-9]\(\d{3}\)\d{3}-\d{2}-\d{2}$";
            Regex reg = new Regex(pattern);
        string numb = Console.ReadLine();
            Console.WriteLine(reg.IsMatch(numb) ? "OK" : "NOT OK");
        }
    }
}
