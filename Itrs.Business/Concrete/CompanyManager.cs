using Itrs.Business.Abstract;
using Itrs.DataAccess.Abstract;
using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }



        public string GetAdminMail()
        {
            var kullanici = _companyDal.GetAll().FirstOrDefault(k => k.AdminId == 1);
            return kullanici.AdminMail; ;
        }


        public void Update(Company company)
        {
            _companyDal.Update(company);
        }
    }
}
