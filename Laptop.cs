using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Laptop : Device
    {
        private int ram;
        private int battery;

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 1 || value > 64)
                {
                    Console.WriteLine("ОЗУ должно быть от 1 до 64!");
                }
                else
                {
                    ram = value;
                }
            }
        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд батареи должен быть от 0 до 100%!");
                }
                else
                {
                    battery = value;
                }
            }
        }
        public Laptop(string brand, int ram, int battery) : base(brand)
        {
            Ram = ram;
            Battery = battery;
        }

        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");
        }
    }
}
