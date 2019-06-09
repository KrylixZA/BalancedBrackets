using NUnit.Framework;

namespace BalancedBrackets.Tests
{
    [TestFixture]
    public class BracketCheckerTests
    {
        [Test]
        public void TestAreBalanced_GivenEmptyString_ShouldReturnTrue()
        {
            // Arrange & Act
            var balanced = BracketChecker.AreBalanced(string.Empty);

            // Assert
            Assert.IsTrue(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenOpenClosedBrackets_ShouldReturnTrue()
        {
            // Arrange
            var input = "[]";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsTrue(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenSingleOpenBracket_ShouldReturnFalse()
        {
            // Arrange
            var input = "[";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsFalse(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenSingleClosedBracket_ShouldReturnFalse()
        {
            // Arrange
            var input = "]";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsFalse(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenDoubleOpenClosedBrackets_ShouldReturnTrue()
        {
            // Arrange
            var input = "[][]";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsTrue(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenNestedOpenClosedBrackets_ShouldReturnTrue()
        {
            // Arrange
            var input = "[[]]";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsTrue(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenMultipleNestedOpenClosedBrackets_ShouldReturnTrue()
        {
            // Arrange
            var input = "[[[][]]]";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsTrue(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenCloseThenOpenBrackets_ShouldReturnFalse()
        {
            // Arrange
            var input = "][";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsFalse(balanced);
        }

        [Test]
        public void TestAreBalanced_GivenClosedOpenClosedOpenBrackets_ShouldReturnFalse()
        {
            // Arrange
            var input = "][][";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsFalse(balanced);
            
        }

        [Test]
        public void TestAreBalanced_GivenDoubleOpenClosedThenClosedOpenBrackets_ShouldReturnFalse()
        {
            // Arrange
            var input = "[][]][";

            // Act
            var balanced = BracketChecker.AreBalanced(input);

            // Assert
            Assert.IsFalse(balanced);
        }
    }
}