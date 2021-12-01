using System;

namespace _100_jagged_array
{
  class Program
  {
    static void Main(string[] args)
    {
      int[][] jaggedArray = new int[3][];
      jaggedArray[0] = new int[] { 0, 1, 2, 3 };
      jaggedArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
      jaggedArray[2] = new int[] { 0, 1 };
      for (int i1 = 0; i1 < jaggedArray.Length; i1++)
      {
        for (int i2 = 0; i2 < jaggedArray[i1].Length; i2++)
        {
          Console.Write("{0}{1}", jaggedArray[i1][i2], i2 < jaggedArray[i1].Length - 1 ? " " : "");
        }
        Console.WriteLine("");
      }
    }
  }
}
