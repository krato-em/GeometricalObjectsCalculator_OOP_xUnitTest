using Calculator_OOP_xUnitTest._2DShapes;
using Calculator_OOP_xUnitTest._3DShapes;

namespace ShapesCalculator_OOP.Tests
{
    public class BlockTests
    {
        // Tests for SurfaceAreaCalculate method

        [Theory]
        [InlineData(2, 2, 4, 40)]
        [InlineData(2.5, 4, 10, 150)]
        [InlineData(5.5, 10.5, 57.75, 1963.5)]
        public void SurfaceAreaCalculate_ValidInput_ReturnCorrectSurfaceArea(double sideA, double sideB, double sideC,
            double expectedSurfaceArea)
        {
            // Arrange
            Block block = new Block();
            // Act
            double calculatedSurfaceArea = block.SurfaceAreaCalculate(sideA, sideB, sideC);
            // Assert
            Assert.Equal(expectedSurfaceArea, calculatedSurfaceArea, 0.001);
        }

        [Theory]
        [InlineData(-2, 2, 1)]
        [InlineData(2.5, -4, 55)]
        [InlineData(0, 2, 2.0)]
        [InlineData(0, 0, 0)]
        public void SurfaceAreaCalculate_NegativeNumberInput_ThrowArgumentException(double sideA, double sideB, double sideC)
        {
            // Arrange
            Block block = new Block();
            // Act
            Action act = () => block.SurfaceAreaCalculate(sideA, sideB, sideC);
            // Assert
            Assert.Throws<ArgumentException>(() => act());
        }

        [Theory]
        [InlineData(double.NaN, double.NaN, double.NaN)]
        [InlineData(2.5, double.NaN, 5)]
        public void SurfaceAreaCalculate_NotNumberInput_ThrowFormatException(double sideA, double sideB, double sideC)
        {
            // Arrange
            Block block = new Block();
            // Act
            Action act = () => block.SurfaceAreaCalculate(sideA, sideB, sideC);
            // Assert
            Assert.Throws<FormatException>(() => act());
        }


        // Tests for VolumeCalculate method

        [Theory]
        [InlineData(2, 2, 4, 16)]
        [InlineData(2.5, 4, 10, 100)]
        [InlineData(5.5, 10.5, 57.75, 3335.0625)]
        public void VolumeCalculate_ValidInput_ReturnCorrectCircumference(double sideA, double sideB,
            double sideC, double expectedVolume)
        {
            // Arrange
            Block block = new Block();
            // Act
            double calculatedVolume = block.VolumeCalculate(sideA, sideB, sideC);
            // Assert
            Assert.Equal(expectedVolume, calculatedVolume, 0.001);
        }

        [Theory]
        [InlineData(-2, 2, 1)]
        [InlineData(2.5, -4, 55)]
        [InlineData(0, 2, 2.0)]
        [InlineData(0, 0, 0)]
        public void VolumeCalculate_NegativeNumberInput_ThrowArgumentException(double sideA, double sideB, double sideC)
        {
            // Arrange
            Block block = new Block();
            // Act
            Action act = () => block.VolumeCalculate(sideA, sideB, sideC);
            // Assert
            Assert.Throws<ArgumentException>(() => act());
        }

        [Theory]
        [InlineData(double.NaN, double.NaN, double.NaN)]
        [InlineData(2.5, double.NaN, 5)]
        public void VolumeCalculate_NotNumberInput_ThrowFormatException(double sideA, double sideB, double sideC)
        {
            // Arrange
            Block block = new Block();
            // Act
            Action act = () => block.VolumeCalculate(sideA, sideB, sideC);
            // Assert
            Assert.Throws<FormatException>(() => act());
        }
    }
}
