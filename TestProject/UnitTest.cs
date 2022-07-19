using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HHTestSkill.UnitTest
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void isStraightTriangle_NotStraight_ReturnFalse()
		{
			//Arrange
			var tri = new TriangleCheck("Треугольник", 2, 3, 4);

			//Act
			var res = tri.StraightTriangle();

			//Assert
			Assert.IsFalse(res);
		}

		[TestMethod]
		public void Square_TreeAndFiveAndSeven_Return6()
		{
			//Arrange
			var tri = new TriangleCheck("Треугольник", 1, 2, 3);
			double ex = 8;

			//Act
			var res = tri.Square();

			//Assert
			Assert.AreEqual(ex, res);
		}
	}

	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		public void Square_5_Return78_5()
		{
			//Arrange
			var circle = new CircleCheck("Круг", 5);
			double ex = 78.5;

			//Act
			var res = circle.Square();

			//Assert
			Assert.AreEqual(ex, res);
		}
	}
}
