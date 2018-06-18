using System;
using System.Data.Entity;
using DAL.Entities;

namespace DAL.EntityFramework
{
  public class CookBookDbInitializer : DropCreateDatabaseIfModelChanges<CookBookDbContext>
  {
    protected override void Seed(CookBookDbContext context)
    {
      var ingredient = new IngredientEntity()
      {
        Name = $"{nameof(IngredientEntity.Name)}-Seed",
        Description = nameof(RecipeEntity.Description),
      };

      var recipe = new RecipeEntity
      {
        Name = $"{nameof(RecipeEntity.Name)}-Seed",
        Description = nameof(RecipeEntity.Description),
        Duration = TimeSpan.FromMinutes(323),
        FoodType = FoodType.Other
      };

      context.Ingredients.Add(ingredient);
      context.Recipes.Add(recipe);

      base.Seed(context);
    }
  }
}