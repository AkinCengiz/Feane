using Core.Repository;
using Feane.Entity.Concrete;
using Feane.Repository.Abstract;
using Feane.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Repository.Concrete.EntityFramework;
public class EfBookingDal : EfGenericRepository<Booking, FeaneDbContext>, IBookingDal
{
    public EfBookingDal(FeaneDbContext context) : base(context)
    {
    }

    public List<Booking> GetReserved(DateTime date)
    {
        return _dbSet.Where(b => b.BookingDate == date).ToList();
    }
}
