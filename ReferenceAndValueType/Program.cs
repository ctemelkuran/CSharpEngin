using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstracts like: class, arrays and string are reference type
            // bool, double, int value type
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] {"Ankara" +
                "Adana" +
                "Afyon"};

            string[] cities2 = new string[] {"Bursa" +
                "Balıkesir" +
                "Bolu"};

            cities2 = cities1;
            cities1[0] = "İzmir";

            Console.WriteLine(cities2[0]);

            //DataTable dataTable; // no need to create new instance
            //DataTable dataTable2 = new DataTable(); //new is expensive for memory
            //dataTable2 = dataTable;

            Console.ReadLine();
        }
    }
}
