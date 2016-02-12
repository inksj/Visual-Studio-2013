using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("blue");
            colors.Add("yellow");

            //for (int index = 0; index < colors.Count; index++)
           // {
             //   System.Console.WriteLine(colors[index]);
           // }

            foreach (string something in colors)
            {
                System.Console.WriteLine(something);
            }
                System.Console.ReadLine();
        }
    }
}
