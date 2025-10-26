using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Device
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Device(string brand)
        {
            Brand = brand;
        }

        public void PowerOn()
        {
            Console.WriteLine($"{Brand} включён.");
        }
    }
}
