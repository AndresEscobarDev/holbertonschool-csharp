using System;

class Array
{
  public static int[] CreatePrint(int size)
  {
    if (size < 0)
    {
      Console.WriteLine("Size cannot be negative");
      return null;
    }
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
      newArray[i] = i;
      Console.Write("{0}{1}", i, i + 1 < size ? " " : "");
    }
    Console.WriteLine("");
    return newArray;
  }
}
