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
    /// Zombie's name
    /// </summary>
    private string name = "(No name)";
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
    /// <summary>
    /// Method that returns the zombie's health
    /// </summary>
    /// <returns>zombie's health</returns>
    public int GetHealth()
    {
      return this.health;
    }
    /// <summary>
    /// Property Name
    /// </summary>
    /// <value>sets and return zombie's name</value>
    public string Name
    {
      get
      {
        return this.name;
      }
      set
      {
        this.name = value;
      }
    }
    /// <summary>
    /// String representation of zombie object
    /// </summary>
    /// <returns>Zombie Name: "name" / Total Health: "health"</returns>
    public override string ToString()
    {
      return $"Zombie Name: {this.name} / Total Health: {this.health}";
    }
  }
}
