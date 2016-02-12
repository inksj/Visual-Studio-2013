using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.type="Jeep Liberty";
            car1.color="white";
            car1.numOfDoors=4;
            car1.year=2007;
            car1.price=10000;
            car1.brand="Jeep";

            Car car2 = new Car();
            car2.type="Silverado";
            car2.color="grey";
            car2.numOfDoors=4;
            car2.year=2013;
            car2.price=24000;
            car2.brand="Chevy";

            double sale = car1.sellCar(3);
            System.Console.WriteLine("You sold 3 " + car1.type + "s for $" + sale );
            System.Console.ReadLine();

        }
    }

}