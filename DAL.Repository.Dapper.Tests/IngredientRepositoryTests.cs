using System;
using DAL.Entities;
using Xunit;

namespace DAL.Repository.Dapper.Tests
{
  public class IngredientRepositoryTests
  {
    private readonly IngredientRepository _repositorySUT;

    public IngredientRepositoryTests()
    {
      _repositorySUT = new IngredientRepository(new UnitOfWork(
        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook.DAL.CookBookDbContext;Integrated Security=True;"));
    }

    [Fact]
    public void DbSeeded_GetAll_SeedExists()
    {
      //Arrange

      //Act
      var allIngredients = _repositorySUT.GetAll();

      //Assert
      Assert.NotEmpty(allIngredients);
    }

    [Fact]
    public void NewEntity_Insert_EntityInserted()
    {
      //Arrange
      var ingredientEntity = new IngredientEntity();

      //Act
      var insertedIngredient = _repositorySUT.Insert(ingredientEntity);

      //Assert
      Assert.NotNull(insertedIngredient);
      Assert.NotEqual(Guid.Empty, insertedIngredient.Id);
    }
  }
}