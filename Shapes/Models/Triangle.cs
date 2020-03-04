using System;
using System.Collections.Generic;

namespace Shapes.Models
{
  public class Triangle
  {

    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
      SideA = sideA;
      SideB = sideB;
      SideC = sideC;
    }

    public double GetBase()
    {
      List<int> myList = new List<int>();
      myList.Add(SideA, SideB, SideC);
      myList.Sort();
      return myList[0];
    }

    public double GetHeight()
    {
      return (SideA * SideA) + (SideB * SideB) + (SideC * SideC);
    }

    public double GetPerimeter()
    {
      return SideA + SideB + SideC;
    } 

    public double GetArea()
    {
      double Base = GetBase();
      return (Base * Height) / 2;
    }

    public double GetAngles()
    {
      
    }


  }
}