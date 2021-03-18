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

            // var result = Add(20);

            int number1 = 200;
            int number2 = 50;
            var result2 = Subtract(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static int Add(int number1, int number2 = 20) // değer verilmezse default değeri kullanır
        { // default değer metodun en sonunda konur
            var result = number1 + number2;
            return result;
        }

        static int Subtract(ref int number1, int number2)
        {
            number1 = 100; //değer methodta değişebilir ve bunu kabul ediyorsan ref keyword
            return number1 - number2;
        }
    }
}
