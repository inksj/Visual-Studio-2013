using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            password();
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
                if ( numOfTries > 5)
                {
                    System.Console.WriteLine("Too many tries");
                    break;
                }
               
            }
            if (password == "supersecret")
            {
                System.Console.WriteLine("Access Granted.");
            }
            
        }
        }
    }

