using Itrs.DataAccess.Abstract;
using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.DataAccess.Concrete
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, ItrsContext>, ICompanyDal
    {

    }
}
