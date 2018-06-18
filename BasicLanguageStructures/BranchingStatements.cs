using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLanguageStructures
{
  [TestClass]
  public class BranchingStatements
  {
    [TestMethod]
    public void DoIf()
    {
      if (true)
      {
        Assert.IsTrue(true);
      }
      else if(false)
      {
        Assert.IsTrue(false);
      }
      else
      {
        Assert.IsTrue(false);
      }
    }

    [TestMethod]
    public void DoTernary()
    {
      Assert.IsTrue(1==1 ? true : false);

      //if (1 == 1)
      //{
      //  Assert.IsTrue(true);
      //}
      //else
      //{
      //  Assert.IsTrue(false);
      //}
    }

    [TestMethod]
    public void DoSwitch()
    {
      Operation operation = Operation.Add;
      switch (operation)
      {
        case Operation.Add:
          Assert.AreEqual(Operation.Add, operation);
          break;
        case Operation.Sub:
          Assert.AreEqual(Operation.Sub, operation);
          break;
        case Operation.Mult:
          Assert.AreEqual(Operation.Mult, operation);
          break;
        case Operation.Div:
          Assert.AreEqual(Operation.Div, operation);
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }
  }

  public enum Operation
  {
    Add,
    Sub,
    Mult,
    Div
  }
}
