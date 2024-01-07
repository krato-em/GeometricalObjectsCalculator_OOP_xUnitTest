using Calculator_OOP_xUnitTest._2DShapes;

namespace ShapesCalculator_OOP.Tests
{
    public class SquareTests
    {
        // Testing for AreaCalculate method:

        [Fact]
        public void AreaCalculate_ValidInput_ReturnCorrectArea()
        {
            // Arrange
            double side = 4;
            Square square = new Square();

            // Act
            double calculatedArea = square.AreaCalculate(side);

            // Assert
            double expectedArea = Math.Pow(side, 2);
            Assert.Equal(expectedArea, calculatedArea, 0.001);
        }

        [Fact]
        public void AreaCalculate_NegativeNumberInput_ThrowArgumentException()
        {
            // Arrange
            double side = -4;
            Square square = new Square();

            // Act
            Action act = () => square.AreaCalculate(side);

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
        [Fact]
        public void CircumferenceCalculate_ValidInput_ReturnCorrectCircumference()
        {
            // Arrange
            double side = 4;
            Square square = new Square();

            // Act
            double calculatedCircumference = square.CircumferenceCalculate(side);

            // Assert
            double expectedCircumference = side * 4;
            Assert.Equal(expectedCircumference, calculatedCircumference, 0.001);
        }

        [Fact]
        public void CircumferenceCalculate_NegativeNumberInput_ThrowArgumentException()
        {
            // Arrange
            Square square = new Square();
            double side = -4;

            // Act
            Action act = () => square.CircumferenceCalculate(side);

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        public void CircumferenceCalculate_NegativeNumberInput_ThrowFormatException()
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