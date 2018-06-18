using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DAL.Entities;
using DAL.Entities.Bases;

namespace DAL.Repository
{
  public interface ICRUDRepository<TEntity> : IDisposable where TEntity : EntityBase, new()
  {
    IUnitOfWork UnitOfWork { get; }
    IEnumerable<TEntity> GetAll();
    TEntity GetById(Guid id, Expression<Func<TEntity, Object>>[] entityIncludes);
    TEntity Insert(TEntity entity);
    void Delete(TEntity entity);
    void Delete(Guid id);
    void Update(TEntity entity);
    TEntity InitializeNew();
  }
}