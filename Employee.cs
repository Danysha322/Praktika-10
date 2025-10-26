using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Employee
    {
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Зарплата не может быть отрицательной!");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public Employee(string name) : this(name, 670000)
        {
        }
        public void Work()
        {
            Console.WriteLine($"{Name} работает. зарплата: {Salary}.");
        }
    }
}
