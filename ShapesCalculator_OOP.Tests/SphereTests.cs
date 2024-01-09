using Calculator_OOP_xUnitTest._3DShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCalculator_OOP.Tests
{
    public class SphereTests
    {
        // Tests for SurfaceArea calculate method

        [Theory]
        [InlineData(2, 50.265)]
        [InlineData(2.5, 78.5398)]
        [InlineData(5.52, 382.902)]
        public void SurfaceAreaCalculate_ValidInput_ReturnCorrectSurfaceArea(double radius, double expectedSurfaceArea)
        {
            // Arrange
            Sphere sphere = new Sphere();
            // Act
            double calculatedSurfaceArea = sphere.SurfaceAreaCalculate(radius);
            // Assert
            Assert.Equal(expectedSurfaceArea, calculatedSurfaceArea, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-2.5)]
        [InlineData(0)]
        public void SurfaceAreaCalculate_NegativeNumberInput_ThrowArgumentException(double radius)
        {
            // Arrange
            Sphere sphere = new Sphere();
            // Act
            Action act = () => sphere.SurfaceAreaCalculate(radius);
            // Assert
            Assert.Throws<ArgumentException>(() => act());
        }

        [Fact]
        public void SurfaceAreaCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Sphere sphere = new Sphere();
            // Act
            Action act = () => sphere.SurfaceAreaCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(() => act());
        }


        // Tests for VolumeCalculate method

        [Theory]
        [InlineData(2, 33.510)]
        [InlineData(2.5, 65.4498)]
        [InlineData(5.51, 700.718)]
        public void VolumeCalculate_ValidInput_ReturnCorrectCircumference(double radius, double expectedVolume)
        {
            // Arrange
            Sphere sphere = new Sphere();
            // Act
            double calculatedVolume = sphere.VolumeCalculate(radius);
            // Assert
            Assert.Equal(expectedVolume, calculatedVolume, 0.001);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-2.5)]
        [InlineData(0)]
        public void VolumeCalculate_NegativeNumberInput_ThrowArgumentException(double radius)
        {
            // Arrange
            Sphere sphere = new Sphere();
            // Act
            Action act = () => sphere.VolumeCalculate(radius);
            // Assert
            Assert.Throws<ArgumentException>(() => act());
        }

        [Fact]
        public void VolumeCalculate_NotNumberInput_ThrowFormatException()
        {
            // Arrange
            Sphere sphere = new Sphere();
            // Act
            Action act = () => sphere.VolumeCalculate(double.NaN);
            // Assert
            Assert.Throws<FormatException>(() => act());
        }

    }
}
