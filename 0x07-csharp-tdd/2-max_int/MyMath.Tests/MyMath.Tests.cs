using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      List<int> nums = new List<int> { 0, 1, 2, 3, 4 };
      Assert.AreEqual(4, Operations.Max(nums));
    }
    [Test]
    public void Test2()
    {
      List<int> nums = new List<int> { 0, -1, -2, -3, -4 };
      Assert.AreEqual(0, Operations.Max(nums));
    }
    [Test]
    public void Test3()
    {
      List<int> nums = new List<int> { 50, 100, 999, -10000, 984, -850 };
      Assert.AreEqual(999, Operations.Max(nums));
    }
    [Test]
    public void Test4()
    {
      List<int> nums = new List<int> { };
      Assert.AreEqual(0, Operations.Max(nums));
    }
  }
}