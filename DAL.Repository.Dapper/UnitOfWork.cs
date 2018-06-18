using System.Data;
using System.Data.SqlClient;

namespace DAL.Repository.Dapper
{
  public class UnitOfWork : IUnitOfWork
  {
    public UnitOfWork(string connectionString)
    {
      var connection = new SqlConnection(connectionString);
      connection.Open();
      Transaction = connection.BeginTransaction();
    }

    public UnitOfWork(IDbTransaction transaction)
    {
      Transaction = transaction;
    }

    public IDbTransaction Transaction { get; }

    public void Dispose()
    {
      Transaction?.Commit();
    }

    public void Commit()
    {
      try
      {
        Transaction.Commit();
      }
      catch
      {
        Transaction.Rollback();
        throw;
      }
    }
  }
}