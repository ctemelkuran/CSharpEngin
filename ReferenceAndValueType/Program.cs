using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstracts like: class and string are reference type
            // bool, double, int value type
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            Console.ReadLine();
        }
    }
}
