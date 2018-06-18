using System;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicLanguageStructures
{
  [TestClass]
  public class Strings
  {
    [TestMethod]
    public void WriteHelloWorld()
    {
      Console.WriteLine("Hello World!");
    }

    [TestMethod]
    public void WriteFormatString1()
    {
      Console.WriteLine(String.Format("{0} + {1} = {2}", 1, 2 ,3));
    }

    [TestMethod]
    public void WriteFormatString2()
    {
      Console.WriteLine("{0} + {1} = {2}", 1, 2, 3);
    }

    [TestMethod]
    public void WriteFormatString3()
    {
      Console.WriteLine($"{1} + {2} = {1+2}");
    }

    [TestMethod]
    public void FormatWithStringBuilder()
    {
      var sb = new StringBuilder();
      sb.Append("Hello").Append(" ").Append("World!");
      Console.WriteLine(sb.ToString());
    }

    [TestMethod]
    public void SplitString()
    {
      var str = "Hello World! Good Morning!";
      var subString = str.Split(' ');
      Console.WriteLine(subString[1]);

      Assert.AreEqual("World!", subString[1]);
    }

    [TestMethod]
    public void SubstringString()
    {
      var str = "Hello World! Good Morning!";
      var subString = str.Substring(6,6);
      Console.WriteLine(subString);

      Assert.AreEqual("World!", subString);
    }

    [TestMethod]
    public void WriteStringLength()
    {
      var str = "Hello World! Good Morning!";
      var length = str.Length;
      Console.WriteLine(length);

      Assert.AreEqual(26, length);
    }

    [TestMethod]
    public void ReplaceSubString()
    {
      var str = "Hello World! Good Morning!";
      var replaced = str.Replace("ll","OO");
      Console.WriteLine(replaced);

      Assert.AreEqual("HeOOo World! Good Morning!", replaced);
    }

    [TestMethod]
    public void ReplaceOnIndexString()
    {
      var str = "Hello World! Good Morning!";
      var replaced = str.ToCharArray();
      replaced[2] = 'O';
      replaced[3] = 'O';

      Console.WriteLine(replaced);
    }

    [TestMethod]
    public void ConvertStringToInt()
    {
      Assert.AreEqual(5, int.Parse("5"));

      int.TryParse("5", out var number);
      Assert.AreEqual(5, number);
    }

    [TestMethod]
    public void ConvertStringToIntSafe()
    {
      //int number
      //if (int.TryParse("5", out number))

      if (int.TryParse("5", out var number))
      {
        Assert.AreEqual(5, number);
      }
      else
      {
        Assert.AreNotEqual(5, number);
      }

      Console.WriteLine(number);
    }

    [TestMethod]
    public void GetIndexOf()
    {
      var str = "Hello World! Good Morning!";
      var index = str.IndexOf("W");

      Assert.AreEqual(6,index);
    }

    [TestMethod]
    public void DoMyReplace()
    {
      Assert.Inconclusive("TODO: Implement!");

      var str = "Hello World! Good Morning!";

      //var replacedString = StringExtensions.MyReplace(str,"!",0,1,"Good afternoon");
      var replacedString = str.MyReplace("!",0,1,"Good afternoon");

      Assert.AreEqual("Hello World! Good Morning!", replacedString);
    }
  }

  public static class StringExtensions
  {
    public static string MyReplace(this string baseString, string delimiter, int firstIndex, int lastIndex, string replaceWith)
    {
      throw new NotImplementedException();
    }
  }
}
