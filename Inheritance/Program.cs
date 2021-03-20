using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Cigir"},
                new Student{FirstName="Zeytin"},
                new Person{FirstName="Fatma"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    //Interface'in aktinse abstract olmadığı için tek başına da intance tanımlanır.
    class Person //Parent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    //Bir nesne bir Parent alır, birden fazla Interface alabilir
    //Önce Inheritance sonra Interface classa yazılabilir(: Person, IPerson, ICustomer...)
    class Customer:Person //Child of Person
    {
        public string City { get; set; }
    }

    class Student: Person //Child of Person
    {
        public string Department { get; set; }
    }
}
