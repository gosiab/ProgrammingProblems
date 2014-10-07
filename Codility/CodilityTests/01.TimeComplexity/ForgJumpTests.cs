using CodilitySource._01.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTests._01.TimeComplexity
{
    [TestClass]
    public class ForgJumpTests
    {
        [TestMethod]
        public void FrogJump_ExampleTest_Return3()
        {
            // Arrange
            const int x = 10;
            const int y = 85;
            const int d = 30;
            const int expected = 3;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FrogJump_NegativeJump_ReturnMinus1()
        {
            // Arrange
            const int x = -10;
            const int y = 85;
            const int d = 30;
            const int expected = -1;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FrogJump_NoJumpNedded_Return0()
        {
            // Arrange
            const int x = 1;
            const int y = 1;
            const int d = 1;
            const int expected = 0;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FrogJump_ManyJumps2Disctance_Return499999995()
        {
            // Arrange
            const int x = 10;
            const int y = 1000000000;
            const int d = 2;
            const int expected = 499999995;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FrogJump_ManyJumps99Distance_Return10101010()
        {
            // Arrange
            const int x = 10;
            const int y = 1000000000;
            const int d = 99;
            const int expected = 10101010;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FrogJump_ManyJumps1283Distance_Return779424()
        {
            // Arrange
            const int x = 10;
            const int y = 1000000000;
            const int d = 1283;
            const int expected = 779424;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FrogJump_OneBigJump_Return1()
        {
            // Arrange
            const int x = 10;
            const int y = 1000000000;
            const int d = 1000000000;
            const int expected = 1;

            var frogJump = new FrogJump();

            // Act
            var result = frogJump.Jump(x, y, d);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
