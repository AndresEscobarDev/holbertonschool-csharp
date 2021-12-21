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

/// <summary>
/// Rectangle class
/// </summary>
public class Rectangle : Shape
{
  private int width;
  private int height;

  /// <summary>
  /// Get and set width value.
  /// </summary>
  /// <value>Width</value>
  public int Width
  {
    get => width;
    set
    {
      if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
      width = value;
    }
  }

  /// <summary>
  /// Get and set height value.
  /// </summary>
  /// <value>Height</value>
  public int Height
  {
    get => height;
    set
    {
      if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
      height = value;
    }
  }

  /// <summary>
  /// Determinate the rectangle area.
  /// </summary>
  /// <returns>Rectangle area</returns>
  public override int Area() => height * width;

  /// <summary>
  /// String representation of rectangle.
  /// </summary>
  public override string ToString()
  {
    return $"[Rectangle] {width} / {height}";
  }
}
