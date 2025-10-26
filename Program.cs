using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:Класс Book");
            Book book1 = new Book("Война и мир", 1200);
            Book book2 = new Book("1984");
            Book book3 = new Book();
            book1.Read();
            book2.Read();
            book3.Read();
            Book testBook = new Book("абвгд",0);
            
            Console.WriteLine("\nЗадание 2:Класс Employee");
            Employee emp1 = new Employee("Максим", 999999);
            Employee emp2 = new Employee("Наташа");
            emp1.Work();
            emp2.Work();
            Employee testEmp = new Employee("Матвей", -100000000000);

            Console.WriteLine("\nЗадание 3:Классы Device и Laptop");
            Laptop laptop = new Laptop("Dell", 32, 65);
            laptop.PowerOn();
            laptop.Work();
            Laptop testLaptop = new Laptop("Test", 128, 99);

            Console.WriteLine("\nЗадание 4:Класс Point");
            Point point1 = new Point(4.7, 6.3);
            Point point2 = new Point(7);
            Point point3 = new Point();
            point1.Show();
            point2.Show();
            point3.Show();

            Console.WriteLine("\nЗадание 5:Классы Animal и Cat");
            Cat cat1 = new Cat("Белок", 9);
            Cat cat2 = new Cat("Барсик");
            cat1.Speak();
            cat1.Meow();
            cat2.Speak();
            cat2.Meow();
            Console.ReadLine();
        }
    }
}
