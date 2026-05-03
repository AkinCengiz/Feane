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
public class EfDiscountDal : EfGenericRepository<Discount, FeaneDbContext>, IDiscountDal
{
    public EfDiscountDal(FeaneDbContext context) : base(context)
    {
    }
}
