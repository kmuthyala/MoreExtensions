using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreExtensions.StringExtensions;

namespace MoreExtensions.UnitTests.StringExtensionTests
{
  [TestClass]
  public class TrimEndTest
  {
    [TestMethod]
    public void TestProperString()
    {
      var testStr = "This is a test string.";
      Assert.AreEqual("This is a test ", testStr.TrimEnd("string."));
    }
    [TestMethod]
    public void TestParamLengthGreaterThanInput()
    {
      string testStr = "This is a string.";
      Assert.AreEqual(testStr, testStr.TrimEnd("This is a string input."));
    }
    [TestMethod]
    public void TestNullInput()
    {
      string testStr = null;
      Assert.AreEqual(null, testStr.TrimEnd("string."));
    }
    [TestMethod]
    public void TestNullParam()
    {
      string testStr = "This is a string.";
      Assert.AreEqual(testStr, testStr.TrimEnd(null));
    }
  }
}
