using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Çığır",
                Address = "Izmir"
            };

            manager.Add(customer);
        }

        //Interface: temel nesne ile bütün nesneleri ondan implemente etmek için.
        interface IPerson //abstract, soyut nesne
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}
