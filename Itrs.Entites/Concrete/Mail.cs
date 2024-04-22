using Itrs.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Entites.Concrete
{
    public class Mail : IEntity
    {
        [Key]
        public int MailId { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string MailBody { get; set; }
    }
}
