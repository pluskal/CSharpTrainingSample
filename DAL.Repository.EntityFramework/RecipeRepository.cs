using DAL.Entities;
using DAL.Repository.EntityFramework.Bases;

namespace DAL.Repository.EntityFramework
{
  public class RecipeRepository : CRUDRepositoryBase<RecipeEntity>
  {
    public RecipeRepository(UnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
  }
}