using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            Conditions();
            System.Console.ReadLine();
        }


        static void Conditions()
        {
            System.Console.WriteLine("What's your years of expirence?");
            double years = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("do you have a degree acquired in field?");
            string degree = System.Console.ReadLine();

            System.Console.Write("Score form your online exam:");
            double score = Convert.ToDouble(System.Console.ReadLine());

        

            bool chance1 = (degree =="y" && score >=25);

            bool chance2 = (years>=3 && score>28 );

            bool chance3 = (score >= 30);

            bool chance4 = (years>= 5 && score>= 25 );


            if (chance1)
            {

                System.Console.WriteLine("you get a phone call!");

                if (chance4)
                {

                    System.Console.WriteLine("you get a phone call!");
                }

            }
            else if (chance2)
            {

                System.Console.WriteLine("you get a phone call!");

            }
            else if (chance3)
            {

                System.Console.WriteLine("you get a phone call!");

                if (chance4)
                {

                    System.Console.WriteLine("you get a phone call! ");
                }

            }
            else if (chance4)
            {

                System.Console.WriteLine("you get a phone call! ");

            }
            else
            {

                System.Console.WriteLine("Sorry no phone interview for you");

            }

            System.Console.ReadLine();
        }

    }
}