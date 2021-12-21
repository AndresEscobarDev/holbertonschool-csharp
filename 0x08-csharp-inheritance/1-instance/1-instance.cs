using System;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
  /// <summary>
  /// Determinate if the object is an instance of Array.
  /// </summary>
  /// <param name="obj">Object</param>
  /// <returns>True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.</returns>
  public static bool IsInstanceOfArray(object obj)=> obj is Array;
}
