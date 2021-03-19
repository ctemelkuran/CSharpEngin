using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();



            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Izmir";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Çığır",
                LastName = "Temelkuran"
            };

            Console.WriteLine(customer2.FirstName + " " + customer2.LastName + "is from" + customer2.City);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }

}
