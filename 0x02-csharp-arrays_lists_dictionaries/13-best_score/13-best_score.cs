using System;
using System.Collections.Generic;

class Dictionary
{
  public static string BestScore(Dictionary<string, int> myList)
  {
    if (myList.Count > 0)
    {
      string key = "";
      bool b = false;
      foreach (string k in myList.Keys)
      {
        if (!b)
        {
          key = k;
          b = true;
        }
        if (myList[k] > myList[key])
        {
          key = k;
        }
      }
      return key;
    }
    else
    {
      return "None";
    }
  }
}
