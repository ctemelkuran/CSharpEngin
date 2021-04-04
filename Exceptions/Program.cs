using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptioIntro();

            //TryCatch();

            // Lambda : =>
            // C# ile methoda parametre olarak method gönderilebilir
            //ActionDemo();

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        // bu bir kez yazılsa yeterli
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Çığır", "Fatma", "Zeytin" };
            if (!students.Contains("Arven"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }

        private static void ExceptioIntro()
        {
            try
            {
                string[] students = new string[3] { "Çığır", "Fatma", "Zeytin" };
                students[3] = "Arven";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                //Console.WriteLine(exception.InnerException);

            }
        }
    }
}
