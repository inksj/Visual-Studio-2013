using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge7
{
    class Program
    {
        static void Main(string[] args)
        {
            runTracker();
        }
        static void runTracker()
        {
          //double timeTotal=;
             // double distanceTotal;
              //int diffcultyTotal;
            while (true) 
            {  
            System.Console.Write("Please enter the number of the runs you completed: ");
            int runs = Convert.ToInt32(System.Console.ReadLine());
            
            while (runs >= 1)
            {
                System.Console.Write("Please enter the distance ran in miles: ");
                double timeRan = Convert.ToDouble(System.Console.ReadLine());
                System.Console.Write("Please enter the time it took to run the distance in minutes: ");
                double distanceRan = Convert.ToDouble(System.Console.ReadLine());
                 System.Console.Write("Please enter the difficulty of your run from 1 to 5: ");
                double difficulty = Convert.ToDouble(System.Console.ReadLine());

                System.Console.WriteLine("Run " + runs);
                System.Console.WriteLine("Time: " + timeRan);
                System.Console.WriteLine("Distance: " + distanceRan);
                 System.Console.WriteLine("Difficulty: " + difficulty);
                 runs--; 
                
                 
            }

             }


            }
        }
    }

