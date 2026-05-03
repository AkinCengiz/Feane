using Feane.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Repository.Contexts;
public sealed class FeaneDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=AKINCENGIZ;Initial Catalog=FeaneDb;Integrated Security=True;Trust Server Certificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Booking>().Property(b => b.FullName).HasMaxLength(100).IsRequired();
        //modelBuilder.Entity<Booking>().Property(b => b.Phone).HasMaxLength(20).IsRequired();
        //modelBuilder.Entity<Booking>().Property(b => b.Email).HasMaxLength(50);
        //modelBuilder.Entity<Booking>().Property(b => b.GuestCount).IsRequired();
        //modelBuilder.Entity<Booking>().Property(b => b.BookingDate).IsRequired();
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<SocialAccount> SocialAccounts { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}
