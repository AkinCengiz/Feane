using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository;
public interface IGenericRepository<T> where T: class,IEntity,new()
{
    IQueryable<T> Query(Expression<Func<T, bool>> filter = null);
    List<T> GetAll();
    List<T> GetAllDeleted();
    List<T> GetAllActived();
    //List<T> GetAll(bool? isDeleted = null);
    T? GetById(int id);
    T? Filter(Expression<Func<T, bool>> filter);
    List<T> GetListFiltered(Expression<Func<T,bool>> filter);
    bool Any(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void SoftDelete(T entity);
    void HardDelete(T entity);
    void Update(T entity);
}
