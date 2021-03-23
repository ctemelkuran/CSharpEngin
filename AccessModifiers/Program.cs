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
        int id;
    }

    class Student
    {
        public void Save()
        {
            Customer customer = new Customer();
            
        }
    }
}
