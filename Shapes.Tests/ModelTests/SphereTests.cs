using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_SphereConstructor_Radius()
    {
      // Arrange
      Circle newCircle = new Circle(1);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.Radius.Radius;
      // Assert
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void Sphere_GetDiameter_2()
    {
      // Arrange
      Circle newCircle = new Circle(1);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetDiameter();
      // Assert
      Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void Sphere_GetVolume_33point4096()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      double test = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, test);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_50point24()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetSurfaceArea();
      double test = 50.24;
      // Assert
      Assert.AreEqual(result, test);
    }
  }
}