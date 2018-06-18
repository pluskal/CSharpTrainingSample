using System;

namespace DAL.Entities.Bases
{
  public abstract class EntityBase
  {
    public Guid Id { get; set; } = Guid.NewGuid();
  }
}