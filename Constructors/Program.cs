using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed!");
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}
