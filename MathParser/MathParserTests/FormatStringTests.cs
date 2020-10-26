using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathParser;

namespace MathParserTests
{
    [TestClass]
    public class FormatStringTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FormatStringTest1()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(Parser));

            // Act
            var actual = (string)mathParser.Invoke("FormatString", string.Empty);

            // Assert
        }

        [TestMethod]
        public void FormatStringTest2()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(Parser));
            var input = "\t2 - 2  + COS(60)";
            var output = "2-2+cos(60)";

            // Act
            var actual = (string)mathParser.Invoke("FormatString", input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatStringTest3()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(Parser));
            var input = "\t2 - 2  + COS60)";

            // Act
            var actual = (string)mathParser.Invoke("FormatString", input);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void FormatStringTest4()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(Parser));
            var input = "\t2 - 2  + COS((60)";

            // Act
            var actual = (string)mathParser.Invoke("FormatString", input);
        }
    }
}
