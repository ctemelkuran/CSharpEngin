using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Dal: Data Access Layer (Ekle, çıkar, update)
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    // Bir projen var ve farklı veri tabanlarını destekliyorsa SQL ve Oracle için ayrı kod yazarsın
    // İkisini de ICustomerDal olarak yazabiliriz
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
