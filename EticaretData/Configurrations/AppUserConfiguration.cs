using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EticaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EticaretData.Configurrations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("nvarchar(50)").HasMaxLength(50);
            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    UserName = "admin",
                    Email = "admin@eticaret.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Test",
                    Surname = "User",
                    Password = "123456"
                });
        }
    }
}
