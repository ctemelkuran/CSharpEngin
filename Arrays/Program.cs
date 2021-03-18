using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[1];
            //students[1] = "Derin";

            string[] students2 = { "Derin", "Fatma", "asd" };

            foreach (var student in students2)
            {
                //Console.WriteLine(student);
            }
            

            //multi-dimensional array
            string[,] catType = new string[2, 3]
            {
                {"Zeytin", "Smokin","Female" },
                {"Arven", "3 color","Female" }
            };

            // belirtilen dimension uzunluğu
            for (int i = 0; i < catType.GetLength(0); i++)
            {
                //belirtilen dimensionın son elemanın indexi
                for (int j = 0; j <= catType.GetUpperBound(1); j++)
                {
                    Console.WriteLine(catType[i, j]);
                }
                Console.WriteLine("........");
            }

            Console.ReadLine();
        }

    }
}
