using Itrs.DataAccess.Abstract;
using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ItrsContext>, IProductDal
    {
        public void ChangeStock(Product product)
        {
            using (var context = new ItrsContext())
            {
                var productOne = context.Products.FirstOrDefault(u => u.ProductId == product.ProductId);

                productOne.StockAmount = product.StockAmount;
                context.SaveChanges();
            }
        }

        public void ChangeUnitPrice(Product product)
        {
            using (var context = new ItrsContext())
            {
                var productOne = context.Products.FirstOrDefault(u => u.ProductId == product.ProductId);

                productOne.UnitPrice = product.UnitPrice;
                context.SaveChanges();
            }
        }
    }
}
