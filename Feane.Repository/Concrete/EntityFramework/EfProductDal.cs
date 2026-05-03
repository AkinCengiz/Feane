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
public class EfProductDal : EfGenericRepository<Product, FeaneDbContext>, IProductDal
{
    public EfProductDal(FeaneDbContext context) : base(context)
    {
    }

    public List<Product> GetByCategory(int categoryId)
    {
        return _dbSet.Where(p => p.CategoryId == categoryId).ToList();
    }
}
