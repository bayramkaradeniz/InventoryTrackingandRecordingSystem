using Itrs.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Entites.Concrete
{
    public class Company : IEntity
    {
        [Key]
        public int AdminId { get; set; }
        public String CompanyAdminUsername { get; set; }
        public string CompanyAdminPassword { get; set; }
        public String CompanyAdminPhone { get; set; }
        public string AdminFullName { get; set; }
        public string AdminMail { get; set; }
    }
}
