using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Book
    {
        private string title;
        private int pages;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 1 || value > 5000)
                {
                    Console.WriteLine("Страниц должно быть от1 до 5000!");
                }
                else
                {
                    pages = value;
                }
            }
        }
        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public Book(string title) : this(title, 111)
        {
        }
        public Book() : this("Без названия ", 1)
        {
        }
        public void Read()
        {
            Console.WriteLine($"Читаю книгу \"{Title}\", страниц: {Pages}.");
        }
    }
}
