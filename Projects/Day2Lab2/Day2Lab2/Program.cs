using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Number of Students: ");
            int numStudents = Convert.ToInt32(System.Console.ReadLine());
            int i=0;
            while(i<numStudents)
            {

            System.Console.WriteLine("First Name of student"+ numStudents +":");
            string first = System.Console.ReadLine();

            System.Console.Write("Last Name of student" + numStudents + ":");
            string last = System.Console.ReadLine();

            System.Console.Write("Score on testof student" + numStudents + ":");
           double score = Convert.ToDouble(System.Console.ReadLine());
                
            string s = passOrFail(score);
            string n = createName(first, last);
    
            System.Console.WriteLine( n +" "+ s);
            System.Console.ReadLine();
            numStudents--;
            }
        }
          
      
        
        static string createName(string firstName, string lastName)
            {
                string nameString = firstName +" " +lastName;
                return nameString;
            }

        static string passOrFail( double grade )
                {
                    if(grade >70)
                    {
                       string score ="Pass";
                        return score;
                    }
                    else
                         {
                       string score ="Fail";
                        return score;
                    }

                }
        


        }

    }

