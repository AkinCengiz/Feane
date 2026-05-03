using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository;
public class EfGenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
    where TEntity : BaseEntity, new()
    where TContext : DbContext
{
    protected readonly TContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public EfGenericRepository(TContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    
    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public bool Any(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.Any(filter);
    }

    public TEntity? Filter(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.FirstOrDefault(filter);
    }

    public List<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public List<TEntity> GetAllActived()
    {
        return _dbSet.Where(x => !x.IsDeleted).ToList();
    }

    public List<TEntity> GetAllDeleted()
    {
        return _dbSet.Where(x => x.IsDeleted).ToList();
    }

    public TEntity? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public List<TEntity> GetListFiltered(Expression<Func<TEntity, bool>> filter)
    {
        return _dbSet.Where(filter).ToList();
    }

    public void HardDelete(TEntity entity)
    {
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null)
    {
        return filter == null ? _dbSet : _dbSet.Where(filter);
    }

    public void SoftDelete(TEntity entity)
    {
        entity.IsDeleted = true;
        entity.IsActive = false;
        entity.UpdateAt = DateTime.Now;
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }
}
