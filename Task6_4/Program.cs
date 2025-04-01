using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросите у пользователя имя, возраст и город. Сформируйте строку в формате: "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите имя");
            sb.Append("Имя: ").Append(Console.ReadLine());
            Console.WriteLine("Введите возраст");
            sb.Append(", Возраст: ").Append(Console.ReadLine());
            Console.WriteLine("Введите город");
            sb.Append(", Город: ").Append(Console.ReadLine());
            Console.Write(sb);


        }
    }
}
