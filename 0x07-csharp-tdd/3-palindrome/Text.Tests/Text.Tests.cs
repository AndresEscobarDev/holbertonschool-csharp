using NUnit.Framework;

namespace Text.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      Assert.IsTrue(Str.IsPalindrome("Racecar"));
    }
    [Test]
    public void Test2()
    {
      Assert.IsTrue(Str.IsPalindrome("level"));
    }
    [Test]
    public void Test3()
    {
      Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
    }
    [Test]
    public void Test4()
    {
      Assert.IsTrue(Str.IsPalindrome(""));
    }
    [Test]
    public void Test5()
    {
      Assert.IsFalse(Str.IsPalindrome("alarido"));
    }
    [Test]
    public void Test6()
    {
      Assert.IsFalse(Str.IsPalindrome("Once upon a Time"));
    }
    [Test]
    public void Test7()
    {
      Assert.IsFalse(Str.IsPalindrome("849481"));
    }
    [Test]
    public void Test8()
    {
      Assert.IsTrue(Str.IsPalindrome("84.  94:8"));
    }
  }
}