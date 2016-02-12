using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Please enter a temperature");
                int temp = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("You entered " + temp);

            }
            catch (Exception error)
            {
                System.Console.WriteLine("invalid response: " + error);
            }
            finally 
            {
                System.Console.WriteLine("Thanks for using this program!");
            }
          
            System.Console.ReadLine();


        }
    }
}
