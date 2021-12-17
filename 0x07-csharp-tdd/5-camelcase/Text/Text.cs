using System;

namespace Text
{
  /// <summary>
  /// Str
  /// </summary>
  public class Str
  {
    /// <summary>
    /// Determines how many words are in a string.
    /// </summary>
    /// <params name="s">String</params>
    /// <returns>Number of words that are in a string</returns>
    public static int CamelCase(string s)
    {
      if (s.Length == 0) return 0;
      int n = 1;
      for (int i = 1; i < s.Length; i++) if (s[i] >= 'A' && s[i] <= 'Z') n++;
      return n;
    }
  }
}
