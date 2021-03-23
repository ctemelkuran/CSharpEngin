using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
 
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            // static nesneler ortaktır, genelde uzakta dururuz
            Teacher.Number = 10;

            Utilities.Validate();

            Manager.Method1(); // static
            Manager manager = new Manager(); // static değil
            manager.Method2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15; // private field _ ile başlar, parametre verilmezse 15
        public CustomerManager(int count) // method içinde _ kullanılmaz
        {
            _count = count;
        }

        public CustomerManager() // parametre yoksa bunu kullanır
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items!", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }


    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to db!");
        }

    }


    class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager: BaseClass
    {
        public PersonManager(string entity):base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }
    //static class veya method olabilir
    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 is done");
        }
        public void Method2()
        {
            Console.WriteLine("Method2 is done");
        }
    }
}
