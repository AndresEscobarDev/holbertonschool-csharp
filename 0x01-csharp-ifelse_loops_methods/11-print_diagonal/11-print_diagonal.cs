using System;

class Line
{
  public static void PrintDiagonal(int length)
  {
    if (length > 0)
    {
      for (int i1 = 0; i1 < length; i1++)
      {
        for (int i2 = 0; i2 < i1; i2++)
        {
          Console.Write(' ');
        }
        Console.WriteLine("\\");
      }
    }
    else
    {
      Console.WriteLine("");
    }
  }
}
