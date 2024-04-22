using Itrs.Business.Abstract;
using Itrs.Business.Concrete;
using Itrs.DataAccess.Abstract;
using Itrs.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.DependencyRevolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ILogEntryService>().To<LogEntryManager>().InSingletonScope();
            Bind<ILogEntryDal>().To<EfLogEntryDal>().InSingletonScope();

            Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();
            Bind<ICompanyDal>().To<EfCompanyDal>().InSingletonScope();

            Bind<IMailService>().To<MailManager>().InSingletonScope();
            Bind<IMailDal>().To<EfMailDal>().InSingletonScope();
        }
    }
}
