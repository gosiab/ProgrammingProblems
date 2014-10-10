using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using CodilitySource._01.TimeComplexity;
using NUnit.Framework;

namespace CodilityTests._01.TimeComplexity
{
    [TestFixture]
    public class ForgJumpTests
    {
        [TestCase(10, 85, 30, 3)] // Example test
        [TestCase(-10, 85, 30, -1)] // Negative jump
        [TestCase(1, 1, 1, 0)] // No jump needed
        [TestCase(10, 1000000000, 2, 499999995)] // Many jumps distance
        [TestCase(10, 1000000000, 99, 10101010)] // Many jumps distance
        [TestCase(10, 1000000000, 128, 7812500)] // Many jumps distance
        [TestCase(10, 1000000000, 1000000000, 1)] // One big jump
        [Test]
        public void FrogJump_IfFrogJumpOk_ReturnTrue(int x, int y, int d, int expected)
        {
            // Arrange
            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
