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
        //method that search by name for SearchProducts
        public List<Product> GetByName(string key)
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                //Where() Linq 'e ait bir IQueryable

                return context.Products.Where(p => p.Name.Contains(key)).ToList(); 
            }
        }
        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                //Veri tabanına SQL sorgusunu atıp sadece WHERE ile ihtiyaç olan gelir

                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                //Veri tabanına SQL sorgusunu atıp sadece WHERE ile ihtiyaç olan gelir

                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }
        public Product GetById(int id)
        {
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                //EntityFramework'te tabloya erişim kodu bu kadar
                //var result = context.Products.SingleOrDefault(p=>p.Id == id);
                var result = context.Products.FirstOrDefault(p=>p.Id == id);
                return result;
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
