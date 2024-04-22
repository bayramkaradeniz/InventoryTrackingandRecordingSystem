using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.Abstract
{
    public interface ICompanyService
    {
        string GetAdminMail();
        void Update(Company company);
    }
}
