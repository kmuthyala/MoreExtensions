using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreExtensions.StringExtensions;

namespace MoreExtensions.UnitTests.StringExtensionTests
{
  [TestClass]
  public class MultipleSpacesToOne
  {
    [TestMethod]
    public void RemoveMultipleSpaces()
    {
      var testStr = "This     is a    test    string.";
      Assert.AreEqual("This is a test string.", testStr.MultipleSpacesToOne());
    }
    
  }
}
