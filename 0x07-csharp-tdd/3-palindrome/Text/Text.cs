using System;

namespace Text
{
  /// <summary>
  /// Str
  /// </summary>
  public class Str
  {
    /// <summary>
    /// Returns True if a string is a palindrome or False if it’s not.
    /// </summary>
    /// <params name="s">String</params>
    /// <returns>True if a string is a palindrome or False if it’s not</returns>
    public static bool IsPalindrome(string s)
    {
      if (s.Length == 0) return true;
      for (int i = 0, j = s.Length - 1; i < j; i++, j--)
      {
        while (!(s[i] >= 'A' && s[i] <= 'Z') && !(s[i] >= 'a' && s[i] <= 'z') && !(s[i] >= '0' && s[i] <= '9') && (i < j)) i++;
        while (!(s[j] >= 'A' && s[j] <= 'Z') && !(s[j] >= 'a' && s[j] <= 'z') && !(s[j] >= '0' && s[j] <= '9') && (j > i)) j--;
        if (Char.ToLower(s[i]) != Char.ToLower(s[j])) return false;
      }
      return true;
    }
  }
}
