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

            //int number1; // out ile değer atamaya gerek yok, ref'te atanmalı
            //int number2 = 50;
            //var result2 = Subtract(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //Console.WriteLine(Multiply(10, 2));
            //Console.WriteLine(Multiply(10, 2, 10));

            //Console.WriteLine(Add(2, 3, 4, 5, 6, 7));

            Console.ReadLine();
        }

        static int Add(int number1, int number2 = 20) // değer verilmezse default değeri kullanır
        { // default değer metodun en sonunda konur
            var result = number1 + number2;
            return result;
        }

        //değer methodta değişebilir ve bunu kabul ediyorsan ref veya out keyword
        static int Subtract(out int number1, int number2)
        {
            number1 = 100; // out kullanırsan method içinde set edilmeli
            return number1 - number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // method overloading
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params ile methoda istenilen miktarda parametre girilebilir
        static int Add(int specialNumber, params int[] numbers) // params methodun son parametresi olmalı
        {
            Console.WriteLine(specialNumber);
            return numbers.Sum();
        }
    }
}
