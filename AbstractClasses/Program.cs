using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses // AMAÇ interface ve virtual method ile aynı
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
    }
}
