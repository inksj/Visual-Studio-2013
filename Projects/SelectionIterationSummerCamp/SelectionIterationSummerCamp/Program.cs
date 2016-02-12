using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionIterationSummerCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("This program allows you to enter information to determine what camp \n activity to do. Type 'q' to quit. \n");
            campConditions();
            System.Console.ReadLine();
        }
            
            
            static void campConditions()
            {
            System.Console.WriteLine("What's the temperature outside?");
             string temp = System.Console.ReadLine();
            
                 System.Console.Write("Is the water warm enough? (y/n)");
             string water = System.Console.ReadLine();


             if (temp != "q")
             {
                 if (water != "q")
                 {
                     double temp2 = double.Parse(temp);

                     if ((temp2 > 80) && (water.Equals("y")))
                     {
                         System.Console.WriteLine("Go swimming");
                         campConditions();

                     }
                     else if (water.Equals("no") && temp2 > 70)
                     {
                         System.Console.WriteLine("Play soccer");
                         campConditions();
                     }


                     else
                     {
                         System.Console.WriteLine("Play frisbee");
                         campConditions();
                     }
                 }
                 System.Console.ReadLine();

             }
        }
    }
}
