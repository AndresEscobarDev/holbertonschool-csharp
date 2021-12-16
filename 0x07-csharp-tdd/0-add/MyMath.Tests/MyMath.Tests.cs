using NUnit.Framework;

namespace MyMath.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      Assert.AreEqual(100, Operations.Add(35, 65));
    }
    [TestCase(33, 27, 60)]
    [TestCase(-33, 27, -6)]
    [TestCase(99999, 100001, 200000)]
    [TestCase(0, 0, 0)]
    [TestCase(0, 5, 5)]
    public void TestAdd(int a, int b, int res)
    {
      Assert.AreEqual(res, Operations.Add(a, b));
    }
  }
}