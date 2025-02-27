using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusk3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int _dig3 = num%10;
            int _dig1 = num / 100;
            int _dig2 = num % 100;
            string dig1 = "";
            string dig2 = "";
            string dig3 = "";
            switch (_dig1)
            {
                case 1: dig1 = "сто";
                    break;
                case 2:
                    dig1 = "двести";
                    break;
                case 3:
                    dig1 = "триста";
                    break;
                case 4:
                    dig1 = "четыреста";
                    break;
                case 5:
                    dig1 = "пятьсот";
                    break;
                case 6:
                    dig1 = "шестьсот";
                    break;
                case 7:
                    dig1 = "семьсот";
                    break;
                case 8:
                    dig1 = "восемьсот";
                    break;
                case 9:
                    dig1 = "девятьсот";
                    break;
             }

            if (_dig2 > 10 && _dig2 < 20)
            {
                switch (_dig2) 
                {     
                    case 11:
                        Console.WriteLine(dig1 + " одиннадцать");
                        break;
                    case 12:
                        Console.WriteLine(dig1 + " двенадцать");
                        break;
                    case 13:
                        Console.WriteLine(dig1 + " тринадцать");
                        break;
                    case 14:
                        Console.WriteLine(dig1 + " четырнадцать");
                        break;
                    case 15:
                        Console.WriteLine(dig1 + " пятнадцать");
                        break;
                    case 16:
                        Console.WriteLine(dig1 + " шестнадцать");
                        break;
                    case 17:
                        Console.WriteLine(dig1 + " семнадцать");
                        break;
                    case 18:
                        Console.WriteLine(dig1 + " восемнадцать");
                        break;
                    case 19:
                        Console.WriteLine(dig1 + " девятнадцать");
                        break;

                }
            }
            else
            {
                switch (_dig2/10)
                {
                    case 1: dig2 = " десять";
                        break;
                    case 2:
                        dig2 = " двацать";
                        break;
                    case 3:
                        dig2 = " тридцать";
                        break;
                    case 4:
                        dig2 = " сорок";
                        break;
                    case 5:
                        dig2 = " пятьдесят";
                        break;
                    case 6:
                        dig2 = " шестьдесят";
                        break;
                    case 7:
                        dig2 = " семьдесят";
                        break;
                    case 8:
                        dig2 = " восемьдесят";
                        break;
                    case 9:
                        dig2 = " девяносто";
                        break;
                    case 0:
                        dig2 = "";
                        break;
                }

                switch (_dig3)
                {
                    case 0:
                        dig3 = "";
                        break;
                    case 1:
                        dig3 = " один";
                        break;
                    case 2:
                        dig3 = " два";
                        break;
                    case 3:
                        dig3 = " три";
                        break;
                    case 4:
                        dig3 = " четыре";
                        break;
                    case 5:
                        dig3 = " пять";
                        break;
                    case 6:
                        dig3 = " шесть";
                        break;
                    case 7:
                        dig3 = " семь";
                        break;
                    case 8:
                        dig3 = " восемь";
                        break;
                    case 9:
                        dig3 = " девять";
                        break;
                }
                Console.Write(num > 999 || num < 100 ? "Ошибка" : dig1 + dig2 + dig3);
            }
            
        }
    }
}
