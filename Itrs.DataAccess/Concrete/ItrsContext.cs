using Itrs.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itrs.DataAccess.Concrete
{
    public class ItrsContext : DbContext
    {
        public ItrsContext() : base("name=connection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<LogEntry> LogEntries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Mail> Mails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new LogEntryMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new MailMap());
        }
    }
}
