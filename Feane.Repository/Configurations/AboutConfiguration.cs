using Feane.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Repository.Configurations;
internal class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.Property(a => a.Title).HasMaxLength(50).IsRequired();
        builder.Property(a => a.Description).HasMaxLength(1000).IsRequired();
        builder.Property(a => a.ImageUrl).HasMaxLength(150).IsRequired();
    }
}
