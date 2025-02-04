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
    internal class NewsConfigurration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(750);
            builder.Property(x => x.Image).HasMaxLength(100);
        }
    }
}
