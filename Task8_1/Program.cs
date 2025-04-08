using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное
            //Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int oper = int.Parse(Console.ReadLine());

                if (oper < 1 || oper > 4)
                    throw new ArgumentOutOfRangeException("Неверная операция");

                int result = (oper == 1) ? n1 + n2 :
                    (oper == 2) ? n1 - n2 :
                    (oper == 3) ? n1 * n2 : n1 / n2;
                Console.WriteLine(result);

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        }


    
}
