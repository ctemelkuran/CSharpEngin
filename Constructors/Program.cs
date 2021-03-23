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
            customerManager.List();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15; // private field _ ile başlar, parametre verilmezse 15
        public CustomerManager(int count) // method içinde _ kullanılmaz
        {
            _count = count;
        }

        public CustomerManager() // parametre yoksa bunu kullanır
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items!", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}
