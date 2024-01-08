using Calculator_OOP_xUnitTest._2DShapes;

namespace ShapesCalculator_OOP.Tests
{
    public class SquareTests
    {
        // Testing for AreaCalculate method:

        [Theory]
        [InlineData(2, 4)]
        [InlineData(4, 16)]
        [InlineData(5.1, 26.01)]
        [InlineData(15.33, 235.0089)]
        public void AreaCalculate_ValidInput_ReturnCorrectArea(double length, double expectedArea)
        {
            // Arrange
            Square square = new Square();
            // Act
            double calculatedArea = square.AreaCalculate(length);
            // Assert
            Assert.Equal(expectedArea, calculatedArea, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(-82.11)]

        public void AreaCalculate_NegativeNumberInput_ThrowArgumentException(double length)
        {
            // Arrange
            Square square = new Square();
            // Act
            Action act = () => square.AreaCalculate(length);
            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void AreaCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Square square = new Square();
            // Act
            Action act = () => square.AreaCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(act);
        }


        // Testing for CircumferenceCalculate method
        [Theory]
        [InlineData(2, 8)]
        [InlineData(4, 16)]
        [InlineData(5.1, 20.4)]
        [InlineData(15.333, 61.332)]
        public void CircumferenceCalculate_ValidInput_ReturnCorrectCircumference(double length, double expectedCircumference)
        {
            // Arrange
            Square square = new Square();
            // Act
            double calculatedCircumference = square.CircumferenceCalculate(length);
            // Assert
            Assert.Equal(expectedCircumference, calculatedCircumference, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(-82.11)]
        public void CircumferenceCalculate_NegativeNumberInput_ThrowArgumentException(double length)
        {
            // Arrange
            Square square = new Square();
            // Act
            Action act = () => square.CircumferenceCalculate(length);
            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void CircumferenceCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Square square = new Square();
            // Act
            Action act = () => square.CircumferenceCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(act);
        }

    }
}