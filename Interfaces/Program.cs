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
            //InterfacesIntro();

            // Uygulama sadece 1 veritabanına bağlı olmasın diye
            // Katmanlar arası geçiş için interface kullanılabilir
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            
            Console.ReadLine();

        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "cigir",
                Address = "Izmir"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "fatma",
                Departmant = "Nutrition"

            };
            manager.Add(customer);
            manager.Add(student);
        }

        //Interface: temel nesne ile bütün nesneleri ondan implemente etmek için.
        //Inheritance gibi kullanılır
        interface IPerson //abstract, soyut nesne
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set ; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
