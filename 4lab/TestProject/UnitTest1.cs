using ClassLibrary;
using NUnit.Framework;
using System.Text;
using NUnit.Framework.Legacy;
namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WordFinder_FindWords_ReturnsWordsWithSameFirstAndLastLetter()
        {
            // Arrange
            var finder = new WordFinder();
            string input = "hello ana test moon radar";

            // Act
            var result = finder.FindWords(input);

            // Assert
            ClassicAssert.AreEqual("ana test radar ", result.ToString());
        }

        [Test]
        public void ExpressionHandler_Parse_SimpleExpression_ReturnsCorrectArray()
        {
            // Arrange
            var handler = new ExpressionHandler();
            string input = "2+3";

            // Act
            var result = handler.Parse(input);

            // Assert
            ClassicAssert.AreEqual(1, result.Length);
            ClassicAssert.AreEqual(" 2+3 ", result[0].ToString());
        }

        [Test]
        public void ExpressionHandler_Parse_MultipleOperations_ReturnsAllExpressions()
        {
            // Arrange
            var handler = new ExpressionHandler();
            string input = "2+3-1*4";

            // Act
            var result = handler.Parse(input);

            // Assert
            ClassicAssert.AreEqual(3, result.Length);
            ClassicAssert.AreEqual(" 2+3 ", result[0].ToString());
            ClassicAssert.AreEqual(" 3-1 ", result[1].ToString());
            ClassicAssert.AreEqual(" 1*4 ", result[2].ToString());
        }

        [Test]
        public void ExpressionHandler_ConvertResult_JoinsStringBuildersCorrectly()
        {
            // Arrange
            var handler = new ExpressionHandler();
            StringBuilder[] array = new StringBuilder[]
            {
                new StringBuilder(" 2+3 "),
                new StringBuilder(" 3-1 ")
            };

            // Act
            var result = handler.ConvertResult(array);

            // Assert
            ClassicAssert.AreEqual(" 2+3  3-1 ", result);
        }

    }
}