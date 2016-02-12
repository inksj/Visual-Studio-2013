using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
          {
        
            //LAb 1
              
           
              System.Console.Write("Please enter your age in years: " );
               
             double ageInYears = Convert.ToDouble(System.Console.ReadLine());
                //Converts String to double
               
                //  int ageInYears = Convert.ToInt32(System.Console.ReadLine());
                //Converts String to Int

             ageInYears = ageInYears * 365.25;

             System.Console.WriteLine("You are " + ageInYears + " days old.");
              //Persists the terminal window
             System.Console.ReadLine();
               


              //Lab 2

               /*
              int pi = 22 / 7;
              System.Console.WriteLine(" The approximation of pi is: " + pi);
              System.Console.ReadLine();
                */ 
        }
             
    }
}
