using System;

/// <summary>
/// Shape class
/// </summary>
public class Shape
{
  /// <summary>
  /// Throws an NotImplementedException with the message Area() is not implemented.
  /// </summary>
  /// <returns>New Exception</returns>

  public virtual int Area()
  {
    throw new NotImplementedException("Area() is not implemented");
  }
}
