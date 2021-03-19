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
        }

        //Interface: temel nesne ile bütün nesneleri ondan implemente etmek için.
        interface IPerson //abstract, soyut nesne
        {
            int Id { get; set; }
            int FirstName { get; set; }
            int LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string Departmant { get; set; }
        }

    }
}
