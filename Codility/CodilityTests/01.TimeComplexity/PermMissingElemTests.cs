using NUnit.Framework;
using CodilitySource._01.TimeComplexity;

namespace CodilityTests._01.TimeComplexity
{
	[TestFixture]
	public class PermMissingElemTests
	{
		[TestCase(new[] {2, 3, 1, 5}, 4)] // sample test
		[TestCase(new[] {5, 2, 3, 4}, 1)] // missing first element
		[TestCase(new[] {4, 3, 1, 2}, 5)] // missing last element
		[TestCase(new[] {3}, 0)] // single elemnt
		[TestCase(new[] {2, 3, 5, 1, 2}, 4)] // double elemet
		[Test]
		public void CheckIfPermMissingElemReturnValidValue(int[] A, int expected)
		{
			// Arrange
			var missingElem = new PermMissingElem();

			// Act
			var result = missingElem.FindMissingElem(A);

			// Assert
			Assert.AreEqual(expected, result);
		}
	}
}

