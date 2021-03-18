using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = Add(20);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        static int Add(int number1, int number2 = 20) // değer verilmezse default değeri kullanır
        { // default değer metodun en sonunda konur
            var result = number1 + number2;
            return result;
        }
    }
}
