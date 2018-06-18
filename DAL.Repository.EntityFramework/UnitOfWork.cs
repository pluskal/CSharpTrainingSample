using System;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.EntityFramework
{
  public class UnitOfWork: IUnitOfWork
  {
        public DbContext Context { get; }

        public UnitOfWork(DbContext dbContext)
        {
            this.Context = dbContext;
        }

        public void Commit()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            this.Context?.Dispose();
        }
    }
}
