using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "George";
            string last = "Washington";
            string s = createNameString(first, last);
    
            System.Console.WriteLine(s);
            System.Console.ReadLine();
        }
        
        static string createNameString(string firstName, string lastName)
            {
                string nameString = firstName +" " +lastName;
                return nameString;
            }
        
    }
}
