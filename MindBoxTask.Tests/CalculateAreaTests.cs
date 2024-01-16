using Xunit;

namespace MindBoxTask.Tests
{
    public class CalculateAreaTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            //Arrange
            var calculateArea = new CalculateArea.CalculateArea();

            //Act
            var circleRadius = 5d;
            var circleArea = Math.Round(Math.PI * Math.Pow(circleRadius, 2), 3);
            var circleAreaMethod = calculateArea.Count(circleRadius);

            //Assert
            Assert.Equal(circleArea, circleAreaMethod);
        }

        [Fact]
        public void RectangleAreaTest()
        {
            //Arrange
            var calculateArea = new CalculateArea.CalculateArea();

            //Act
            var firstRectangleSide = 5d;
            var secondRectangleSide = 7d;
            var rectangleArea = Math.Round(firstRectangleSide * secondRectangleSide, 3);
            var rectangleAreaMethod = calculateArea.Count(firstRectangleSide, secondRectangleSide);

            //Assert
            Assert.Equal(rectangleArea, rectangleAreaMethod);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            //Arrange
            var calculateArea = new CalculateArea.CalculateArea();

            //Act
            var firstTriangleSide = 5d;
            var secondTriangleSide = 7d;
            var thirdTriangleSide = 7d;
            var trianglePerimeter = firstTriangleSide + secondTriangleSide + thirdTriangleSide;
            var halfPerimeter = trianglePerimeter / 2;
            var triangleArea = Math.Sqrt(halfPerimeter *
                (halfPerimeter - firstTriangleSide) *
                (halfPerimeter - secondTriangleSide) *
                (halfPerimeter - thirdTriangleSide));
            var triangleAreaResult = Math.Round(triangleArea, 3);
            var triangleAreaMethod = calculateArea.Count(firstTriangleSide, secondTriangleSide, thirdTriangleSide);

            //Assert
            Assert.Equal(triangleAreaResult, triangleAreaMethod);
        }
    }
}