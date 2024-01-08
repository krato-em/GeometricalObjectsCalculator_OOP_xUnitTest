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
    }
}
