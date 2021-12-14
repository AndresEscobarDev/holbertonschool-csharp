using System;

namespace Enemies
{
  /// <summary>
  /// Zombie class
  /// </summary>
  public class Zombie
  {
    /// <summary>
    /// Zombie's health
    /// </summary>
    public int health;
    /// <summary>
    /// Constructor that sets the value of health to 0
    /// </summary>
    public Zombie()
    {
      this.health = 0;
    }
    /// <summary>
    /// Constructor that sets the health to value
    /// </summary>
    /// <param name="value">Value must be greater than or equal to 0</param>
    public Zombie(int value)
    {
      if (value < 0)
      {
        throw new ArgumentException("Health must be greater than or equal to 0");
      }
      else
      {
        this.health = value;
      }
    }
  }
}
