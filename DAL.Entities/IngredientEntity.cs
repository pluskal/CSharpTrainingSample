using DAL.Entities.Bases;

namespace DAL.Entities
{
  public class IngredientEntity : EntityBase
  {
    public string Name { get; set; }
    public string Description { get; set; }
  }
}