using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
        

            Console.ReadLine();
        }
    }

    class Database
    {
        // interface yerine inheritance ve virtual kullanmak isteyebiliriz
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    // SqlServer için farklı bir içerik lazımsa override  ile virtual method üzerine yazılabilir
    class SqlServer: Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SQL Query");
            base.Add();
        }
    }

    class MySqlServer: Database
    {

    }
}

