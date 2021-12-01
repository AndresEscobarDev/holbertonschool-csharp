using System;

class Matrix
{
  public static int[,] Square(int[,] myMatrix)
  {
    int[,] newMatrix = myMatrix;
    for (int i1 = 0; i1 < myMatrix.GetLength(0); i1++)
    {
      for (int i2 = 0; i2 < myMatrix.GetLength(1); i2++)
      {
        newMatrix[i1, i2] = myMatrix[i1, i2] * myMatrix[i1, i2];
      }
    }
    return newMatrix;
  }
}
