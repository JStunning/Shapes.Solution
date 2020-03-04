using System;
using System.Collections.Generic;

namespace Shapes.Models
{
  public class Circle
  {
    public double Radius { get; set; }

    public Circle(int radius)
    {
      Radius = radius;
    }

    public double GetCircumference()
    {
      return Radius * 6.28;
    }

    public double GetDiameter()
    {
      return Radius * 2;
    }

    public double GetArea()
    {
      return Radius * 3.14;
    }
  }
}