using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLanguageStructures
{
  [TestClass]
  public class Collections
  {
    private List<int> _items;

    public Collections()
    {
      this._items = new List<int>(){0,1,2,3,4,5,6,7,8,9};
    }

    [TestMethod]
    public void DoForEach()
    {
      int sum = 0;
      foreach (var item in _items)
      {
        sum += item;
      }
      Assert.AreEqual(45, sum);
    }

    [TestMethod]
    public void DoFor()
    {
      int sum = 0;
      for (var index = 0; index < _items.Count; index++)
      {
        var item = _items[index];
        sum += item;
      }

      Assert.AreEqual(45, sum);
    }

    [TestMethod]
    public void InsertIntoList()
    {
      _items.Add(10);

      Assert.IsTrue(_items.Any(arg => arg == 10));
    }

    [TestMethod]
    public void Filter()
    {
      var result = _items.Where(item => item % 2 == 0)
                         .Select(item => item * 2)
                         .Sum();
      Assert.AreEqual(40, result);
    }

    [TestMethod]
    public void DoLinqQuery()
    {
      var result =  from item in _items
                    where item % 2 == 0
                    select item * 2;
    }
  }
}