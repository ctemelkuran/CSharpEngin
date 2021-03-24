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

            //List();



            Console.ReadLine();
        }

        private static void List()
        {
            //I can only work with string in this collection
            List<string> cities = new List<string>();
            cities.Add("Izmir");

            //Console.WriteLine(cities.Contains("Ankara"));

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            // List içine class alabilir
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Cigir" });
            //customers.Add(new Customer { Id =2, FirstName = "Fatma" });


            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Cigir" },
                new Customer { Id = 2, FirstName = "Fatma" }
            };



            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Zeytin"
            };
            customers.Add(customer2);

            //AddRange ile liste eklenebilir
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4, FirstName="Arven"},
                new Customer{Id = 5, FirstName="Jon"}
            });



            //customers.Clear listedeki elemanları siler

            var index = customers.IndexOf(customer2); // aramaya baştan başlar
            customers.Add(customer2);
            var lastIndex = customers.LastIndexOf(customer2); // aramaya sondan başlar
            //Console.WriteLine("Index : {0}", lastIndex);

            customers.Insert(0, customer2);

            customers.Remove(customer2); // ilk bulduğunu siler
            customers.RemoveAll(c => c.FirstName == "Zeytin"); //predicate bütün bulduklarını siler


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            // Count method
            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
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
