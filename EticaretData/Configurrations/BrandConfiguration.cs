using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EticaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EticaretData.Configurrations
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brands>
    {
        public void Configure(EntityTypeBuilder<Brands> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Logo).HasMaxLength(50);
        }
    }
}
