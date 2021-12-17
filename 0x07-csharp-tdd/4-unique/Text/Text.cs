using System;

namespace Text
{
  /// <summary>
  /// Str
  /// </summary>
  public class Str
  {
    /// <summary>
    /// Returns the index of the first non-repeating character of a string.
    /// </summary>
    /// <params name="s">String</params>
    /// <returns>Index of the first non-repeating character of a string</returns>
    public static int UniqueChar(string s)
    {
      bool repeat = true;
      for (int i = 0; i < s.Length; i++)
      {
        for (int j = 0; j < s.Length; j++)
        {
          if (i != j && s[i] == s[j])
          {
            repeat = true;
            break;
          }
          repeat = false;
        }
        if (!repeat) return i;
      }
      return -1;
    }
  }
}
