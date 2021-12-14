﻿using System;

namespace Enemies
{
  public class Zombie
  {
    private int health;
    private string name = "(No name)";
    public Zombie()
    {
      this.health = 0;
    }
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
    public int GetHealth()
    {
      return this.health;
    }

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
    public override string ToString()
    {
      return $"Zombie Name: {this.name} / Total Health: {this.health}";
    }
  }
}
