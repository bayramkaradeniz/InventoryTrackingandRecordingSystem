using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Business.Abstract
{
    public interface IMailService
    {
        List<Mail> GetAll();
        void LogMail(Mail mail);
        void LogMailForAdd(Mail mail);
        Task SendMailAsync(string email, string message);
    }
}
