using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "İstanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>
                (new Customer { FirstName = "Çığır" }, new Customer { FirstName = "Fatma" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    interface IProductDal : IRepository<Product>
    {
        //List<Product> GetAll();
        //Product Get(int id);
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);


    }

    public class Product : IEntity
    {
    }
    public class Customer : IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal : IRepository<Customer>
    {
        //void Custom();
    }
    interface IEntity
    {

    }
    // Generic nesne, interface olması gerekmez, class veya abstract class da olur
    //T: Type
    //değer tipi ile kısıtlama = where T:struct
    interface IRepository<T> where T : class, IEntity, new() //T'yi kısıtlayabiliriz, class referans tip demektir string olur, int olmaz
    {                                      //sadece class istiyorsak ,new() ekleriz                         
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal //Direkt IRepository<Customer> da kullanabilirdik ama ICustomerDal'a özel method ekleyemeyiz.
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
