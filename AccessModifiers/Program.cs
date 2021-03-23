using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        // default olarak private dır tanımlandığı blok içinde geçerli
        // protected'ın tek farkı inherited'da kullanılabilir
        protected int Id { get; set; }
        public void Save()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
            I
        }
    }
}
