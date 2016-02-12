using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            withdraw();
        }
        static void withdraw()
        {
            double total = 1000;
            while (true)
            {
                System.Console.Write("Please enter the amount of money you wish to withdraw: ");

                double withdraw = Convert.ToDouble(System.Console.ReadLine());

                if (withdraw == total)
                {
                    bool response = true;
                    total = 0;
                    System.Console.WriteLine(" Your account has $" + total + " funds currently there is a $5 dollar fee for an account with $0. Is that okay with you? (y/n) ");
                    String answer = System.Console.ReadLine();

                    if (answer.Equals("y"))
                    {
                        response = false;
                        withdraw -= 5;
                        System.Console.WriteLine("You have taken out " + withdraw + " your account has " + total + " funds left in it.");
                    }
                    else if (answer.Equals("n"))
                    {
                        response = true;
                        System.Console.WriteLine("Please withdraw a smaller amount then.");
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid response recieved");
                    }
                }
                else if (withdraw > total)
                {
                    
                    System.Console.WriteLine("You are not permitted to take this amount out of your account.");
                }
                else
                {
                    total -= withdraw;
                    System.Console.WriteLine("Your account has $" + total + "left in it and you withdrawn $" + withdraw);
                }
            }
        }
    }
}
