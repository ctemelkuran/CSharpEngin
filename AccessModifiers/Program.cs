using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // private < protected < internal < public

    // private: tanımlandığı blok
    // protected: inheritance'da 
    // internal: mevcut assembly, projede
    // public: herhangi bir projede
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
            // Id kullanılabilitor
        }
    }

    // bir class ın default u internal dır
    // bağlı bulunduğu proje, assembly içinde referans ihtiyacı olmadan kullanabiliriz
    // class private, protected OLAMAZ, iç içe olursa ancak
    // class internal, public OLUR
    public class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {
            // sadece nested ise private olabilir
        }
    }
}
