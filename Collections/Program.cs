using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList ve List array bazlıdır

            //ArrayList();

            //I can only work with string in this collection
            List<string> cities = new List<string>();
            cities.Add("Izmir");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            // List içine class alabilir
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Cigir" });
            //customers.Add(new Customer { Id =2, FirstName = "Fatma" });


            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Cigir" },
                new Customer { Id = 2, FirstName = "Fatma" }
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }



            Console.ReadLine();
        }

        private static void ArrayList()
        {
            //array nerdeyse kullanılmıyor, ArrayList daha işlevli
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Izmir");
            cities.Add(1);
            cities.Add("A");
            //type safe çalışma durumu yoksa arraylist is better
            //genelde type safe çalışır koleksiyon kullanılırız
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
