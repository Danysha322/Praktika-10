using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Cat : Animal
    {
        private int lives;

        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1 || value > 9)
                {
                    Console.WriteLine("Количество жизней должно быть от 1 до 9");
                }
                else
                {
                    lives = value;
                }
            }
        }
        public Cat(string name, int lives) : base(name)
        {
            Lives = lives;
        }
        public Cat(string name) : this(name, 9)
        {
        }

        public void Meow()
        {
            if (Lives > 1)
            {
                Lives--;
                Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}!");
            }
            else
            {
                Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}! Кот использует последнюю жизнь!");
            }
        }
    }
}
