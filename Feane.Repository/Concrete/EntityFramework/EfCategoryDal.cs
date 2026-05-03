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
public class EfCategoryDal : EfGenericRepository<Category, FeaneDbContext>, ICategoryDal
{
    public EfCategoryDal(FeaneDbContext context) : base(context)
    {
    }
}
