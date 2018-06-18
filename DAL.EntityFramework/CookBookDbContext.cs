using System.Data.Entity;
using DAL.Entities;

namespace DAL.EntityFramework
{
  public class CookBookDbContext : DbContext
  {
    public virtual IDbSet<RecipeEntity> Recipes { get; set; }
    public virtual IDbSet<IngredientEntity> Ingredients { get; set; }

    public CookBookDbContext()
    {
      Database.SetInitializer<CookBookDbContext>(new CookBookDbInitializer());
    }
  }
}