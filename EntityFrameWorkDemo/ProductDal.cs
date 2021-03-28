using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                //context.Products.Add(product); veya şu şekilde:
                var entity = context.Entry(product);
                entity.State = EntityState.Added;

                context.SaveChanges(); //ExecuteNonQuery yerine Entity'den savechanges çağırıyoruz
            }
        }
        public void Update(Product product)
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified; //state is modified

                context.SaveChanges(); 
            }
        }
        public void Delete(Product product)
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted; //state is modified

                context.SaveChanges();
            }
        }
    }
}
