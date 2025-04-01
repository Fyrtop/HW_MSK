using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        //Пароль должен состоять минимум из 14 символов и иметь в составе минимум одну цифру, заглавную букву,
        //строчную букву и специальный символ из набора !#;%:?*.
        {
            string pattern = @"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[!#;%:?*]).{14,}$";
            Console.WriteLine( "Введите пароль из 14 символов с заглавными и строчными символами, спецсимволами, твистом и погоней в финале");
            string psswd = Console.ReadLine();
            Regex regex = new Regex(pattern);
            while (!regex.IsMatch(psswd)) 
            {
                Console.WriteLine("Хорошо, а теперь введите нормальный пароль, удовлетворяющий требованиям!");
                psswd = Console.ReadLine();
            }
            Console.WriteLine("Отлично, пароль принят, вы справились");
                
        }
    }
}
