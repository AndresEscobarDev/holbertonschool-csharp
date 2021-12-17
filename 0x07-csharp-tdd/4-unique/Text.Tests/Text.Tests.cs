using NUnit.Framework;

namespace Text.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(2, Str.UniqueChar("eeioau"));
    }
    [Test]
    public void Test2()
    {
      Assert.AreEqual(0, Str.UniqueChar("caramelo"));
    }
    [Test]
    public void Test3()
    {
      Assert.AreEqual(3, Str.UniqueChar("racecar"));
    }
    [Test]
    public void Test4()
    {
      Assert.AreEqual(0, Str.UniqueChar("a"));
    }
    [Test]
    public void Test5()
    {
      Assert.AreEqual(-1, Str.UniqueChar("asdfghjklññlkjhgfdsa"));
    }
    [Test]
    public void Test6()
    {
      Assert.AreEqual(-1, Str.UniqueChar(""));
    }
  }
}