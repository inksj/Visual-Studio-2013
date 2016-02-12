using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Car
    {
        public string type; //this could be used to specify if it's a suv/sedan/truck
        public string color;
        public int numOfDoors;
        public string brand;
        public int year;
        public double price;

        public double sellCar(int amount)
        {
            return this.price * amount;
        }
    }
}
