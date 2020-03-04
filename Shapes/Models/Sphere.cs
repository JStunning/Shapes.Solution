using System;
using System.Collections.Generic;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Radius { get; set; }

    public Sphere (Circle radius)
    {
      Radius = radius;
    }

    public double GetDiameter()
    {
      return 2 * Radius.Radius;
    }

    public double GetVolume()
    {
      return 1.33 * 3.14 * (Radius.Radius * Radius.Radius * Radius.Radius);
    }

    public double GetSurfaceArea()
    {
      return 4 * 3.14 * (Radius.Radius * Radius.Radius);
    }
  }
}