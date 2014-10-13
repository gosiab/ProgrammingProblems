using CodilitySource._01.TimeComplexity;
using NUnit.Framework;

namespace CodilityTests._01.TimeComplexity
{
    [TestFixture]
    public class TapeEquilibriumTests
    {
        [TestCase(new[] { 3, 1, 2, 3, 4, 3 }, 2)] // Example test
        [TestCase(new[] { 3, 1, 1, 4, 3, 4, 2, 5, 2, 5 }, 2)] // Double elemnets
        [TestCase(new[] { 10, 15, 8, 4, 1 }, 12)] // Positive elements
        [TestCase(new[] { -10, -15, -8, -4, -1 }, 12)] // Negative elements
        [TestCase(new[] { 100000, 192303, 948372, 192838, 3829938 }, 2396425)] // Large elements
        [Test]
        public void TapeEqualibrium_ReturnBlah(int[] a, int expected)
        {
            // Arrange
            var tapeEquilibrium = new TapeEquilibrium();

            // Act
            var result = tapeEquilibrium.TapeEquilibriumSolution(a);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
