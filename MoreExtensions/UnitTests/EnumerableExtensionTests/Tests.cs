using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreExtensions.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreExtensions.UnitTests.EnumerableExtensionTests
{
  [TestClass]
  public class Tests
  {
  
    [TestMethod]
    public void DelimitedStringTest()
    {
      var list = new List<string>() { "ab","bc","de" };
      Assert.AreEqual("ab,bc,de", list.ToDelimitedString(","));
    }
    [TestMethod]
    public void DelimitedStringTestArray()
    {
      var arr = new string[] { "12", "13" };
      Assert.AreEqual("12-13", arr.ToDelimitedString("-"));
    }
    [TestMethod]
    public void ApplyTest()
    {
      var list = new List<int> { 2, 4, 6 };
      CollectionAssert.AreEqual(new List<int> { 4, 8, 12 }, list.Apply(f => f * 2).ToList());
      var g = list.Apply(f => f * 2);
    }
    [TestMethod]
    public void ReverseApplyTest()
    {
      var list = new List<int> { 2, 4, 6 };
      CollectionAssert.AreEqual(new List<int> { 12, 8, 4 }, list.ReverseApply(f => f * 2).ToList());
      var g = list.Apply(f => f * 2);
    }
    [TestMethod]
    public void SliceTest()
    {
      var list = new List<int> { 2, 4, 6, 8, 10 };
      var g = list.Slice(1,3);
      CollectionAssert.AreEqual(new List<int> { 4, 6, 8 }, list.Slice(1, 3).ToList());
    }
  }
}
