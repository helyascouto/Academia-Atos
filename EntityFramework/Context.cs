using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Context : DbContext
    {      
        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Email> emails { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost; initial Catalog=CodeFirstEntity; User ID=usuario;password=senha;language=Portuguese;Trusted_Connection=True");
            //optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)// relação 1 para 1
                .WithMany(p => p.Emails) //relação 1 para muitos
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
