using System;

namespace MyMath
{
  /// <summary>
  /// Matrix
  /// </summary>
  public class Matrix
  {
    /// <summary>
    /// Divides all elements of a matrix.
    /// </summary>
    /// <params name="matrix">Integer matrix</params>
    /// <params name="num">Divider</params>
    /// <returns>New matrix with each element divided</returns>
    public static int[,] Divide(int[,] matrix, int num)
    {
      if (matrix == null) return null;
      int width = matrix.GetLength(0);
      int height = matrix.GetLength(1);
      int[,] newMatrix = new int[width, height];
      for (int i1 = 0; i1 < width; i1++)
      {
        for (int i2 = 0; i2 < height; i2++)
        {
          try
          {
            newMatrix[i1, i2] = matrix[i1, i2] / num;
          }
          catch (DivideByZeroException)
          {
            Console.WriteLine("Num cannot be 0");
            return null;
          }
        }
      }
      return newMatrix;
    }
  }
}
