using System;
using System.Collections.Generic;
using System.Linq;

class List
{
  public static int Sum(List<int> myList)
  {
    HashSet<int> numbersToSum = new HashSet<int>(myList);
    return numbersToSum.Sum(item => item);
  }
}
