using ClassLibrary;
using NUnit.Framework.Legacy;

namespace TestProject
{
    public class ParserTests
    {
        [Test]
        public void Parse_SimpleExpression_ReturnsCorrectCalculation()
        {
            // Arrange
            var parser = new Parser();
            string input = "2+3";

            // Act
            var result = parser.Parse(input);

            // Assert
            ClassicAssert.AreEqual("2+3 = 5\n", result.ToString());
        }

        [Test]
        public void Parse_ExpressionWithBrackets_CalculatesBracketsFirst()
        {
            // Arrange
            var parser = new Parser();
            string input = "(2+3)";

            // Act
            var result = parser.Parse(input);

            // Assert
            ClassicAssert.AreEqual("(2+3) = 5\n5 = 5\n", result.ToString());
        }

        [Test]
        public void Parse_NestedBrackets_CalculatesFromInnerToOuter()
        {
            // Arrange
            var parser = new Parser();
            string input = "2+(3+4)";

            // Act
            var result = parser.Parse(input);

            // Assert
            StringAssert.Contains("(3+4) = 7", result.ToString());
            StringAssert.Contains("2+7 = 9", result.ToString());
        }

        [Test]
        public void Parse_ComplexExpression_ReturnsAllSteps()
        {
            // Arrange
            var parser = new Parser();
            string input = "2+(3-1)";

            // Act
            var result = parser.Parse(input);

            // Assert
            StringAssert.Contains("(3-1) = 2", result.ToString());
            StringAssert.Contains("2+2 = 4", result.ToString());
        }

        [Test]
        public void Parse_SingleNumber_ReturnsNumber()
        {
            // Arrange
            var parser = new Parser();
            string input = "5";

            // Act
            var result = parser.Parse(input);

            // Assert
            ClassicAssert.AreEqual("5 = 5\n", result.ToString());
        }
    }
}