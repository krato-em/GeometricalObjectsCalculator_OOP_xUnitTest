using Calculator_OOP_xUnitTest._2DShapes;

namespace ShapesCalculator_OOP.Tests
{
    public class RectangularTests
    {
        // Testing for AreaCalculate method:

        [Fact]
        public void AreaCalculate_ValidInput_ReturnCorrectArea()
        {
            // Arrange
            double sideA = 2;
            double sideB = 4;
            Rectangular rec = new Rectangular();

            // Act
            double calculatedArea = rec.AreaCalculate(sideA, sideB);

            // Assert
            double expectedArea = sideA * sideB;
            Assert.Equal(expectedArea, calculatedArea, 0.001);
        }

        [Fact]
        public void AreaCalculate_NegativeNumberInput_ThrowArgumentException()
        {
            // Arrange
            double sideA = -2;
            double sideB = 4;
            Rectangular rec = new Rectangular();

            // Act
            Action act = () => rec.AreaCalculate(sideA, sideB);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]

        public void AreaCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Rectangular rec = new Rectangular();

            // Act
            Action act = () => rec.AreaCalculate(double.NaN, double.NaN);

            // Assert
            Assert.Throws<FormatException>(act);
        }


        // Testing for CircumferenceCalculate method

        [Fact]
        public void CircumferenceCalculate_ValidInput_ReturnCorrectCircumference()
        {
            // Arrange
            double sideA = 2;
            double sideB = 4;
            Rectangular rec = new Rectangular();

            // Act
            double calculatedCircumference = rec.CircumferenceCalculate(sideA, sideB);

            // Assert
            double expectedCircumference = 2 * (sideA + sideB);
            Assert.Equal(expectedCircumference, calculatedCircumference, 0.001);
        }

        [Fact]
        public void CircumferenceCalculate_NegativeNumberInput_ThrowArgumentException()
        {
            // Arrange
            double sideA = -4;
            double sideB = 4;
            Rectangular rec = new Rectangular();

            // Act
            Action act = () => rec.CircumferenceCalculate(sideA, sideB);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        public void CircumferenceCalculate_NegativeNumberInput_ThrowFormatException()
        {
            // Arrange
            Rectangular rec = new Rectangular();

            // Act
            Action act = () => rec.CircumferenceCalculate(double.NaN, double.NaN);

            // Assert
            Assert.Throws<FormatException>(act);
        }
    }
}
