using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();

            Console.Read();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    //Bir class ın bir base class ı olmalı, örndeğin loglama işlemi ise
    //Sadece bir class farklı ise interface yerine virtual veya abstract kullanılabilir
    class DatabaseLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    //örneğin önemli logları smsle istiyor
    class SmsLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }

    }
    interface ILogger
    {
        void Log();
    }
}
