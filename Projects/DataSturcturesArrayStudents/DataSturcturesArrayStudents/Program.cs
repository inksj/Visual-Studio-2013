using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSturcturesArrayStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];

            students[0] = "Caitlin";
            students[1] = "Hon"; 
            students[2] = "Julia"; 
            students[3] = "Adam";
            students[4] = "Micheal";
            System.Console.WriteLine(students[3]);


            for (int index = 0; index < students.Length; index++)
            {
                System.Console.WriteLine("Student " + index + " is " + students[index]);
            }
            System.Console.ReadLine();
        }
    }
}
