using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLanguageStructures
{
  [TestClass]
  public class Iterations
  {
    [TestMethod]
    public void DoFor()
    {
      int sum = 0;
      for (int i = 0; i < 10; i++)
      {
        //sum = sum + i;
        sum += i;
      }
      Assert.AreEqual(45,sum);
    }

    [TestMethod]
    public void DoWhile()
    {
      int i = 0;
      int sum = 0;

      while (i < 10)
      {
        sum += i;
        i++;
      }

      Assert.AreEqual(45, sum);
    }

    [TestMethod]
    public void DoDoWhile()
    {
      int i = 0;
      int sum = 0;

      do
      {
        sum += i;
        i++;
      } while (i < 10);

      Assert.AreEqual(45, sum);
    }
  }
}
