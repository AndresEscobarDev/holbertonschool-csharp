using System;

namespace _14_rectangular_array
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] twoDimensionalArray = new int[5, 5];
      twoDimensionalArray[2, 2] = 1;
      for (int i = 0; i < 5; i++)
      {
        for (int i2 = 0; i2 < 5; i2++)
        {
          Console.Write("{0}{1}", twoDimensionalArray[i, i2], i2 < 4 ? " " : "");
        }
        Console.WriteLine("");
      }
    }
  }
}
