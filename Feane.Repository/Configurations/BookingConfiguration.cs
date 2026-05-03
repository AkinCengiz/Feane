using Feane.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Repository.Configurations;
internal class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.Property(b => b.FullName).HasMaxLength(100).IsRequired();
        builder.Property(b=> b.Phone).HasMaxLength(20).IsRequired();
        builder.Property(b => b.Email).HasMaxLength(50);
        builder.Property(b => b.GuestCount).IsRequired();
        builder.Property(b => b.BookingDate).IsRequired();
    }
}
