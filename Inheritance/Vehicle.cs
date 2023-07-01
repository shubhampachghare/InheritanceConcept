using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string brand = "Ford";

        public void Honk()
        {
            Console.WriteLine("Tuee Tueee");
        }
    }

    class Car : Vehicle 
    {
        public string modelName = "Mustang";

    }
}
