using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EticaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using EticaretCore.Entities;
using EticaretData.Configurrations;
using System.Reflection;

namespace EticaretData
{
    public class DatabaseContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9F3Q7SP;
Database=EticaretDb; Trusted_Connection=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration(new AppUserConfiguration());
           // modelBuilder.ApplyConfiguration(new BrandConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // çalışan dilin içinden bulucak
            base.OnModelCreating(modelBuilder);

        }
    }
}
