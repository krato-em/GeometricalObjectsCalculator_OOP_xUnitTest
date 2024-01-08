using Calculator_OOP_xUnitTest._2DShapes;


namespace ShapesCalculator_OOP.Tests
{
    public class CircleTests
    {
        // Tests for AreaCalculate method:

        [Theory]
        [InlineData(3, 28.274)]
        [InlineData(15, 706.858)]
        [InlineData(5.6, 98.5203)]
        void AreaCalculate_ValidInput_ReturnCorrectArea(double radius, double expectedArea)
        {
            // Arrange
            Circle circle = new Circle();
            // Act
            double calculatedArea = circle.AreaCalculate(radius);
            // Assert
            Assert.Equal(expectedArea, calculatedArea, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(-82.11)]
        public void AreaCalculate_NegativeNumberInput_ThrowArgumentException(double radius)
        {
            // Arrange
            Circle circle = new Circle();
            // Act
            Action act = () => circle.AreaCalculate(radius);
            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void AreaCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Circle circle = new Circle();
            // Act
            Action act = () => circle.AreaCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(act);
        }

    }
}
