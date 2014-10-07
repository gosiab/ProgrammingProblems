using System;
using CodilitySource;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests._01.TimeComplexityTests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        public void TapeEqulibrium_ExampleTest_ShouldReturn1()
        {
            // Arrange
            int[] a = { 3, 1, 2, 4, 3 };
            const int expected = 1;
            var tapeEquilibrium = new TapeEquilibrium();

            // Act
            var result = tapeEquilibrium.TapeEquilibriumSolution(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TapeEqulibrium_DoubleElements_ShouldReturn2()
        {
            // Arrange
            int[] a = { 3, 1, 1, 4, 3, 4, 2, 5, 2, 5 };
            const int expected = 2;
            var tapeEquilibrium = new TapeEquilibrium();

            // Act
            var result = tapeEquilibrium.TapeEquilibriumSolution(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TapeEqualibrium_PositiveElements_ShouldReturn12()
        {
            // Arrange
            int[] a = { 10, 15, 8, 4, 1 };
            const int expected = 12;
            var tapeEquilibrium = new TapeEquilibrium();

            // Act
            var result = tapeEquilibrium.TapeEquilibriumSolution(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TapeEqualibrium_NegativeElements_ShouldReturn12()
        {
            // Arrange
            int[] a = { -10, -15, -8, -4, -1 };
            const int expected = 12;
            var tapeEquilibrium = new TapeEquilibrium();

            // Act
            var result = tapeEquilibrium.TapeEquilibriumSolution(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TapeEqualibrium_LargeElements_ShouldReturn2396425()
        {
            // Arrange
            int[] a = { 100000, 192303, 948372, 192838, 3829938 };
            const int expected = 2396425;
            var tapeEquilibrium = new TapeEquilibrium();

            // Act
            var result = tapeEquilibrium.TapeEquilibriumSolution(a);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
