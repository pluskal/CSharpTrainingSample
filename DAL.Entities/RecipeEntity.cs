using System;
using System.Collections.Generic;
using DAL.Entities.Bases;

namespace DAL.Entities
{
  public class RecipeEntity : EntityBase
  {
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }
    public FoodType FoodType { get; set; }
    public string Description { get; set; }

    public ICollection<IngredientAmountEntity> Ingredients { get; set; } =
      new List<IngredientAmountEntity>();
  }
}
