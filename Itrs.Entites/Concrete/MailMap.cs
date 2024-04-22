using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.Entites.Concrete
{
    public class MailMap : EntityTypeConfiguration<Mail>
    {
        public MailMap()
        {
            this.ToTable("Mails");
            this.HasKey(p => p.MailId);
            this.Property(p => p.MailId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.MailBody).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
