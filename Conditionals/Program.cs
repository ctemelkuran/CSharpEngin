using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Not 10 or 20");
            }

            // Single-line if
            Console.WriteLine(number == 12 ? "Number is 12" : "Number is not 12");

            Console.ReadLine();
        }
    }
}
