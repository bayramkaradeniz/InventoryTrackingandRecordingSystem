using Itrs.DataAccess.Abstract;
using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.DataAccess.Concrete
{
    public class EfMailDal : EfEntityRepositoryBase<Mail, ItrsContext>, IMailDal
    {

    }
}
