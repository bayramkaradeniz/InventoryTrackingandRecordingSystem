using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        List<Product> GetAll();

        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
        void ChangeStock(Product product);

        void Delete(Product product);
        void ChangeUnitPrice(Product product);
    }
}
