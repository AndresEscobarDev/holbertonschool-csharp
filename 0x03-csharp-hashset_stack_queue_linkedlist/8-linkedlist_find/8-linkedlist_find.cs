using System;
using System.Collections.Generic;

class LList
{
  public static int FindNode(LinkedList<int> myLList, int value)
  {
    int result = -1;
    int index = 0;
    foreach (int num in myLList)
    {
      if (num == value)
      {
        result = index;
        break;
      }
      index ++;
    }
    return result;
  }
}
