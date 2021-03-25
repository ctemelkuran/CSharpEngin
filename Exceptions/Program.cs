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

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
            
            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Çığır", "Fatma", "Zeytin" };
            if (!students.Contains("Arven"))
            {
                throw new RecordNotFoundException();
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
