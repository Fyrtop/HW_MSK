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
            Book book = new Book("M&M", "Bulg-v", 1938, "500");
            book.GetInfo();
        }
    }

    class Book
    {
        private string _title;
        private string _author;
        public int Year { get; set; }
        public string Pages { get; set; }
        public Book(string title, string author, int year, string pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }

        public void GetInfo()
        {
            Console.Write($"{_title}, {_author}, {Year}, {Pages} стр.");
        }
    }
}
