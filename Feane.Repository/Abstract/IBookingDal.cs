using Core.Repository;
using Feane.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Repository.Abstract;
public interface IBookingDal : IGenericRepository<Booking>
{
    List<Booking> GetReserved(DateTime date);
}
