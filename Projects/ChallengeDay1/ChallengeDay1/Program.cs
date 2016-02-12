using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            question();
        }
           static void question()
        {
            int score = 0;
               bool response = true;
               while (response)
               {
                   System.Console.WriteLine("Is the capital of Ohio, Columbus? (t/f)");
                   String answer = System.Console.ReadLine();


                   if (answer.Equals("t"))
                   {
                       response = true;
                       score++;
                   }
                   else if (answer.Equals("f"))
                   {
                       response = false;
                       score--;
                   }
                   else
                   {
                       System.Console.WriteLine("Invalid response recieved");
                       score--;
                   }
               
             
                
                   System.Console.WriteLine("The first President of the United States was George Clooney? (t/f)");
                   String answer2 = System.Console.ReadLine();

                   if (answer2.Equals("t"))
                   {
                       response = false;
                       score--;
                   }
                   else if (answer2.Equals("f"))
                   {
                       response = true;
                       score++;
                   }
                   else
                   {
                       System.Console.WriteLine("Invalid response recieved");
                       score--;
                   }

                
           
                    System.Console.WriteLine("Below Freezing temperature is 32 degrees (t/f)");
                   String answer3 = System.Console.ReadLine();

                   if (answer3.Equals("t"))
                   {
                       response = true;
                       score++;
                   }
                   else if (answer3.Equals("f"))
                   {
                       response = false;
                       score--;
                   }
                   else
                   {
                       System.Console.WriteLine("Invalid response recieved");
                       score--;
                   }

                   System.Console.WriteLine("This program is stupid (t/f)");
                   String answer4 = System.Console.ReadLine();

                   if (answer4.Equals("t"))
                   {
                       response = true;
                       score++;
                   }
                   else if (answer4.Equals("f"))
                   {
                       response = false;
                       score--;
                   }
                   else
                   {
                       System.Console.WriteLine("Invalid response recieved");
                       score--;
                   }

                   System.Console.WriteLine("Hyland released OnBase15 this past february.  (t/f)");
                   String answer5 = System.Console.ReadLine();

                   if (answer5.Equals("t"))
                   {
                       response = true;
                       score++;
                   }
                   else if (answer5.Equals("f"))
                   {
                       response = false;
                       score--;
                   }
                   else
                   {
                       System.Console.WriteLine("Invalid response recieved");
                       score--;
                   }
                   System.Console.WriteLine("Your total score is " + score + " correct questions out of 5 questions.");
                  
               }
             
           }

        
    }
}
