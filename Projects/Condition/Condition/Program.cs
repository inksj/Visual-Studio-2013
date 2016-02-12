using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {

        static void checkForRain()
        {

            System.Console.Write("Is it raining outside? (y/n): ");
            string resp = System.Console.ReadLine();

            //bool raining = resp.Equals("y");
            bool raining = (resp == "y");

            if (raining)
            {
                System.Console.WriteLine("Take an umbrella!");
          

            }
            else if (resp == "n")
            {
                System.Console.WriteLine("Enjoy your day!");
               
            }
            else
            {
                System.Console.WriteLine("Invalid response: try again");
                
                checkForRain();//Recursion calls the method again and makes the user input a suffient answer

            }
            System.Console.WriteLine("It is raining outside: " + raining);
            System.Console.ReadLine();

        }
        static void Main(string[] args)
        {
            checkForRain();
         
            
        }
    }
}
