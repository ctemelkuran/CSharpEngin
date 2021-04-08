using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Count();
            //DoWhile();
            //ForEachLoop();
            //Console.Write("Enter a number to check prime: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(IsPrimeNumber(input) == true ? "Number is prime" : "Not prime");
            
       


            Console.ReadLine();
        }

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if( i % 3 != 0 || i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    
                }
            }
            return result;
        }


        private static void ForEachLoop()
        {
            string[] students = { "Anan", "Fatma", "Çığır" };

            //tabloda gezinmek, enumarable nesne gezmek
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void doWhile()
        {
            int number = 10;
            do
            {
                Console.WriteLine("Number is {0}", number);
                number--;
            } while (number >= 11);
        }

        private static void Count()
        {
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
