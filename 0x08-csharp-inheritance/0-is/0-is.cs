using System;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
  /// <summary>
  /// Determinate if the object is an int.
  /// </summary>
  /// <param name="obj">Object</param>
  /// <returns>True if the object is an int, otherwise return False.</returns>
  public static bool IsOfTypeInt(object obj) => obj is int;
}
