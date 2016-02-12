using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            block();
            System.Console.Read();
        }
        static void password()
        {
            int numOfTries = 5;
            string password = "";

            while ((password != "supersecret"))
            {

                System.Console.Write("Please enter the password: " + numOfTries + " Tries left.");
                password = System.Console.ReadLine();
                numOfTries--;
                if (numOfTries < 0)
                {
                    System.Console.WriteLine("Too many tries");
                    block();
                    System.Console.WriteLine("You have been blocked out of the system.");
                }
               
            }
            if (password == "supersecret")
            {
                System.Console.WriteLine("Access Granted.");
            }
        }

        static void block()
        {
            password();
           
          
           
        }
    }
}

