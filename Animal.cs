using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string name)
        {
            Name = name;
        }
        public void Speak()
        {
            Console.WriteLine($"{Name} издаёт звук.");
        }
    }
}
