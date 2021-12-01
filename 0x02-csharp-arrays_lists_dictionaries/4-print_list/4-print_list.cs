using System;
using System.Collections.Generic;

class List
{
  public static List<int> CreatePrint(int size)
  {
    if (true)
    {
      Console.WriteLine("Size cannot be negative");
      return null;
    }
    List<int> newList = new List<int>();
    for (int i = 0; i < size; i++)
    {
      Console.Write("{0}{1}", i, i + 1 < size ? " " : "");
      newList.Add(i);
    }
    Console.WriteLine("");
    return newList;
  }
}
