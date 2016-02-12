using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
        
            System.Console.WriteLine("Number of Students: ");
            int numStudents = Convert.ToInt32(System.Console.ReadLine());

            int i=0;
            while (i < numStudents)
            {
                System.Console.WriteLine("Name of student:");
                string name = System.Console.ReadLine();

                students.Add(name);
                i++;
            }
            System.Console.WriteLine("-----Results-----");
            foreach (string names in students)
            {
            
                System.Console.WriteLine(names);
            }
            System.Console.ReadLine();
                System.Console.WriteLine("do you want to remove any names form the list so far? (y/n)");
                String answer = System.Console.ReadLine();

                if (answer.Equals("y"))
                {
                    System.Console.WriteLine("What name do you want to remove?");
                    String remove = System.Console.ReadLine();
                    System.Console.WriteLine("-----Results-----");
                    students.Remove(remove);
                }
                
                else
                {
                    foreach (string names in students)
                    {

                        System.Console.WriteLine("-----Results-----");
                        System.Console.WriteLine(names);
                    }
                    System.Console.ReadLine();
                }
               
                //for (int index = 0; index < colors.Count; index++)
                // {
                //   System.Console.WriteLine(colors[index]);
                // }
              
            
            foreach (string names in students)
            {

            
                System.Console.WriteLine(names);
            }
            System.Console.ReadLine();
        }
    }
}
