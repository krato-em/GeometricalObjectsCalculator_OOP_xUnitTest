using Calculator_OOP_xUnitTest._3DShapes;

namespace ShapesCalculator_OOP.Tests
{
    public class CubeTests
    {
        // Tests for SurfaceArea calculate method

        [Theory]
        [InlineData(2, 24)]
        [InlineData(2.5, 37.5)]
        [InlineData(5.52, 182.8224)]
        public void SurfaceAreaCalculate_ValidInput_ReturnCorrectSurfaceArea(double sideA, double expectedSurfaceArea)
        {
            // Arrange
            Cube cube = new Cube();
            // Act
            double calculatedSurfaceArea = cube.SurfaceAreaCalculate(sideA);
            // Assert
            Assert.Equal(expectedSurfaceArea, calculatedSurfaceArea, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-2.5)]
        [InlineData(0)]
        public void SurfaceAreaCalculate_NegativeNumberInput_ThrowArgumentException(double sideA)
        {
            // Arrange
            Cube cube = new Cube();
            // Act
            Action act = () => cube.SurfaceAreaCalculate(sideA);
            // Assert
            Assert.Throws<ArgumentException>(() => act());
        }

        [Fact]
        public void SurfaceAreaCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Cube cube = new Cube();
            // Act
            Action act = () => cube.SurfaceAreaCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(() => act());
        }


        // Tests for VolumeCalculate method

        [Theory]
        [InlineData(2, 8)]
        [InlineData(2.5, 15.625)]
        [InlineData(5.5, 166.375)]
        public void VolumeCalculate_ValidInput_ReturnCorrectCircumference(double sideA, double expectedVolume)
        {
            // Arrange
            Cube cube = new Cube();
            // Act
            double calculatedVolume = cube.VolumeCalculate(sideA);
            // Assert
            Assert.Equal(expectedVolume, calculatedVolume, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-2.5)]
        [InlineData(0)]
        public void VolumeCalculate_NegativeNumberInput_ThrowArgumentException(double sideA)
        {
            // Arrange
            Cube cube = new Cube();
            // Act
            Action act = () => cube.VolumeCalculate(sideA);
            // Assert
            Assert.Throws<ArgumentException>(() => act());
        }

        [Fact]
        public void VolumeCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Cube cube = new Cube();
            // Act
            Action act = () => cube.VolumeCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(() => act());
        }

    }
}
