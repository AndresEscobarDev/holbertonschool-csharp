using System;
using System.Collections.Generic;

namespace MyMath
{
  /// <summary>
  /// Operations
  /// </summary>
  public class Operations
  {
    /// <summary>
    /// Find the max integer in a list of integers
    /// </summary>
    /// <params name="nums">List of integers</params>
    /// <returns>returns the max integer in a list of integers.</returns>
    public static int Max(List<int> nums)
    {
      if (nums.Count == 0) return 0;
      int max = nums[0];
      foreach (int n in nums)
      {
        if (n > max) max = n;
      }
      return max;
    }
  }
}
