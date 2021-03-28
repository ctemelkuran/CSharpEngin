using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                //EntityFramework'te tabloya erişim kodu bu kadar

                return context.Products.ToList();
            }
        }
        public void Add(Product product)
        {
            // using kullanarak Garbage Collector beklemeden nesneyi bellekten atıyoruz
            // çünkü context pahalı bir nesne, IDisposable interface i .Net'e ait
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                context.Products.Add(product);

                context.SaveChanges(); //ExecuteNonQuery yerine Entity'den savechanges çağırıyoruz
            }
        }
    }
}
