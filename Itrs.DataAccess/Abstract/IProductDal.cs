using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        void ChangeStock(Product product);
        void ChangeUnitPrice(Product product);
    }
}
