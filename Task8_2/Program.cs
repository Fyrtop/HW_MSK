using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод ValidateAge, проверяющий корректность возраста. Если возраст:
               //< 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
               //> 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").
            try
            {

                int age = int.Parse(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine("OK");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                }
        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }
            if (age > 150)
            {
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
            }
        }
    }
}
