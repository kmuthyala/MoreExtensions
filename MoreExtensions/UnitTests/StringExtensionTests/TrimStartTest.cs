using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreExtensions.StringExtensions;

namespace MoreExtensions.UnitTests.StringExtensionTests
{
  [TestClass]
  public class TrimStartTest
  {
    [TestMethod]
    public void TestProperString()
    {
      var testStr = "This is a test string.";
      Assert.AreEqual(" a test string.", testStr.TrimStart("This is"));
    }
    [TestMethod]
    public void TestParamLengthGreaterThanInput()
    {
      string testStr = "This is a string.";
      Assert.AreEqual(testStr, testStr.TrimStart("This is a string input."));
    }
    [TestMethod]
    public void TestNullInput()
    {
      string testStr = null;
      Assert.AreEqual(null, testStr.TrimStart("This"));
    }
    [TestMethod]
    public void TestNullParam()
    {
      string testStr = "This is a string.";
      Assert.AreEqual(testStr, testStr.TrimStart(null));
    }
  }
}
