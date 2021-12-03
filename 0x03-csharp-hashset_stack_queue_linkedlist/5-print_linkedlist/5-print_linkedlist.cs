using System;
using System.Collections.Generic;

class LList
{
  public static LinkedList<int> CreatePrint(int size)
  {
    LinkedList<int> newLList = new LinkedList<int>();
    if (size < 0) return newLList;
    for (int i = 0; i < size; i++)
    {
      Console.WriteLine(i);
      newLList.AddLast(i);
    }
    return newLList;
  }
}
