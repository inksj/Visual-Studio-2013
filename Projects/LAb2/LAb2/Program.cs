using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            runTracker();
        }    
            static void runTracker()
             {      
                bool responseInvalid= true;
                 double averageMile = 0.0;
                 while (true)
                 {
                     System.Console.Write("Please enter the distance ran in miles: ");
                     double timeRan = Convert.ToDouble(System.Console.ReadLine());
                     System.Console.Write("Please enter the time it took to run the distance in minutes: ");
                     double distanceRan = Convert.ToDouble(System.Console.ReadLine());

                     double avg = (distanceRan / timeRan);
                    
                     System.Console.WriteLine("It took approximately  " + Math.Round(avg,2) + " minutes to run a mile.");
             
                 if (averageMile == 0.0)
                 {
                     System.Console.WriteLine("This is your first run, we will store it as your average");
                     averageMile = avg;
                 }
                 else
                 {
                     if (avg < averageMile)
                     {
                         System.Console.WriteLine("Great job, you are running faster!");
                     }
                     else if (avg == averageMile)
                     {
                         System.Console.WriteLine("You are a creature of habit");
                     }
                     else 
                     {
                         System.Console.WriteLine("Keep trying, you will improve your speed with practice.");

                     }
                 }
                 while (responseInvalid)
                 {
                     System.Console.WriteLine("Do you want to store this new run as your average to compare to? (y/n)");
                     String answer = System.Console.ReadLine();

                     if (answer.Equals("y"))
                     {
                         responseInvalid = false;
                         averageMile = avg;
                     }
                     else if(answer.Equals("n"))
                     {
                         responseInvalid=false;
                     }
                     else
                     {
                         System.Console.WriteLine("Invalid response recieved");
                     }
                 }
               }
        }
    }
}
