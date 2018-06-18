using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Dapper;
using DAL.Entities;
using DAL.Entities.Bases;

namespace DAL.Repository.Dapper
{
  public class IngredientRepository : CRUDRepositoryBase<IngredientEntity>
  {
    public IngredientRepository(UnitOfWork unitOfWork) : base(unitOfWork)
    {
    }

    public override IEnumerable<IngredientEntity> GetAll()
    {
      return Connection.Query<IngredientEntity>("SELECT * FROM IngredientEntities", null, UnitOfWork.Transaction);
    }

    public override IngredientEntity GetById(Guid id, Expression<Func<IngredientEntity, object>>[] entityIncludes)
    {
      throw new NotImplementedException();
    }

    public override IngredientEntity Insert(IngredientEntity entity)
    {
      //In case that we use Database Generated Identity
      //entity.Id = Connection.ExecuteScalar<Guid>(
      //  "INSERT INTO IngredientEntities(Id, Name, Description) VALUES(@Id, @Name, @Description); SELECT SCOPE_IDENTITY()",
      //  param: new { Id = entity.Id, Name = entity.Name, Description = entity.Description },
      //  transaction: this.UnitOfWork.Transaction
      //);
      entity.Id = Guid.NewGuid();
      Connection.Execute(
        "INSERT INTO IngredientEntities(Id, Name, Description) VALUES(@Id, @Name, @Description); SELECT SCOPE_IDENTITY()",
        new {entity.Id, entity.Name, entity.Description},
        UnitOfWork.Transaction
      );
      return entity;
    }

    public override void Delete(IngredientEntity entity)
    {
      throw new NotImplementedException();
    }

    public override void Delete(Guid id)
    {
      throw new NotImplementedException();
    }

    public override void Update(IngredientEntity entity)
    {
      throw new NotImplementedException();
    }

    public override IngredientEntity InitializeNew()
    {
      throw new NotImplementedException();
    }
  }

  public abstract class CRUDRepositoryBase<TEntity> : ICRUDRepository<TEntity> where TEntity : EntityBase, new()
  {
    protected CRUDRepositoryBase(UnitOfWork unitOfWork)
    {
      UnitOfWork = unitOfWork;
    }

    protected IDbConnection Connection => UnitOfWork.Transaction.Connection;

    public UnitOfWork UnitOfWork { get; }
    public abstract IEnumerable<TEntity> GetAll();
    public abstract TEntity GetById(Guid id, Expression<Func<TEntity, object>>[] entityIncludes);
    public abstract TEntity Insert(TEntity entity);
    public abstract void Delete(TEntity entity);
    public abstract void Delete(Guid id);
    public abstract void Update(TEntity entity);
    public abstract TEntity InitializeNew();

    IUnitOfWork ICRUDRepository<TEntity>.UnitOfWork => UnitOfWork;

    public void Dispose()
    {
    }
  }
}