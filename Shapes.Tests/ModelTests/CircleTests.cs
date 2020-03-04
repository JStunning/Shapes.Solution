using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

    [TestMethod]
    public void Circle_CircleConstructor_NewCircle()
    {
      // Arrange
      Circle newCircle = new Circle(5);
      // Act
      double result = newCircle.Radius;
      // Assert
      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void Circle_GetCircumference_12point56()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      // Act
      double result = newCircle.GetCircumference();
      // Assert
      Assert.AreEqual(result, 12.56);
    }
    
    [TestMethod]
    public void Circle_GetDiameter_4()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      // Act
      double result = newCircle.GetDiameter();
      // Assert
      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void Circle_GetArea_6point28()
    {
      // Arrange
      Circle newCircle = new Circle(2);
      // Act
      double result = newCircle.GetArea();
      // Assert
      Assert.AreEqual(result, 6.28);
    }
  }
}