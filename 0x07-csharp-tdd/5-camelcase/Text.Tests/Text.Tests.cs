using NUnit.Framework;

namespace Text.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(4, Str.CamelCase("HelloHowAreYou"));
    }
    [Test]
    public void Test2()
    {
      Assert.AreEqual(4, Str.CamelCase("helloHowAreYou"));
    }
    [Test]
    public void Test3()
    {
      Assert.AreEqual(0, Str.CamelCase(""));
    }
    [Test]
    public void Test4()
    {
      Assert.AreEqual(1, Str.CamelCase("hello men"));
    }
    [Test]
    public void Test5()
    {
      Assert.AreEqual(2, Str.CamelCase("hello Men"));
    }
    [Test]
    public void Test6()
    {
      Assert.AreEqual(1, Str.CamelCase("h"));
    }
  }
}