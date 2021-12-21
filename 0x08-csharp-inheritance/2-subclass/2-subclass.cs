using System;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
  /// <summary>
  /// Determinate if the object is an instance of a class that inherits from the specified class
  /// </summary>
  /// <param name="derivedType">Class</param>
  /// <param name="baseType">Base class</param>
  /// <returns>True if the object is an instance of a class that inherits from the specified class, otherwise return False.</returns>
  public static bool IsOnlyASubclass(Type derivedType, Type baseType) => derivedType.IsSubclassOf(baseType);
}
