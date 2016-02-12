using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Lab3
{
   class Button 
        {
            public string partNumber;
            public string description;
            public int numOfButtons;
            public double priceOfButton;


            public  double placeOrder(int amount)
            {
                return this.priceOfButton * amount;
            }
         
       public void priceUpdate(double newPrice)
            {
                if ((newPrice / this.priceOfButton) > .25)
                {
                    System.Console.WriteLine("There is a price increase in this order.");
                }
                else
                {
                     this.priceOfButton = newPrice;
                    System.Console.WriteLine(this.priceOfButton=newPrice);
                }
            }
            public void stockCheck(int amount)
                {
                    if (amount > this.numOfButtons)
                    {
                        System.Console.WriteLine("Order cannot be placed because you exceeded  the inventory");
                    }
                    else
                    {
                       System.Console.WriteLine( this.numOfButtons = amount);

                    }
                }

        }
}