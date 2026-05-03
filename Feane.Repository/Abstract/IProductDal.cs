using Core.Repository;
using Feane.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Repository.Abstract;
public interface IProductDal : IGenericRepository<Product>
{
    List<Product> GetByCategory(int categoryId);
}
