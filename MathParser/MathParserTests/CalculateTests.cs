using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathParser;

namespace MathParserTests
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void CalculateTest1()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#2#2$+";
            var output = 4d;

            // Act
            var actual = (double)mathParser.Invoke("Calculate", input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void CalculateTest2()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#5$un-#5$un+$*#5#3$un-$*$+#2#2#3$^$^#4$/$-";
            var output = -104d;

            // Act
            var actual = (double)mathParser.Invoke("Calculate", input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void CalculateTest3()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#1$un-$un-";
            var output = 1d;

            // Act
            var actual = (double)mathParser.Invoke("Calculate", input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void CalculateTest4()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#1#2$^$un-";
            var output = -1d;

            // Act
            var actual = (double)mathParser.Invoke("Calculate", input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void CalculateTest5()
        {
            // Arrange
            var mathParser = new PrivateObject(typeof(RPNParser));
            var input = "#25@sqrt";
            var output = 5d;

            // Act
            var actual = (double)mathParser.Invoke("Calculate", input);

            // Assert
            Assert.AreEqual(output, actual);
        }
    }
}
