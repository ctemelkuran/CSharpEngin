using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "Hello world";
            //Console.WriteLine(sentence.Length);

            var result = sentence.Clone();

            bool IsEndsWith = sentence.EndsWith("a");

            var result2 = sentence.IndexOf(" ");
            var result3 = sentence.LastIndexOf(" ");
            var result4 = sentence.Insert(sentence.Length, " how are you?");
            var result5 = result4.Substring(12, 3);
            var result6 = sentence.ToLower();
            var result7 = sentence.Replace(" ", "-");
            var result8 = sentence.Remove(5, 6);

            Console.WriteLine(result8);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Izmir";
            string result = city + city2; //strings can be added

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
