using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Puff", "white", 2);
            Cat cat1 = new Cat("Bubu");
            cat.Age = -10;
            //cat.Say();
            Console.Write(cat.ToString());
        }
    }

    class Cat
    {
        public const int countpaw = 4;
        public readonly bool fur = true;

        public string Name { get; set; }
        public string Color { get; set; }
        int age;

        public int Age
        {
            set { if (value > 0) this.age = value; else age = 0; }
            get { return age; }
        }

        public Cat(string name, string color = "brown", int age = 1, bool fur = true)
        {
            Name = name;
            Color = color;
            Age = age;
            this.fur = fur;
        }

        public void SetAge(int age)
        { if (age < 0) this.age = 0; }
        public override string ToString()
        {
            return $"{Name}, {Color}, {Age}";
        }

    }
}
