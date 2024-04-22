using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Itrs.Business.Abstract;
using Itrs.DataAccess.Abstract;

namespace Itrs.Business.Concrete
{
    public class MailManager : IMailService
    {
        private IMailDal _mailDal;
        public MailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public List<Mail> GetAll()
        {
            return _mailDal.GetAll();
        }

        public void LogMail(Mail mail)
        {
            mail.SenderMail = "YourRecevierMail";
            mail.Subject = "Subject";

            _mailDal.Add(mail);
        }

        public void LogMailForAdd(Mail mail)
        {
            mail.SenderMail = "YourRecevierMail";
            mail.Subject = "Subject";

            _mailDal.Add(mail);
        }

        public Task SendMailAsync(string email, string message)
        {

            var mail = "YourRecevierMail";
            var pw = "YourPassWord";
            var subject = "Subject";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };
            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));

        }


    }
}
