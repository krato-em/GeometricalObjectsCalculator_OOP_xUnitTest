using Calculator_OOP_xUnitTest._2DShapes;
using Xunit;

namespace ShapesCalculator_OOP.Tests
{
    public class RectangularTests
    {
        
        // Tests for AreaCalculate method:

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2.5,4,10)]
        [InlineData(5.5,10.5,57.75)]
        public void AreaCalculate_ValidInput_ReturnCorrectArea(double sideA, double sideB, double expectedArea)
        {
            // Arrange
            Rectangular rec = new Rectangular();
            // Act
            double calculatedArea = rec.AreaCalculate(sideA, sideB);
            // Assert
            Assert.Equal(expectedArea, calculatedArea, 0.001);
        }

        [Theory]
        [InlineData(-2, -2)]
        [InlineData(2.5, -4)]
        [InlineData(0, 2)]
        public void AreaCalculate_NegativeNumberInput_ThrowArgumentException(double sideA, double sideB)
        {
            // Arrange
            Rectangular rec = new Rectangular();
            // Act
            Action act = () => rec.AreaCalculate(sideA, sideB);
            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Theory]
        [InlineData(double.NaN, double.NaN)]
        [InlineData(2.5, double.NaN)]

        public void AreaCalculate_NotNumberInput_ThrowFormatException(double sideA, double sideB)
        {
            // Arrange
            Rectangular rec = new Rectangular();
            // Act
            Action act = () => rec.AreaCalculate(sideA, sideB);
            // Assert
            Assert.Throws<FormatException>(act);
        }


        // Tests for CircumferenceCalculate method

        [Theory]
        [InlineData(2, 4, 12)]
        [InlineData(2.5, 4, 13)]
        [InlineData(5.5, 10.5, 32)]
        public void CircumferenceCalculate_ValidInput_ReturnCorrectCircumference(double sideA, double sideB, double expectedCircumference)
        {
            // Arrange
            Rectangular rec = new Rectangular();
            // Act
            double calculatedCircumference = rec.CircumferenceCalculate(sideA, sideB);
            // Assert
            Assert.Equal(expectedCircumference, calculatedCircumference, 0.001);
        }

        [Theory]
        [InlineData(-2, -2)]
        [InlineData(2.5, -4)]
        [InlineData(0, 2)]
        public void CircumferenceCalculate_NegativeNumberInput_ThrowArgumentException(double sideA, double sideB)
        {
            // Arrange
            Rectangular rec = new Rectangular();
            // Act
            Action act = () => rec.CircumferenceCalculate(sideA, sideB);
            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Theory]
        [InlineData(double.NaN, double.NaN)]
        [InlineData(2.5, double.NaN)]
        public void CircumferenceCalculate_NotNumberInput_ThrowFormatException(double sideA, double sideB)
        {
            // Arrange
            Rectangular rec = new Rectangular();
            // Act
            Action act = () => rec.CircumferenceCalculate(sideA, sideB);

            // Assert
            Assert.Throws<FormatException>(act);
        }
    }
}
