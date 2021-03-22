using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses // AMAÇ interface ve virtual method ile aynı
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface ve abstractlarla new yapılamıyor
            Database oracleDatabase = new Oracle();
            oracleDatabase.Add();
            oracleDatabase.Delete();

            Database sqlDatabase = new SqlServer();
            sqlDatabase.Add();
            sqlDatabase.Delete();

            Console.Read();
        }
    }

    abstract class Database
    {
        //Örneğin databaselerde ekleme işlemleri aynı silmeler farklı ise
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    //abstract içi dolu olmayan virtual methodtur
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }

}
