using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DAL.Entities.Bases;

namespace DAL.Repository.EntityFramework.Bases
{
  public class CRUDRepositoryBase<TEntity> : ICRUDRepository<TEntity> where TEntity : EntityBase, new()
  {
    public CRUDRepositoryBase(UnitOfWork unitOfWork)
    {
      UnitOfWork = unitOfWork;
    }

    public UnitOfWork UnitOfWork { get; }

    IUnitOfWork ICRUDRepository<TEntity>.UnitOfWork => this.UnitOfWork;

    public void Dispose()
    {
      UnitOfWork.Context?.Dispose();
    }

    public IEnumerable<TEntity> GetAll()
    {
      return UnitOfWork.Context.Set<TEntity>().ToArray();
    }

    public TEntity GetById(Guid id, Expression<Func<TEntity, Object>>[] entityIncludes)
    {
      IQueryable<TEntity> query = UnitOfWork.Context.Set<TEntity>();

      foreach (var include in entityIncludes)
      {
        query = query.Include(include);
      }

      return query.FirstOrDefault(i => i.Id == id);
    }

    public void Insert(TEntity entity)
    {
      entity.Id = Guid.NewGuid();
      UnitOfWork.Context.Set<TEntity>().Add(entity);
    }

    public void Delete(TEntity entity)
    {
      UnitOfWork.Context.Set<TEntity>().Remove(entity);
    }

    public void Delete(Guid id)
    {
      var entity = UnitOfWork.Context.Set<TEntity>().Local.SingleOrDefault(e => e.Id.Equals(id));

      if (entity == null)
      {
        entity = new TEntity { Id = id };
        UnitOfWork.Context.Set<TEntity>().Attach(entity);
      }

      Delete(entity);
    }

    public void Update(TEntity entity)
    {
      UnitOfWork.Context.Entry(entity).State = EntityState.Modified;
    }

    public TEntity InitializeNew()
    {
      return new TEntity { Id = Guid.Empty };
    }
  }
}