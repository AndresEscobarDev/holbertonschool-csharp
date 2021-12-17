using NUnit.Framework;

namespace MyMath.Tests
{
  [TestFixture]
  public class Tests
  {
    [Test]
    public void Test1()
    {
      int[,] mtx = new int[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
      int[,] res = new int[,] { { 0, 0, 1, 1 }, { 2, 2, 3, 3 }, { 4, 4, 5, 5 } };
      Assert.AreEqual(res, Matrix.Divide(mtx, 2));
    }
    [Test]
    public void Test2()
    {
      int[,] mtx = new int[,] { { 0 }, { 4 }, { 8 } };
      int[,] res = new int[,] { { 0 }, { 2 }, { 4 } };
      Assert.AreEqual(res, Matrix.Divide(mtx, 2));
    }
    [Test]
    public void Test3()
    {
      int[,] mtx = new int[,] { { 4 }, { 10 }, { 1 } };
      int[,] res = new int[,] { { 1 }, { 3 }, { 0 } };
      Assert.AreEqual(res, Matrix.Divide(mtx, 3));
    }
    [Test]
    public void Test4()
    {
      int[,] mtx = null;
      Assert.AreEqual(null, Matrix.Divide(mtx, 3));
    }
    [Test]
    public void Test5()
    {
      int[,] mtx = new int[,] { { 4 }, { 10 }, { 1 } };
      Assert.AreEqual(null, Matrix.Divide(mtx, 0));
    }
  }
}
