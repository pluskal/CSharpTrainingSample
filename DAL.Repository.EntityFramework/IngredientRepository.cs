using DAL.Entities;
using DAL.Repository.EntityFramework.Bases;

namespace DAL.Repository.EntityFramework
{
  public class IngredientRepository : CRUDRepositoryBase<IngredientEntity>
  {
    public IngredientRepository(UnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
  }
}