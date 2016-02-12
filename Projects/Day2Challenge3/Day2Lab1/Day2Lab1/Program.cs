using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab1
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            campConditions();
            System.Console.ReadLine();
        }
            
            
            static void campConditions()
            {
             System.Console.WriteLine("What's the temperature of the water?");
                double waterTemp = Convert.ToDouble(System.Console.ReadLine());

            System.Console.WriteLine("What's the temperature of the air?");
             double airTemp =  Convert.ToDouble(System.Console.ReadLine());
            
                 System.Console.Write("Give the probality of rain in percentage");
             double rainProb = Convert.ToDouble(System.Console.ReadLine());

                    System.Console.Write("What time of day is it in military time? PLease do not use ':' just write it like so '1200'.");
             int time =  Convert.ToInt32(System.Console.ReadLine());

             bool swim = (time >= 12 && time < 16) && (waterTemp > 70) && (airTemp > 80) && (rainProb < 0.3);

             bool soccer = (airTemp > 60) && (rainProb < 0.5) && (time >= 10 && time < 18);

             bool boardGames = (rainProb > 0.6) || (time > 18);

             bool movies = (time > 20);


             if (swim)
             {

                 System.Console.WriteLine("Go swimming");

                 if (soccer)
                 {

                     System.Console.WriteLine("Play soccer");
                 }

             }
             else if (soccer)
             {

                 System.Console.WriteLine("Play soccer");

             }
             else if (boardGames)
             {

                 System.Console.WriteLine("Play board games ");

                 if (movies)
                 {

                     System.Console.WriteLine("Watch movies ");
                 }

             }
             else if (movies)
             {

                 System.Console.WriteLine("Watch movies ");

             }
             else
             {

                 System.Console.WriteLine("We have no advice for you");

             }

             System.Console.ReadLine();
            }

             }
        }
    

